using GigHub.Models;
using System.Collections.Generic;


namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        // Properties we need
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        // We need a numeric value for each option in dropdown list hence int
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; } // list or collection can be used here but we wont anything using index
    }
}