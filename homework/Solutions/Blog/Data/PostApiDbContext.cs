namespace Blog.Data;

public class PostApiDbContext : PostApiDbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Media> Medias { get; set; }
    public DbSet<Comment> Comments { get; set; }
}