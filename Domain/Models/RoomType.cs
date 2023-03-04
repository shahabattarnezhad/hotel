namespace Domain.Models;

public class RoomType
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public bool IsAvailable { get; set; }


    public virtual ICollection<Room>? Rooms { get; set; }
}
