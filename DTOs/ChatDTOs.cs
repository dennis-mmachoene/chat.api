using Chat.Api.Models;

namespace Chat.Api.DTOs;

public class ChatDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public ChatType Type { get; set; }
    public string? GroupImageUrl { get; set; }
    public string CreatedById { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public List<ChatMemberDto> Members { get; set; } = new List<ChatMemberDto>();
    public MessageDto? LastMessage { get; set; }
    public int UnreadCount { get; set; }
}

public class CreateChatDto
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public ChatType Type { get; set; }
    public List<string> MemberIds { get; set; } = new List<string>();
}

public class ChatMemberDto
{
    public Guid ID { get; set; }
    public string UserId { get; set; }
    public UserDto User { get; set; }
    public ChatMemberRole Role { get; set; }
    public DateTime JoinedAt { get; set; }
    public bool IsActive { get; set; }
}

public class AddMemberDto
{
    public string UserId { get; set; }
    public ChatMemberRole Role { get; set; } = ChatMemberRole.Member;
}