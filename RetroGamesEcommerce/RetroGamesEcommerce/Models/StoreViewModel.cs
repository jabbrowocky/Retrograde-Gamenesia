using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetroGamesEcommerce.Models
{
    public class StoreViewModel
    {
        ICollection <Game> Games { get; set; }
        ICollection <Console> Consoles { get; set; }
        
    }
}