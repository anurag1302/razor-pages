namespace Blog.Web.Models.ViewModels;

public class AddBlogViewModel
{
    public string Title { get; set; }
    public string Contents { get; set; }
    public string ImageUrl { get; set; }
    public DateTime PublishedDate { get; set; }
    public bool IsActive { get; set; }
}