
using Microsoft.AspNetCore.Mvc;

using api.Services;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class PostsController : ControllerBase
    {
        readonly BlogContext _context;

        public PostsController(BlogContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Post>> Get()
        {
            return _context.Posts;
        }

        // GET api/posts/5
        [HttpGet("{id}")]
        public ActionResult<Post> Get(int id)
        {
            return _context.Posts.FirstOrDefault(post => post.PostId == id);
        }

        // POST api/posts
        [HttpPost]
        public void Post([FromBody] Post value)
        {
            _context.Posts.Add(value);
            _context.SaveChanges();
        }

        // PUT api/posts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Post value)
        {
            var post = _context.Posts.FirstOrDefault(p => p.PostId == id);
            if (post == null)
                return;
            
            post.Title = value.Title;
            post.Summary = value.Summary;
            post.Body = value.Body;
            post.Author = value.Author;
            post.Tags = value.Tags;

            _context.Posts.Update(post);
            _context.SaveChanges();
        }

        // DELETE api/posts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var post = _context.Posts.FirstOrDefault(p => p.PostId == id);
            if (post == null)
                return;

            _context.Posts.Remove(post);
            _context.SaveChanges();
        }
    }
}