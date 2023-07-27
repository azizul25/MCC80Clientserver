﻿using API.Contracts;
using API.DTOs.EmployeeDto;
using API.DTOs.RoomDto;
using API.Models;
using API.Repositories;

namespace API.Services;

public class RoomService
{
    private readonly IRoomRepository _roomRepository;
    private readonly IBookingRepository _bookingRepository;
    private readonly IEmployeeRepository _employeeRepository;

    public RoomService(IRoomRepository roomRepository, IBookingRepository bookingRepository, IEmployeeRepository employeeRepository)
    {
        _roomRepository = roomRepository;
        _bookingRepository = bookingRepository;
        _employeeRepository = employeeRepository;
    }

    public IEnumerable<RoomDto> GetAll()
    {
        var rooms = _roomRepository.GetAll();
        if (!rooms.Any())
        {
            return Enumerable.Empty<RoomDto>(); // Room is null or not found;
        }

        var roomDtos = new List<RoomDto>();
        foreach (var room in rooms)
        {
            roomDtos.Add((RoomDto)room);
        }

        return roomDtos; // Room is found;
    }

    public RoomDto? GetByGuid(Guid guid)
    {
        var room = _roomRepository.GetByGuid(guid);
        if (room is null)
        {
            return null; // Room is null or not found;
        }

        return (RoomDto)room; // Room is found;
    }

    public RoomDto? Create(NewRoomDto newRoomDto)
    {
        var room = _roomRepository.Create(newRoomDto);
        if (room is null)
        {
            return null; // Room is null or not found;
        }

        return (RoomDto)room; // Room is found;
    }

    public int Update(RoomDto roomDto)
    {
        var room = _roomRepository.GetByGuid(roomDto.Guid);
        if (room is null)
        {
            return -1; // Room is null or not found;
        }

        Room toUpdate = roomDto;
        toUpdate.CreatedDate = room.CreatedDate;
        var result = _roomRepository.Update(toUpdate);

        return result ? 1 // Room is updated;
            : 0; // Room failed to update;
    }

    public int Delete(Guid guid)
    {
        var room = _roomRepository.GetByGuid(guid);
        if (room is null)
        {
            return -1; // Room is null or not found;
        }

        var result = _roomRepository.Delete(room);

        return result ? 1 // Room is deleted;
            : 0; // Room failed to delete;
    }

    public IEnumerable<BookedRoomDTO> GetAllBookedRoomToday()
    {
        var today = DateTime.Today.ToString("dd-MM-yyyy");
        var bookings = _bookingRepository.GetAll()
                        .Where(b => b.StarDate.ToString("dd-MM-yyyy").Equals(today));

        if (!bookings.Any())
        {
            return Enumerable.Empty<BookedRoomDTO>();
        }

        var bookedRoomTodayDtos = new List<BookedRoomDTO>();

        foreach (var booking in bookings)
        {
            var employee = _employeeRepository.GetByGuid(booking.EmployeeGuid);
            var room = _roomRepository.GetByGuid(booking.RoomGuid);

            BookedRoomDTO bookedRoom = new BookedRoomDTO
            {
                BookingGuid = booking.Guid,
                RoomName = room.Name,
                Status = booking.Status,
                Floor = room.Floor,
                BookedBy = employee.FirstName + " " + employee.LastName
            };
            bookedRoomTodayDtos.Add(bookedRoom);
        }

        return bookedRoomTodayDtos; // room is found;
    }
    //

    public IEnumerable<BookedRoomDTO> GetAllBookedRoomDetail()
    {
 
        var bookings = _bookingRepository.GetAll();
      

        if (!bookings.Any())
        {
            return Enumerable.Empty<BookedRoomDTO>();
        }

        var bookedRoomTodayDtos = new List<BookedRoomDTO>();

        foreach (var booking in bookings)
        {
            var employee = _employeeRepository.GetByGuid(booking.EmployeeGuid);
            var room = _roomRepository.GetByGuid(booking.RoomGuid);

            BookedRoomDTO bookedRoom = new BookedRoomDTO
            {
                BookingGuid = booking.Guid,
                RoomName = room.Name,
                Status = booking.Status,
                Floor = room.Floor,
                BookedBy = employee.FirstName + " " + employee.LastName
            };
            bookedRoomTodayDtos.Add(bookedRoom);
        }

        return bookedRoomTodayDtos; // room is found;
    }
    //
    public BookedRoomDTO? GetBookedDetailByGuid(Guid guid)
    {
        var today = DateTime.Today.ToString("dd-MM-yyyy");
        var bookeeds = (from booking in _bookingRepository.GetAll()
                        join employee in _employeeRepository.GetAll() on booking.EmployeeGuid equals employee.Guid
                        join room in _roomRepository.GetAll() on booking.RoomGuid equals room.Guid
                        where booking.StarDate.ToString("dd-MM-yyyy") == today
                        select new BookedRoomDTO
        {
            BookingGuid = booking.Guid,
            RoomName = room.Name,
            Status = booking.Status,
            Floor = room.Floor,
            BookedBy = employee.FirstName + " " + employee.LastName
        }); // employeeDetail is found;

     
        return (BookedRoomDTO?)bookeeds; // room is found;
    }
}
