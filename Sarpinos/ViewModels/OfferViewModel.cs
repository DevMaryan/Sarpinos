using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.ViewModels
{
    public class OfferViewModel
    {
        public string Title { get; set; }

        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime ValidTo { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
