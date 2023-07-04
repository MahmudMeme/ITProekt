using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace GameAndGamer.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Game Name")]
        public string Name { get; set; }
        [Display(Name = "Imagee")]
        public string ImgUrl { get; set; }

        public int GenreId { get; set; } // Foreign key property

        // Navigation property (optional)
        //[ForeignKey("GanreId")]
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Rating:0-10")]
        [Range(0, 10, ErrorMessage = "Enter a number between 0 and 10. ")]
        public decimal Rating { get; set; }
        [Required]
        [Display(Name = "Developer/Publisher")]
        public string Developer { get; set; }
        public virtual List<Player> PlayersList { get; set; }
        public Game()
        {
            PlayersList = new List<Player>();
        }
    }
}