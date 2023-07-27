using API.Contracts;
using API.DTOs.EmployeeDto;
using API.Models;
using API.Repositories;
using API.Utilities.Handler;

namespace API.Services;

public class EmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IEducationRepository _educationRepository;
    private readonly IUniversityRepository _universityRepository;

    public EmployeeService(IEmployeeRepository employeeRepository, IEducationRepository educationRepository, IUniversityRepository universityRepository)
    {
        _employeeRepository = employeeRepository;
        _educationRepository = educationRepository;
        _universityRepository = universityRepository;
    }

    public IEnumerable<EmployeeDto> GetAll()
    {
        var employees = _employeeRepository.GetAll();
        if (!employees.Any())
        {
            return Enumerable.Empty<EmployeeDto>(); // Employee is null or not found;
        }

        var employeeDtos = new List<EmployeeDto>();
        foreach (var employee in employees)
        {
            employeeDtos.Add((EmployeeDto)employee);
        }

        return employeeDtos; // Employee is found;
    }

    public EmployeeDto? GetByGuid(Guid guid)
    {
        var employee = _employeeRepository.GetByGuid(guid);
        if (employee is null)
        {
            return null; // Employee is null or not found;
        }

        return (EmployeeDto)employee; // Employee is found;
    }

    public EmployeeDto? Create(NewEmployeeDto newEmployeeDto)
    {
        Employee toCreate = newEmployeeDto;
        toCreate.Nik = GeneralHandler.Nik(_employeeRepository.GetLastNik());

        var employee = _employeeRepository.Create(newEmployeeDto);
        if (employee is null)
        {
            return null; // Employee is null or not found;
        }

        return (EmployeeDto)employee; // Employee is found;
    }

    public int Update(EmployeeDto employeeDto)
    {
        var employee = _employeeRepository.GetByGuid(employeeDto.Guid);
        if (employee is null)
        {
            return -1; // Employee is null or not found;
        }

        Employee toUpdate = employeeDto;
        toUpdate.CreatedDate = employee.CreatedDate;
        var result = _employeeRepository.Update(toUpdate);

        return result ? 1 // Employee is updated;
            : 0; // Employee failed to update;
    }

    public int Delete(Guid guid)
    {
        var employee = _employeeRepository.GetByGuid(guid);
        if (employee is null)
        {
            return -1; // Employee is null or not found;
        }

        var result = _employeeRepository.Delete(employee);

        return result ? 1 // Employee is deleted;
            : 0; // Employee failed to delete;
    }

    public IEnumerable<EmployeeDetailDTO> GetAllEmployeeDetail()
    {
        var employeesDetailDto = from e in _employeeRepository.GetAll()
                              join education in _educationRepository.GetAll() on e.Guid equals education.Guid
                              join university in _universityRepository.GetAll() on education.UniversityGuid equals university.Guid
                              select new EmployeeDetailDTO
                              {
                EmployeeGuid = e.Guid,
                NIK = e.Nik,
                FullName = e.FirstName + " " + e.LastName,
                BirthDate = e.BirthDate,
                Gender = e.Gender,
                HiringDate = e.HiringDate,
                Email = e.Email,
                PhoneNumber = e.PhoneNumber,
                Major = education.Major,
                Degree = education.Degree,
                GPA = education.GPA,
                UniversityName = university.Name
            };

        return employeesDetailDto; // employeeDetail is found;
    }

    public EmployeeDetailDTO? GetEmployeeDetailByGuid(Guid guid)
    {
        return GetAllEmployeeDetail().SingleOrDefault(e => e.EmployeeGuid == guid); // employeeDetail is found;


    }
}