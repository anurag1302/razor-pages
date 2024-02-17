using Blog.Web.Data;
using Blog.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Web.Pages;

public class AddBlog : PageModel
{
    private readonly BlogDbContext _dbContext;
    public AddBlog(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [BindProperty]
    public AddBlogViewModel AddModel { get; set; }
    public IActionResult OnGet()
    {
        return Page();
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            var inputData = AddModel;
            var blogModel = new Models.Domain.Blog()
            {
                Guid = Guid.NewGuid(),
                Title = inputData.Title,
                Contents = inputData.Contents,
                ImageUrl = inputData.ImageUrl,
                PublishedDate = inputData.PublishedDate,
                IsActive = true,
                CreatedBy = "Admin",
                CreatedOn = DateTime.UtcNow,
                UpdatedBy = null,
                UpdatedOn = null
            };

            _dbContext.Blogs.Add(blogModel);
            _dbContext.SaveChanges();
            
            return RedirectToPage("/Index");
        }

        return Page();
    }
}