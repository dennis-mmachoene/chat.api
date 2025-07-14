namespace Chat.Api.Models;

public class ChatMember
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ChatId { get; set; }
    public string UserId { get; set; }
    public ChatMemberRole Role { get; set; } = ChatMemberRole.Member;
    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LeftAt { get; set; }
    public bool IsActive { get; set; } = true;

    public virtual Chat Chat { get; set; }
    public virtual User User { get; set; }
}

public enum ChatMemberRole
{
    Member = 1,
    Admin = 2,
    Owner = 3,
}
