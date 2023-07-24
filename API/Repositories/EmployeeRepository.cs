using API.Contracts;
using API.Models;

namespace API.Repositories;

public class EmployeeRepository : GeneralRepository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(BookingDbContext context) : base(context) { }

    public bool IsNotExist(String value)
    {
        return _context.Set<Employee>()
            .SingleOrDefault(e => e.Email.Contains(value) ||
             e.PhoneNumber.Contains(value)) is null;
           
    }
}
