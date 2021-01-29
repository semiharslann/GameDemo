using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface IGameOwnerService
    {
        void OwnGame(Game game, Gamer gamer);
    }
}
