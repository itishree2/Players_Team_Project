using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players_Team_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            string again;

            do
            {
                Console.WriteLine("Enter 1: To Add Player 2: To Remove Player by Id 3: Get Player By Id 4: Get Player by Name 5: Get All Players 0: Exit");

                // Read user choice
                 int choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Player Id:");
                        int playerId = int.Parse(Console.ReadLine());

                        Console.Write("Enter Player Name:");
                        string playerName = Console.ReadLine();

                        Console.Write("Enter Player Age:");
                        int playerAge = int.Parse(Console.ReadLine());

                        team.Add(new Player { Id = playerId, Name = playerName, Age = playerAge });
                        
                        break;

                    case 2:
                        Console.Write("Enter Player Id to Remove:");
                        int playerIdToRemove = int.Parse(Console.ReadLine());
                        team.Remove(playerIdToRemove);
                       
                        break;

                    case 3:
                        Console.Write("Enter Player Id to Get Details:");
                        int playerIdToGet = int.Parse(Console.ReadLine());
                        Player playerById = team.GetPlayerById(playerIdToGet);
                      
                        if (playerById != null)
                        {

                            Console.WriteLine($"Player Found: Id:{playerById.Id}, Name:{playerById.Name} , Age: {playerById.Age}");
                        }
                        else
                        {
                            Console.WriteLine("Player details not found");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Player Name to Get Details:");
                        string playerNameToGet = Console.ReadLine();
                        List<Player> playersByName = team.GetPlayerByName(playerNameToGet);
                        if (playersByName.Count > 0)
                        {
                            Console.WriteLine($"Players with name '{playerNameToGet}':");
                            foreach(Player player in playersByName)
                            {
                                Console.WriteLine($"Id:{player.Id}, Name:{player.Name} , Age: {player.Age}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No players found with name'{playerNameToGet}'.");
                        }
                        break;

                    case 5:
                        List<Player> allPlayersDetails = team.GetAllPlayers();
                        Console.WriteLine("All Players:");
                        foreach (Player player in allPlayersDetails)
                        {
                            Console.WriteLine($"Id:{player.Id}, Name:{player.Name}, Age:{player.Age}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Exiting the program.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("Invalid input. Please enter a valid option.");
                        break;
                }
                Console.Write("Do you want to Continue(yes/no)?:");
                again = Console.ReadLine();
            } while (again.Equals("yes"));
            Console.ReadLine();
        }
    }
}



