﻿using System.ComponentModel.DataAnnotations;

namespace issue_tracker.Models.DTO.CommentProject
    {
    public class BaseCommentProjectDTO
        {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        }
    }