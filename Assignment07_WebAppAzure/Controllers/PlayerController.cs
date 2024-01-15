using Microsoft.AspNetCore.Mvc;
using Assignment07_WebAppAzure.Models;
using System.Net.Http.Headers;

namespace Assignment07_WebAppAzure.Controllers
{
    public class PlayerController : Controller
    {
        static List<Models.Player> players = new List<Player>()
        { new Player() { PId=1,PName="Virat Kohli", PCountry="India", PType="Batsman"},
            new Player() { PId=2,PName="Jasprit Bumrah", PCountry="India", PType="Bowler"},
            new Player() { PId=3,PName="Sakibh Ai Hasan", PCountry="Bangladesh", PType="All-Rounder"},
            new Player() { PId=4,PName="Jos Buttler", PCountry="England", PType="Wicketkeeper/Batsman"},
            new Player() { PId=5,PName="Babar Azam", PCountry="Pakistan", PType="Batsman"},

        };
        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create (Player ply)
        {
            if (ModelState.IsValid)
            {
                players.Add(ply);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
