using System.ComponentModel.DataAnnotations;

namespace Moment2.Models
{
    public class Bands
    {
        [Required(ErrorMessage = "The band name is required!")]
        [Display(Name = "Band name: *")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "A country is required!")]
        [Display(Name = "From country: *")]
        public string? Country { get; set; }

        [Required(ErrorMessage = "The metal genre is required!")]
        [Display(Name = "Genre of metal: *")]
        public string? Genre { get; set; }

        [Url]
        [Display(Name = "Official band page:")]
        public string? Url { get; set; }

        [Required(ErrorMessage = "A year is required! Use format (YYYY)")]
        [Display(Name = "Year formed: *")]
        public string? Year { get; set; }

        [MaxLength(1000)]
        [Display(Name = "Band information:")]
        public string? Description { get; set; }
    }
}
