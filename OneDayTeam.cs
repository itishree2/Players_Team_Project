using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players_Team_Project
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> players;
        public OneDayTeam() 
        {
            players = new List<Player>();  
        }
        public void Add(Player player)
        {
            if (players.Count <=11)
            {
                players.Add(player);

                Console.WriteLine("Player is added successfully");
               
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players to the team.");
            }
        }
        public void Remove(int playerId)
        {
            Player playerToRemove = players.Find(p => p.Id == playerId);

            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);

                Console.WriteLine("Player is Removed successfully");
                
            }
            else
            {
                Console.WriteLine($"Player with Id {playerId} not found in the team.");
            }
        }
        
        public Player GetPlayerById(int playerId)
        {
            return players.FirstOrDefault(p => p.Id == playerId);
          
        }
        public List<Player>GetPlayerByName(string playerName) 
        {
            return
                players.Where(P => P.Name.Equals(playerName,StringComparison.OrdinalIgnoreCase )).ToList();
        }

        public List<Player> GetAllPlayers()
        {
            return players.ToList();
        }


    }

}
