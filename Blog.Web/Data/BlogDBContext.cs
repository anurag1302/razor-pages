using DomainModels = Blog.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
namespace Blog.Web.Data;


public class BlogDbContext:DbContext
{
    public BlogDbContext(DbContextOptions<BlogDbContext> options):base(options)
    {
        
    }
    
    public DbSet<DomainModels.Blog> Blogs { get; set; }
    public DbSet<DomainModels.Tag> Tags { get; set; }
    
}