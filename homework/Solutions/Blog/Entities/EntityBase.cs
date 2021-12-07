using System.ComponentModel.DataAnnotations.Schema;
namespace Blog.Entities;

public class EntityBase
{
    [Key, DatabaseGenerated(DatabaseGenerated.None)]
    public Guid Id { get; set; } = Guid.NewGuid();
}