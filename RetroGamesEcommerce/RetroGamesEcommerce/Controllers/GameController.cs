using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using RetroGamesEcommerce.Models;

namespace RetroGamesEcommerce.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }
    }
}