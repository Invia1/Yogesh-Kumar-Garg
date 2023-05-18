using SmallEmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallEmployeeApp.Functionallity
{
    internal interface IPlayersOperation
    {
        void CreatePlayer(PlayerDetails emp);
        void RemovePlayer(int id);
        void SearchPlayer(int  id);

        void UpdatePlayer(int id);

        List<PlayerDetails> GetPlayersList();
    }
}
