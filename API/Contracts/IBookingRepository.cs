using API.Models;

namespace API.Contracts;

public interface IBookingRepository : IGeneralRepository<Booking>
{

    bool IsNotExist(String value);
}
