using SmallEmployeeApp.Models;
using System;
using System.Collections.Generic;
using SmallEmployeeApp.Models;
using SmallEmployeeApp.Functionallity;
using System.Linq;

namespace SmallEmployeeApp.Services 
{
     class PlayersOperation :IPlayersOperation
    {
        PlayerDetails Pl= new PlayerDetails();
        List<PlayerDetails> objlist = new List<PlayerDetails>();
        public void CreatePlayer(PlayerDetails emp)
        {
            objlist.Add(emp);
           
        }

        public void RemovePlayer(int id)
        {
            //for (int i = 0; i < objlist.Count; i++)
            //{
            //    if (id == objlist[i].EId)
            //    {
            //        objlist.RemoveAt(i);

            //    }

            //}

            PlayerDetails RemoveEmolpyee =  objlist.First(emp=> emp.PlayerId==id);

            objlist.Remove(RemoveEmolpyee); 




        }

        public void SearchPlayer(int id)
        {
            //    int i;
            //    for ( i = 0; i < objlist.Count; i++)
            //    {
            //        if (id == objlist[i].EId)
            //        {
            //            Console.WriteLine($" id--{objlist[i].EId}");
            //            Console.WriteLine($"name---{objlist[i].EName}");
            //            Console.WriteLine($"age----{objlist[i].EAge}");
            //            break;
            //        }

            //    }

            //    if(i==objlist.Count)
            //    {
            //        Console.WriteLine($" employee with id --{id} is not in your data");
            //    }

            int SearchedPlayersCount = objlist.Count(emp => emp.PlayerId == id);

            if(SearchedPlayersCount>0) 
            {
                PlayerDetails SearchedPlayer = objlist.First(emp => emp.PlayerId == id);
                Console.WriteLine($"{SearchedPlayer.PlayerId}  {SearchedPlayer.PlayerName}   {SearchedPlayer.PlayerAge}     {SearchedPlayer.Country} ");
            }
            else
            {
                Console.WriteLine("not found");
            }
           
           
            Console.WriteLine();




        }
            public void UpdatePlayer(int id)
        {
            //Employee employee = new Employee();

            //for (int i = 0; i < objlist.Count; i++)
            //{
            //    if (id == objlist[i].EId)
            //    {
            //        objlist.RemoveAt(i);

            //        Console.WriteLine("enter new name");
            //        employee.EName=Console.ReadLine();

            //        Console.WriteLine("enter new id");
            //        employee.EId = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("enter new age");
            //        employee.EAge =Convert.ToInt32( Console.ReadLine());

            //        objlist.Add(employee);

            //    }

            //}







        }

        public List<PlayerDetails> GetPlayersList()
        {
           
                return objlist;
           
        }
    }
}
 