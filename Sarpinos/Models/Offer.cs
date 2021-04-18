using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.Models
{
    public class Offer
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime ValidTo { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }
    }
}
