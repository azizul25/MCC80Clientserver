using API.Models;

namespace API.Contracts;

public interface IRoomRepository : IGeneralRepository<Room>
{
    bool IsNotExist(String value);
}
