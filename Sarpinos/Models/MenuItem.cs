using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Column(TypeName="decimal(5,2)")]
        public decimal Price { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }
    }
}
