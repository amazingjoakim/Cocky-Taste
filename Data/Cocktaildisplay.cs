using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mellandagar
{
    public class Cocktaildisplay
    {
        [Required]
        [StringLength(50, ErrorMessage = "Too long Recipe Name")]
        public string Title { get; set; }
        [Required]
        [StringLength(400, ErrorMessage = "Max 400 letters")]
        public string Instructions { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Ingredients is required")]
        public List<string> Ingredients { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Measurements is required")]
        public List<string> Measurements { get; set; }
        [Required]
        public string Creator { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage ="glass type can't be longer than 30 characters")]
        public string glass { get; set; }

        public Cocktaildisplay()
        {
            Ingredients = new();
            Measurements = new();
        }


    }
}
