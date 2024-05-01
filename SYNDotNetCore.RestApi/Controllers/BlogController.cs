using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SYNDotNetCore.RestApi.Database;
using SYNDotNetCore.RestApi.Models;

namespace SYNDotNetCore.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly AppDbContext _context;
        public BlogController()
        {

            _context = new AppDbContext();
        }

        [HttpGet]
        public IActionResult Read()
        {
            var lst = _context.Blogs.ToList();
            return Ok(lst);
        }
        [HttpGet("{id}")]
        public IActionResult Edit(int id)
        {
            var item = _context.Blogs.FirstOrDefault(x => x.BlogId == id);
            if (item is null)
            {
                return NotFound("No Data Found");
            }
            return Ok(item);
        }
        [HttpPost]
        public IActionResult Create(BlogModel blog)
        {
            _context.Blogs.Add(blog);
            var result = _context.SaveChanges();

            string message = result > 0 ? "Saving Successful" : "Saving Fail";
            return Ok(message);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, BlogModel blog)
        {
            var item = _context.Blogs.FirstOrDefault(X => X.BlogId == id);

            if (item is null)
            {
                return NotFound("NO Data Found");

            }
            item.BlogTitle = blog.BlogTitle;
            item.BlogContent = blog.BlogContent;

            item.BlogAuthor = blog.BlogAuthor;
            int result = _context.SaveChanges();
            string message = result > 0 ? "Update Successful" : "Update Fail";
            return Ok(message);
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, BlogModel blog)
        {
            var item = _context.Blogs.FirstOrDefault(X => X.BlogId == id);

            if (item is null)
            {
                return NotFound("NO Data Found");

            }
            if (!string.IsNullOrEmpty(blog.BlogTitle))
            {
                item.BlogTitle = blog.BlogTitle;
            }
            if (!string.IsNullOrEmpty(blog.BlogAuthor))
            {
                item.BlogAuthor = blog.BlogAuthor;
            }
            if (!string.IsNullOrEmpty(blog.BlogTitle))
            {
                item.BlogContent = blog.BlogContent;
            }

            int result = _context.SaveChanges();
            string message = result > 0 ? "Patch Successful" : "Update Fail";
            return Ok(message);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete( int id)
        {
        var item = _context.Blogs.FirstOrDefault(X => X.BlogId == id);

        if (item is null)
        {
            return NotFound("NO Data Found");

        }
            _context.Blogs.Remove(item);
            int result = _context.SaveChanges();
            string message = result > 0 ? "Delete Successful" : "Delete Fail";
            return Ok(message);
        }
    }
}
