using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JokeApp.Models;
using JokeApp.Services;

namespace JokeApp.Controllers
{
    public class HomeController : Controller
    {
        private IJokeService jokeService;

        public HomeController()
        {
            this.jokeService = new JokeService();
        }

        public IActionResult Index()
        {
            ViewData["Joke"] = jokeService.GetJoke();
            return View();
        }

    }
}
