using System;
using System.ComponentModel.DataAnnotations;

namespace Calorie.Models
{
    public class CalorieEntry
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Calories { get; set; }
    }
}
