using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players_Team_Project
{
    public interface ITeam
    {
        void Add(Player player);
        void Remove(int playerId);
        Player GetPlayerById(int playerId);
        List<Player> GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();
    }
}
