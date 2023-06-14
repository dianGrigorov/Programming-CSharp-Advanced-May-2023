using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            Players = new List<Player>();
        }

        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }
        public List<Player> Players { get; set; }
        public int Count { get { return Players.Count; } }

        public string AddPlayer(Player player)
        {
            if (String.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            else if (OpenPositions <= 0)
            {
                return "There are no more open positions.";
            }
            else if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }
            else
            {
                Players.Add(player);
                OpenPositions--;
                return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
            }

        }
        public bool RemovePlayer(string name)
        {
            Player player = Players.FirstOrDefault(pl => pl.Name == name);
            if (player != null)
            {
                OpenPositions++;
                return true;
            }
            return false;
        }
        public int RemovePlayerByPosition(string position)
        {
            int count = 0;
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].Position == position)
                {
                    Players.Remove(Players[i]);
                    count++;
                    OpenPositions++;
                    i = -1;
                }
            }


            return count;
        }
        public Player RetirePlayer(string name)
        {
            Player player = Players.FirstOrDefault(p => p.Name == name);
            if (player != null)
            {
                player.Retired = true;
            }
            return player;
        }

        public List<Player> AwardPlayers(int game)
        {
            List<Player> awardedPlayers = Players.Where(p => p.Games == game).ToList();
            return awardedPlayers;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");

            foreach (var player in Players.Where(p => p.Retired == false))
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
