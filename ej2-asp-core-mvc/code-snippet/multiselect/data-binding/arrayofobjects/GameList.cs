using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class GameList
    {
        public string Id { get; set; }
        public string Game { get; set; }

        public List<GameList> GameLists()
        {
            List<GameList> game = new List<GameList>();
            game.Add(new GameList { Id = "Game1", Game = "American Football" });
            game.Add(new GameList { Id = "Game2", Game = "Badminton" });
            game.Add(new GameList { Id = "Game3", Game = "Basketball" });
            game.Add(new GameList { Id = "Game3", Game = "Basketball" });
            game.Add(new GameList { Id = "Game4", Game = "Cricket" });
            game.Add(new GameList { Id = "Game5", Game = "Football" });
            game.Add(new GameList { Id = "Game6", Game = "Golf" });
            game.Add(new GameList { Id = "Game7", Game = "Hockey" });
            game.Add(new GameList { Id = "Game8", Game = "Rugby" });
            game.Add(new GameList { Id = "Game9", Game = "Snooker" });
            game.Add(new GameList { Id = "Game10", Game = "Tennis" });
            return game;
        }
    }
}