using API.Contracts;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly BookingDbContext _context;

    public AccountRepository(BookingDbContext context)
    {
        _context = context;
    }

   
    public IEnumerable<Account> GetAll()
    {
        return _context.Set<Account>().ToList();    
    }

    public Account? GetByGuid(Guid guid)
    {
        return _context.Set<Account>().Find(guid);   
    }
    public Account? Create(Account account)
    {
        try
        {
            _context.Set<Account>().Add(account);   
            _context.SaveChanges();                      
            return account;

        }
        catch
        {
            return null;
        }
    }

    public bool Update(Account account)
    {
        try
        {
            _context.Entry(account).State = EntityState.Modified;    
            _context.SaveChanges();                                     
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool Delete(Account account)
    {
        try
        {
            _context.Set<Account>().Remove(account);              
            _context.SaveChanges();                                    
            return true;
        }
        catch
        {
            return false;
        }
    }
}
