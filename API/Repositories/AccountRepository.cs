using API.Contracts;
using API.Models;

namespace API.Repositories;

public class AccountRepository : GeneralRepository<Account>, IAccountRepository
{
    public AccountRepository(BookingDbContext context) : base(context) { }
    public bool IsNotExist(String value)
    {
        return _context.Set<Employee>()
            .SingleOrDefault(e => e.Email.Contains(value) ||
             e.PhoneNumber.Contains(value)) is null;

    }
}

