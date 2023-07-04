using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace GameAndGamer.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Player Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "In Game Name")]
        public string InGameName { get; set; }
        [Required]
        [Range(8, 100)]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        public string Description { get; set; }
        public string UID { get; set; }

        public virtual List<Game> GamesList { get; set; }

        public Player()
        {
            GamesList = new List<Game>();
        }
    }
}