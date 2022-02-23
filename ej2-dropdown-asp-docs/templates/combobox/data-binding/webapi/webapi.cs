using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ComboBoxController : Controller
    {
        List<string> game = new List<string>();
        [HttpGet]
        public List<string> Get()
        {
            game.Add("Badminton");
            game.Add("Basketball");
            game.Add("Cricket");
            game.Add("Golf");
            game.Add("Gymnastics");
            game.Add("Tennis");
            game.Add("Hockey");
            return game;
        }
    }
}