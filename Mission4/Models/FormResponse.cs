using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class FormResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage ="Please enter a Title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a Year.")]
        public string Year { get; set; }
        [Required(ErrorMessage = "Please enter a Director.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please enter a Rating.")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        // Foreign Key Relationship
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
