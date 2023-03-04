using Domain.Models.Enums;

namespace Domain.Models;

public class Booking
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public DateTime CheckInDate { get; set; }

    public DateTime CheckOutDate { get; set; }

    public Guid CustomerId { get; set; }

    public Guid RoomId { get; set; }

    public BookingStatus Status { get; set; }
}
