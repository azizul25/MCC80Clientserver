using API.Models;

namespace API.Contracts;

public interface IRoleRepository : IGeneralRepository<Role>
{
    bool IsNotExist(String value);
}
