using issue_tracker.Models;

public class ProjectComment
    {
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    //-- Navigation Properties
    public Project? Project { get; set; }
    }