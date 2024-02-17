namespace Blog.Web.Models.Domain;

public class Tag
{
    public int Id { get; set; }
    public Guid Guid { get; set; }
    public string TagName { get; set; }
    public int BlogId { get; set; }
    public Blog Blog { get; set; }
    public bool IsActive { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}