﻿namespace LearningCenter.Models.BindingModels.Quiz
{
    using System.ComponentModel.DataAnnotations;

    public class EditQuizBindingModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "The {0} must be at least {2} characters long.")]
        public string Title { get; set; }
    }
}
