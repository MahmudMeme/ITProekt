using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace GameAndGamer.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Display(Name = "Ganre")]
        public string Name { get; set; }
        public string Description { get; set; }

    }
}