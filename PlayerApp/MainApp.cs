using SmallEmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallEmployeeApp.Models;
using SmallEmployeeApp.Services;
using System.Reflection.Emit;
using SmallEmployeeApp.Functionallity;

namespace SmallEmployeeApp.UI
{
     class MainApp
    {
        public static void Main(string[] args)
        {
            
            IPlayersOperation ES = new PlayersOperation();
            

            int num;

            char reply;
        Label:
            
            do {

                Console.WriteLine("press 1 for add data:");
                Console.WriteLine("press 2 for remove data:");
                Console.WriteLine("press 3 for update data:");
                Console.WriteLine("press 4 for search data:");
                Console.WriteLine("press 5 to get Players list:");
                Console.WriteLine("press 0 to exit:");
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0 && num <= 5)
                {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("please Enter the details of a player:");
                            var Emp = new PlayerDetails();
                        
                            Console.WriteLine("enter player Id");
                            Emp.PlayerId = Convert.ToInt32( Console.ReadLine());
                           
                            Console.WriteLine("enter player name");
                            Emp.PlayerName = Console.ReadLine();

                            Console.WriteLine("enter player Age");
                            Emp.PlayerAge = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("enter player`s Country");
                            Emp.Country = Console.ReadLine();


                            ES.CreatePlayer(Emp);
                            break;


                        case 2:
                            Console.WriteLine("please enter the player id of which player you want to remove:");
                            int playerId = Convert.ToInt32(Console.ReadLine());
                            ES.RemovePlayer(playerId);

                            break;
                        case 3:
                            Console.WriteLine("please enter the player id of which player you want to update:");
                            playerId = Convert.ToInt32(Console.ReadLine());
                            ES.RemovePlayer(playerId);

                            break;

                        case 4:

                            Console.WriteLine("please enter the employee id of which employee you want to search:");
                            playerId = Convert.ToInt32(Console.ReadLine());
                            ES.SearchPlayer(playerId);


                            break;
                        case 5:
                            List<PlayerDetails> objl = ES.GetPlayersList();

                            if(objl.Count > 0)
                            {
                                Console.WriteLine("------------data in your list---------");
                                Console.WriteLine("Employee name   Employee id   Employee age");
                                foreach (var item in objl)
                                {
                                    Console.WriteLine($"{item.PlayerId}                {item.PlayerName}             {item.PlayerAge}            {item.Country}");
                                }

                            }
                            else
                            {
                                Console.WriteLine("as of now your data list is empty");
                            }



                            break;


                        case 0:
                            Console.WriteLine("thank you");
                            break;


                    }
                }
                else
                {
                    Console.WriteLine("please enter valid number:");
                    goto Label;
                }

                Console.WriteLine("if you want to repeat the operations then press y");
                 reply= Convert.ToChar( Console.ReadLine());
               
            } while (reply=='y'|| reply=='Y');



        }
    }
}
