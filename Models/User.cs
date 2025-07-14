using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Chat.Api.Models;

public class User : IdentityUser
{
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public bool isOnline { get; set; }
    public DateTime LastSeen { get; set; } = DateTime.UtcNow;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public virtual ICollection<ChatMember> ChatMemberships { get; set; } = new List<ChatMember>();
    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
    public virtual ICollection<MessageStatus> MessageStatuses { get; set; } = new List<MessageStatus>();

}
