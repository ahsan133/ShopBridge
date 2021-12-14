using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression("^([a-zA-Z]{2,}\\s([a-zA-Z]{1,})?)", ErrorMessage = "Enter valid full name")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
