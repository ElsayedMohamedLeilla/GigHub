using GigHub.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {



        public string Time { get; set; }
        public string Date { get; set; }

        public int Genre { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }



        public IEnumerable<Genre> Genres { get; set; }
    }
}