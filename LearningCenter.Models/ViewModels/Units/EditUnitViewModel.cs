﻿namespace LearningCenter.Models.ViewModels.Units
{
    using System.ComponentModel.DataAnnotations;

    public class EditUnitViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "The {0} must be between {2} and {1} characters long.")]
        public string Title { get; set; }

        [Required]
        public string ContentUrl { get; set; }
    }
}
