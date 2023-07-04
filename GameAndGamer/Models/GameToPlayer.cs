    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameAndGamer.Models
{
    public class GameToPlayer
    {
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public Game game { get; set; }
        public Player player { get; set; }
        public List<Game> Games { get; set; }
        public List<Player> Players { get; set; }
        public GameToPlayer()
        {
            Games = new List<Game>();
            Players = new List<Player>();
        }
    }
}