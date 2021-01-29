using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class GameOwnerManager : IGameOwnerService
    {
        public void OwnGame(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " " + gamer.GamerLastName + " buys " + game.GameName + " game for " + game.GamePrice + "$");
        }
    }
}
