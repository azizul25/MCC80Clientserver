using API.Contracts;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class RoleRepository : GeneralRepository<Role>, IRoleRepository
{
    public RoleRepository(BookingDbContext context) : base(context) { }
    public bool IsNotExist(String value)
    {
        return _context.Set<Role>()
            .SingleOrDefault(o => o.Name.Contains(value)) is null;

    }
}