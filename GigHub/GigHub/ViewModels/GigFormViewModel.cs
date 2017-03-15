using GigHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {

        // Properties we need
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        // We need a numeric value for each option in dropdown list hence int
        [Required]
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; } // list or collection can be used here but we wont anything using index

        public DateTime GetDateTime() {
            return DateTime.Parse(string.Format("{0}, {1}", Date, Time)); 
        }

    }
}