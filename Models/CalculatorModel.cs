using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission05_autdel.Models
{
    public class CalculatorModel
    {
        // Model for calculations - 6 different fields that are all required
        [Required]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public int assignments { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public int groupProjects { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public int quizzes { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public int midtermExam { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public int finalExam { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public int intex { get; set; }
    }
}
