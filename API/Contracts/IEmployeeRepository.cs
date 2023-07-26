using API.Models;

namespace API.Contracts;

public interface IEmployeeRepository : IGeneralRepository<Employee>
{
    string? GetLastNik();
    bool IsNotExist(String value);
    Employee? GetByEmail(string email);
    Guid GetLastEmployeeGuid();

}
