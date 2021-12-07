using System;
namespace Blog.Entities;

public class Comment : EntityBase
{
    [Required]
    [MaxLength(1024)]
    public string Content { get; set; }

    [Required]
    public DateTimeOffset CreatedAt { get; set; }
    
    [Required]
    public DateTimeOffset ModifiedAt { get; set; }

    [ForeignKey("Posts")]
    public Guid PostId { get; set; }
}