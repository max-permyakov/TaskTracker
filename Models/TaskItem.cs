using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskTracker.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }


        [MaxLength(1000)]
        public string? Description { get; set; }

        public bool IsCompleted { get; set; }

        [Display(Name="Created")]
        public DateTime CreatedAt { get; set; }= DateTime.Now;
    }
}
