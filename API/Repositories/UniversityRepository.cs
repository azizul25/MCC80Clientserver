using API.Contracts;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class UniversityRepository : GeneralRepository<University>, IUniversityRepository
{
    public UniversityRepository(BookingDbContext context) : base(context) { }

    public IEnumerable<University> GetByName(string name)
    {
        return _context.Set<University>()
                       .Where(university => university.Name.Contains(name))
                       .ToList();
    }

    public bool IsNotExist(String value)
    {
        return _context.Set<University>()
            .SingleOrDefault(u => u.Name.Contains(value) ||
             u.Code.Contains(value)) is null;

    }
}