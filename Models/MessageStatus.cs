namespace Chat.Api.Models;

public class MessageStatus
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid MessageId { get; set; }
    public string UserId { get; set; }
    public MessageStatusType Status { get; set; } = MessageStatusType.Sent;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public virtual Message Message { get; set; }
    public virtual User User { get; set; }
}

public enum MessageStatusType
{
    Sent = 1,
    Delivered = 2,
    Read = 3,
}
