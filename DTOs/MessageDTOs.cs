using Chat.Api.Models;

namespace Chat.Api.DTOs;

public class MessageDto
{
    public Guid Id { get; set; }
    public Guid ChatId { get; set; }
    public string SenderId { get; set; }
    public UserDto Sender { get; set; }
    public string? Content { get; set; }
    public MessageType Type { get; set; }
    public string? FileUrl { get; set; }
    public string? FileName { get; set; }
    public long? FileSize { get; set; }
    public string? MimeType { get; set; }
    public int? Duration { get; set; }
    public Guid? ReplyToMessageId { get; set; }
    public MessageDto? ReplyToMessage { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public List<MessageStatusDto> MessageStatuses { get; set; } = new List<MessageStatusDto>();
}

public class CreateMessageDto
{
    public Guid ChatId { get; set; }
    public string? Content { get; set; }
    public MessageType Type { get; set; } = MessageType.Text;
    public Guid? ReplyMessageId { get; set; }
    public IFormFile? File { get; set; }
}

public class MessageStatusDto
{
    public Guid Id { get; set; }
    public Guid MessageId { get; set; }
    public string UserId { get; set; }
    public UserDto User { get; set; }
    public MessageStatusType Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public class UpdateMessageStatusDto
{
    public Guid MessageId { get; set; }
    public MessageStatusType Status { get; set; }
}

public class MessageQueryDto
{
    public Guid ChatId { get; set; }
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 50;
    public DateTime? Before { get; set; }
    public DateTime? After { get; set; }
}
