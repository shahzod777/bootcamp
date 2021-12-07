using System;
namespace Blog.Services;

public class MediaService : IMediaService
{
    private readonly PostApiDbContext _ctx;

    public MediaService(PostApiDbContext context)
    {
        _ctx = context;
    }

    public Task<(bool IsSuccess, Exception Exception)> DeleteMediaAsync(MediaService media)
    {
        try
        {
            _ctx.Medias.Remove(media);
            await _ctx.SaveChangesAsync();
            return (true, null);
        }
        catch(Exception e)
        {
            return (false, e);
        }
    }

    public Task<Media> GetMediaByAsync(Guid id)
        => _ctx.Medias.FirstOrDefaultAsync(m => m.Id == id);
    
    public async Task<(bool IsSuccess, Exception Exception)> InsertMediaAsync(MediaService media)
    {
        try
        {
            await _ctx.Medias.Remove(media);
            return (true, null);
        }
        catch(Exception e)
        {
            return (false, e);
        }
    }

    public Task<bool> MediaExistsAsync(Guid id)
        => _ctx.Medias.AnyAsync(m => m.Id == id);
}