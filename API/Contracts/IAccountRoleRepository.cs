using API.Models;

namespace API.Contracts;

public interface IAccountRoleRepository : IGeneralRepository<AccountRole>
{
    bool IsNotExist(String value);
}
