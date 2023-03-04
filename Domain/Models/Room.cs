using Domain.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Room
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public RoomStatus Status { get; set; }


    [ForeignKey("RoomType")]
    public Guid RoomTypeId { get; set; }
    public virtual RoomType? RoomType { get; set; }
}
