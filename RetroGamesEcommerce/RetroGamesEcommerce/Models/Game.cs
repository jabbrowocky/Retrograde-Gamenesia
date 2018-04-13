using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetroGamesEcommerce.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public Console ConsoleId { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}