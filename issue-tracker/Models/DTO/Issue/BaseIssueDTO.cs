﻿namespace issue_tracker.Models.DTO.Issue
    {
    public class BaseIssueDTO
        {
        public int ProjectId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        }
    }