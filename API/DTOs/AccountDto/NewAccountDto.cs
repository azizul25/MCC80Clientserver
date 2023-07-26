﻿using API.Models;

namespace API.DTOs.AccountDto;

public class NewEmpolyeeNikDto
{
    public Guid Guid { get; set; }
    public string Password { get; set; }
    public int Otp { get; set; }
    public bool Isused { get; set; }
    public DateTime EcpiredTime { get; set; }

    public static implicit operator Account(NewEmpolyeeNikDto newAccountDto)
    {
        return new Account
        {
            Guid = newAccountDto.Guid,
            Password = newAccountDto.Password,
            Otp = newAccountDto.Otp,
            Isused = newAccountDto.Isused,
            EcpiredTime = DateTime.Now,
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now
        };
    }

    public static explicit operator NewEmpolyeeNikDto(Account account)
    {
        return new NewEmpolyeeNikDto
        {
            Guid = account.Guid,
            Password = account.Password,
            Otp = account.Otp,
            Isused = account.Isused
        };
    }
}
