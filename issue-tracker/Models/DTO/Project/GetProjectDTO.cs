﻿using Microsoft.Build.Framework;

namespace issue_tracker.Models.DTO.Project
    {
    public class GetProjectDTO
        {
        [Required]
        public int Id { get; set; }
        }
    }