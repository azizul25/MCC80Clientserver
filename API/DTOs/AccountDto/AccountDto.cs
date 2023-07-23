using API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DTOs.AccountDto;

public class AccountDto
{
    public Guid Guid { get; set; }
    public string Password { get; set; }
    public int Otp { get; set; }
    public bool Isused { get; set; }
    public DateTime EcpiredTime { get; set; }

    public static implicit operator Account(AccountDto accountDto)
    {
        return new Account
        {
            Guid = accountDto.Guid,
            Password = accountDto.Password,
            Otp = accountDto.Otp,
            Isused = accountDto.Isused,
            EcpiredTime = DateTime.Now,
            ModifiedDate = DateTime.Now
        };
    }

    public static explicit operator AccountDto(Account account)
    {
        return new AccountDto
        {
            Guid = account.Guid,
            Password = account.Password,
            Otp = account.Otp,
            Isused = account.Isused
        };
    }
}
