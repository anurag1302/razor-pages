using Blog.Web.Data;
using Blog.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Web.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly BlogDbContext _dbContext;
    

    public List<BlogViewModel> Blogs { get; set; }

    public bool HasRecords
    {
        get
        {
            return Blogs.Count > 0;
        }
    }
    public IndexModel(ILogger<IndexModel> logger, BlogDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    public void OnGet()
    {
        var data = _dbContext.Blogs.ToList();
        Blogs = data.Select(x => new BlogViewModel
        {
            Guid = x.Guid,
            Contents = x.Contents,
            Title = x.Title,
            ImageUrl = x.ImageUrl,
            PublishedDate = x.PublishedDate,
            IsActive = x.IsActive
        }).ToList();
    }
}