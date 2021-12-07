using System.ComponentModel.DataAnnotations.Schema;
namespace Blog.Entities;

public class Medias : EntityBase
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid Id { get; set; }
    public string AltText { get; set; }
    public byte[] Data { get; set; }
    public string ContentType { get; set; }

    [ForeignKey("Posts")]
    public Guid PostId { get; set; }

}
