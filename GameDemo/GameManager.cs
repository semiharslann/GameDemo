using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game added");
        }
        public void Delete(Game game)
        {
            Console.WriteLine("Game deleted");
        }
        public void Update(Game game)
        {
            Console.WriteLine("Game updated");
        }
    }
}
