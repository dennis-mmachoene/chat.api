using System.ComponentModel.DataAnnotations;

namespace Chat.Api.Models;

public class Chat
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [MaxLength(200)]
    public string Name { get; set; }
    public string? Description { get; set; }
    public ChatType Type { get; set; }
    public string? GroupImageUrl { get; set; }
    public string CreatedById { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public virtual User CreatedBy { get; set; }
    public virtual ICollection<ChatMember> Members { get; set; } = new List<ChatMember>();
    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
}

public enum ChatType
{
    Direct = 1,
    Group = 2,
}
