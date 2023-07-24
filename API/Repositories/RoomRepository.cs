using API.Contracts;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class RoomRepository : GeneralRepository<Room>, IRoomRepository
{
    public RoomRepository(BookingDbContext context) : base(context) { }
    public bool IsNotExist(String value)
    {
        return _context.Set<Room>()
            .SingleOrDefault(r => r.Name.Contains(value)) is null;

    }

}
