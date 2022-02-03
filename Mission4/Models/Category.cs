using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage ="Please enter a Category")]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
