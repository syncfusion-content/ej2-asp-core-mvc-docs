using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SportsData
    {
        public string ID { get; set; }
        public string Game { get; set; }
        public List<SportsData> SportsList()
        {
            List<SportsData> sports = new List<SportsData>()
            {
                new SportsData { ID = "game1", Game = "Badminton" },
                new SportsData { ID = "game2", Game = "Football" },
                new SportsData { ID = "game3", Game = "Tennis" },
                new SportsData { ID = "game4", Game = "Hockey" },
                new SportsData { ID = "game5", Game = "Basketball" },
            };
            return sports;
        }
    }
}
