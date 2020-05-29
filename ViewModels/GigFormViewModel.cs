using GigHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {


        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        public int Genre { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }


        [Required]
        public IEnumerable<Genre> Genres { get; set; }
        public DateTime GetDateTime()
        {


            return DateTime.Parse(string.Format("{0} {1}", Date, Time));



        }
    }
}