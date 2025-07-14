using System.Reflection;

namespace Chat.Api.Models;

public class Message
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ChatId { get; set; }
    public string SenderId { get; set; }
    public string? Content { get; set; }
    public MessageType Type { get; set; } = MessageType.Text;
    public string? FileUrl { get; set; }
    public string? FileName { get; set; }
    public long? FileSize { get; set; }
    public string? MimeType { get; set; }
    public int? Duration { get; set; }
    public Guid? ReplyToMessageId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public bool IsDeleted { get; set; }

    public virtual Chat Chat { get; set; }
    public virtual User Sender { get; set; }
    public virtual Message? ReplyToMessage { get; set; }
    public virtual ICollection<MessageStatus> MessageStatuses { get; set; } =
        new List<MessageStatus>();
}

public enum MessageType
{
    Text = 1,
    Image = 2,
    Video = 3,
    Audio = 4,
    Document = 5,
    Voice = 6,
}
