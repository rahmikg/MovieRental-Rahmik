
using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter movie name.")]
        //[Required]
        [StringLength(255)]
        public string Name { get; set; }
   
        public Genre Genre { get; set; }

        [Display (Name = "Genre")]
       // [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "ReleaseDate")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "NumberInStock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}