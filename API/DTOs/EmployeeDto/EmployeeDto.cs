﻿using API.Models;
using API.Utilities.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DTOs.EmployeeDto;

public class EmployeeDto
{
    public Guid Guid { get; set; }
    public string Nik { get; set; }
    public string Firstname { get; set; }
    public string? Lastname { get; set; }
    public DateTime Birtdate { get; set; }
    public GenderLevel Gender { get; set; }
    public DateTime Hiringdate { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public static implicit operator Employee(EmployeeDto employeeDto)
    {
        return new Employee
        {
            Guid = employeeDto.Guid,
            Nik = employeeDto.Nik,
            FirstName = employeeDto.Firstname,
            LastName = employeeDto.Lastname,
            BirthDate = employeeDto.Birtdate,
            Gender = employeeDto.Gender,
            Email = employeeDto.Email,
            PhoneNumber = employeeDto.PhoneNumber,
            ModifiedDate = DateTime.Now
        };
    }

    public static explicit operator EmployeeDto(Employee employee)
    {
        return new EmployeeDto
        {
            Guid = employee.Guid,
            Nik = employee.Nik,
            Firstname = employee.FirstName,
            Lastname = employee.LastName,
            Birtdate = employee.BirthDate,
            Gender = employee.Gender,
            Email = employee.Email,
            PhoneNumber = employee.PhoneNumber
        };
    }
}
