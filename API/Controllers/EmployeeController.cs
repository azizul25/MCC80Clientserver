﻿using API.DTOs.EmployeeDto;
using API.Services;
using API.Utilities.Handlers;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers;

[ApiController]
[Route("api/employees")]
public class EmployeeController : ControllerBase
{
    private readonly EmployeeService _employeeService;

    public EmployeeController(EmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var result = _employeeService.GetAll();
        if (!result.Any())
        {
            return NotFound(new ResponseHandler<EmployeeDto>
            {
                Code = StatusCodes.Status404NotFound,
                Status = HttpStatusCode.NotFound.ToString(),
                Message = "Data not found"
            });
        }

        return Ok(new ResponseHandler<IEnumerable<EmployeeDto>>
        {
            Code = StatusCodes.Status200OK,
            Status = HttpStatusCode.OK.ToString(),
            Message = "Success retrieve data",
            Data = result
        });
    }



    [HttpGet("{guid}")]
    public IActionResult GetByGuid(Guid guid)
    {
        var result = _employeeService.GetByGuid(guid);
        if (result is null)
        {
            return NotFound(new ResponseHandler<EmployeeDto>
            {
                Code = StatusCodes.Status404NotFound,
                Status = HttpStatusCode.NotFound.ToString(),
                Message = "Guid is not found",
                Data = result
            });
        }

        return Ok(new ResponseHandler<EmployeeDto>
        {
            Code = StatusCodes.Status200OK,
            Status = HttpStatusCode.OK.ToString(),
            Message = "Success retrieve data",
            Data = result
        });
    }

    [HttpPost]
    public IActionResult Insert(NewEmployeeDto newEmployeeDto)
    {
        var result = _employeeService.Create(newEmployeeDto);
        if (result is null)
        {
            return StatusCode(500, new ResponseHandler<EmployeeDto>
            {
                Code = StatusCodes.Status500InternalServerError,
                Status = HttpStatusCode.InternalServerError.ToString(),
                Message = "Error retrieve data",
                Data = result
            });
        }


        return Ok(new ResponseHandler<EmployeeDto>
        {
            Code = StatusCodes.Status200OK,
            Status = HttpStatusCode.OK.ToString(),
            Message = "Data success inserted",
            Data = result
        });
    }

    [HttpPut]
    public IActionResult Update(EmployeeDto employeeDto)
    {
        var result = _employeeService.Update(employeeDto);
        if (result is -1)
        {
            return NotFound("Guid is not found");
        }

        if (result is 0)
        {
            return StatusCode(500, new ResponseHandler<EmployeeDto>
            {
                Code = StatusCodes.Status500InternalServerError,
                Status = HttpStatusCode.InternalServerError.ToString(),
                Message = "Error retrieve data",
                Data = null
            });
            //return StatusCode(500, "Error Retrieve from database");
        }

        return Ok(new ResponseHandler<int>
        {
            Code = StatusCodes.Status200OK,
            Status = HttpStatusCode.OK.ToString(),
            Message = "Update success",
            Data = result
        });
    }

    [HttpDelete]
    public IActionResult Delete(Guid guid)
    {
        var result = _employeeService.Delete(guid);

        if (result is -1)
        {
            return NotFound("Guid is not found");
        }

        if (result is 0)
        {
            return StatusCode(500, new ResponseHandler<EmployeeDto>
            {
                Code = StatusCodes.Status500InternalServerError,
                Status = HttpStatusCode.InternalServerError.ToString(),
                Message = "Server error",
                Data = null
            });
        }

        return Ok(new ResponseHandler<int>
        {
            Code = StatusCodes.Status200OK,
            Status = HttpStatusCode.OK.ToString(),
            Message = "Delete success",
            Data = result
        });
    }

    [HttpGet("employees-detail")]
    public IActionResult GetAllEmployeeDetail()
    {
        var result = _employeeService.GetAllEmployeeDetail();
        if (!result.Any())
        {
            return NotFound(new ResponseHandler<EmployeeDetailDTO>
            {
                Code = StatusCodes.Status404NotFound,
                Status = HttpStatusCode.NotFound.ToString(),
                Message = "data not found"
            });
        }

        return Ok(new ResponseHandler<IEnumerable<EmployeeDetailDTO>>
        {
            Code = StatusCodes.Status200OK,
            Status = HttpStatusCode.OK.ToString(),
            Message = "Success retrieve data",
            Data = result
        });
    }

    [HttpGet("employees-detail/{guid}")]
    public IActionResult GetEmployeeDetailByGuid(Guid guid)
    {
        var result = _employeeService.GetEmployeeDetailByGuid(guid);
        if (result is null)
        {
            return NotFound(new ResponseHandler<EmployeeDetailDTO>
            {
                Code = StatusCodes.Status404NotFound,
                Status = HttpStatusCode.NotFound.ToString(),
                Message = "guid not found"
            });
        }

        return Ok(new ResponseHandler<EmployeeDetailDTO>
        {
            Code = StatusCodes.Status200OK,
            Status = HttpStatusCode.OK.ToString(),
            Message = "Success retrieve data",
            Data = result
        });
    }
}
