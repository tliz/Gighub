using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }

        // foreign key
        [Required]
        public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public byte GenreId { get; set; }

        // Navigation properties
        public ApplicationUser Artist { get; set; }
        public Genre Genre { get; set; }

    }

}