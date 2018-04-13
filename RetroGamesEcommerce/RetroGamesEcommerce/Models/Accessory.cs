using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetroGamesEcommerce.Models
{
    public class Accessory
    {
        public int AccessoryId { get;set;}
        public string AccessoryType { get; set;}
        public Console AccessoryConsole { get; set; }
        public Brand AccessoryBrand { get; set; }
    }
}