namespace Blog.Web.Models.Domain;

public class Blog
{
    public int Id { get; set; }
    public Guid Guid { get; set; }
    public string Title { get; set; }
    public string Contents { get; set; }
    public string ImageUrl { get; set; }
    public DateTime PublishedDate { get; set; }
    public bool IsActive { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}