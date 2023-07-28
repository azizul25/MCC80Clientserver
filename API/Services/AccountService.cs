using API.Contracts;
using API.DTOs.AccountDto;
using API.DTOs.Accounts;
using API.DTOs.EducationDto;
using API.DTOs.EmployeeDto;
using API.DTOs.UniversityDto;
using API.Models;
using API.Utilities.Handler;


namespace API.Services;

public class AccountService
{
    private readonly IAccountRepository _accountRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IEducationRepository _educationRepository;
    private readonly IUniversityRepository _universityRepository;

    public AccountService(IAccountRepository accountRepository, IEmployeeRepository employeeRepository, IEducationRepository educationRepository,
        IUniversityRepository universityRepository)
    {
        _accountRepository = accountRepository;
        _employeeRepository = employeeRepository;
        _educationRepository = educationRepository;
        _universityRepository = universityRepository;
    }

    public RegisterDto? Register(RegisterDto registerDto)
    {

        Employee createEmployee = new NewEmployeeDto
        {
            FirstName = registerDto.FirstName,
            LastName = registerDto.LastName,
            BirthDate = registerDto.BirthDate,
            Gender = registerDto.Gender,
            HiringDate = registerDto.HiringDate,
            Email = registerDto.Email,
            PhoneNumber = registerDto.PhoneNumber
        };

        createEmployee.Nik = GeneralHandler.Nik(_employeeRepository.GetLastNik());
        var employeeResult = _employeeRepository.Create(createEmployee);

        var universityResult = _universityRepository.Create(new NewUniversityDto
        {
            Code = registerDto.UniversityCode,
            Name = registerDto.UniversityName
        });

        var educationResullt = _educationRepository.Create(new NewEducationDto
        {
            Guid = _employeeRepository.GetLastEmployeeGuid(),
            Degree = registerDto.Degree,
            Major = registerDto.Major,
            GPA = registerDto.GPA,
            UniversityGuid = _universityRepository.GetLastUniversityGuid()
        });

        var accountResult = _accountRepository.Create(new NewAccountDto
        {
            Guid = _employeeRepository.GetLastEmployeeGuid(),
            Isused = true,
            EcpiredTime = DateTime.Now.AddYears(1),
            Otp = 000,
            Password = registerDto.Password,
        });

        if (employeeResult is null || universityResult is null || educationResullt is null || accountResult is null)
        {
            return null;
        }

        return (RegisterDto)registerDto;

    }
    public int Login(LoginDto loginDto)
    {
        var getEmployee = _employeeRepository.GetByEmail(loginDto.Email);

        if (getEmployee is null)
        {
            return 0; // Employee not found
        }

        var getAccount = _accountRepository.GetByGuid(getEmployee.Guid);

        if (getAccount.Password == loginDto.Password)
        {
            return 1; // Login success
        }

        return 0;
    }

    public IEnumerable<AccountDto> GetAll()
    {
        var accounts = _accountRepository.GetAll();
        if (!accounts.Any())
        {
            return Enumerable.Empty<AccountDto>(); // Account is null or not found;
        }

        var accountDtos = new List<AccountDto>();
        foreach (var account in accounts)
        {
            accountDtos.Add((AccountDto)account);
        }

        return accountDtos; // Account is found;
    }

    public AccountDto? GetByGuid(Guid guid)
    {
        var account = _accountRepository.GetByGuid(guid);
        if (account is null)
        {
            return null; // Account is null or not found;
        }

        return (AccountDto)account; // Account is found;
    }

    public AccountDto? Create(NewAccountDto newAccountDto)
    {
        var account = _accountRepository.Create(newAccountDto);
        if (account is null)
        {
            return null; // Account is null or not found;
        }

        return (AccountDto)account; // Account is found;
    }

    public int Update(AccountDto accountDto)
    {
        var account = _accountRepository.GetByGuid(accountDto.Guid);
        if (account is null)
        {
            return -1; // Account is null or not found;
        }

        Account toUpdate = accountDto;
        toUpdate.CreatedDate = account.CreatedDate;
        var result = _accountRepository.Update(toUpdate);

        return result ? 1 // Account is updated;
            : 0; // Account failed to update;
    }

    public int Delete(Guid guid)
    {
        var account = _accountRepository.GetByGuid(guid);
        if (account is null)
        {
            return -1; // Account is null or not found;
        }

        var result = _accountRepository.Delete(account);

        return result ? 1 // Account is deleted;
            : 0; // Account failed to delete;
    }

    //
    public int ForgotPassword(ForgotPasswordDto forgotPasswordDto)
    {
        var otp = new Random().Next(111111, 999999);
        var getAccountDetail = (from e in _employeeRepository.GetAll()
                                join a in _accountRepository.GetAll() on e.Guid equals a.Guid
                                where e.Email == forgotPasswordDto.Email
                                select a).FirstOrDefault();

        if (getAccountDetail is null)
        {
            return 0; // no email found
        }


        var isUpdated = _accountRepository.Update(new Account
        {
            Guid = getAccountDetail.Guid,
            Password = getAccountDetail.Password,
            EcpiredTime = DateTime.Now.AddMinutes(5),
            Otp = otp,
            Isused = false,
            CreatedDate = getAccountDetail.CreatedDate,
            ModifiedDate = getAccountDetail.ModifiedDate
        });

        if (!isUpdated)
        {
            return -1; // error update
        }

        return 1;
    }

    public int ChangePassword(ChangePasswordDto changePasswordDto)
    {
        var getAccount = (from e in _employeeRepository.GetAll()
                          join a in _accountRepository.GetAll() on e.Guid equals a.Guid
                          where e.Email == changePasswordDto.Email
                          select a).FirstOrDefault();

        if (getAccount is null)
        {
            return 0;
        }

        var account = new Account
        {
            Guid = getAccount.Guid,
            Isused = true,
            ModifiedDate = DateTime.Now,
            CreatedDate = getAccount.CreatedDate,
            Otp = getAccount.Otp,
            EcpiredTime = getAccount.EcpiredTime,
            Password = HashHandler.GenerateHash(changePasswordDto.Password),
        };

        if (getAccount.Otp != changePasswordDto.Otp)
        {
            return -1;
        }

        if (getAccount.Isused == true)
        {
            return -2;
        }

        if (getAccount.EcpiredTime < DateTime.Now)
        {
            return -3; // OTP expired
        }


        var isUpdated = _accountRepository.Update(account);
        if (!isUpdated)
        {
            return -4; //Account not Update
        }

        return 3;
    }
}
