using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Blog.Entities;
public class Post : EntityBase
{
    [Required]
    [MaxLenght(255)]
    public string Title { get; set; }
    [Required]
    [MaxLenght(255)]
    public string Description { get; set; }
    public string Content { get; set; }
    public Guid? HeaderImageId { get; set; }

    [Required]
    public uint Viewed { get; set; } = 0;

    [Required]
    public DateTimeOffset CreatedAt { get; set; }
    
    [Required]
    public DateTimeOffset ModifiedAt { get; set; }
    public ICollection<Media> Medias { get; set; }
    public ICollection<Comment> Comments { get; set; }
}
