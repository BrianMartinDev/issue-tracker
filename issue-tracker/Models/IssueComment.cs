using issue_tracker.Models;

public class IssueComment
    {
    public int Id { get; set; }
    public int IssueId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    //-- Navigation Properties
    public Issue? Issue { get; set; }
    }