using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        //added this 4-19-17
        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }

       // public int Id { get; set; }

       // [Required(ErrorMessage = "Please enter movie name.")]
       // //[Required]
       // [StringLength(255)]
       // public string Name { get; set; }

       // //public Genre Genre { get; set; }

       // //[Display(Name = "Genre")]
       // [Required]
       // public byte GenreId { get; set; }

       // public DateTime DateAdded { get; set; }

       //// [Display(Name = "ReleaseDate")]
       // public DateTime ReleaseDate { get; set; }

       // //[Display(Name = "NumberInStock")]
       // [Range(1, 20)]
       // public byte NumberInStock { get; set; }
    }
}