using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21_Lab25_MovieRegistration.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [StringLength(50, ErrorMessage = "WOW, that's a really long title. Please only enter up to 50 characters")]
        public string Genre { get; set; }
        public DateTime Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
    }
}
