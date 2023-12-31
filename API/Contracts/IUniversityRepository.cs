﻿using API.Models;

namespace API.Contracts;

public interface IUniversityRepository : IGeneralRepository<University>
{
    IEnumerable<University> GetByName(string name);
    bool IsNotExist(String value);
    Guid GetLastUniversityGuid();
    University? GetByCode(string code);
}
