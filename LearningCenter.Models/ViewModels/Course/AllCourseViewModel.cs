﻿namespace LearningCenter.Models.ViewModels.Course
{
    using System.ComponentModel.DataAnnotations;

    public class AllCourseViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
        
        [Display(Name = "Students in course")]
        public int StudentsInCourse { get; set; }
    }
    

   
}
