﻿using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.CommentIssue
    {
    public class GetCommentIssueDTO : BaseCommentIssueDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }