using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetroGamesEcommerce.Models
{
    public class Console
    {
        public int ConsoleId { get; set;}
        public string ConsoleName { get; set; }
        public Brand BrandId { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}