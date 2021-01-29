using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class GamerManager:IGamerService
    {
        IGamerValidationService _gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("User login succesful");
            }
            else
            {
                Console.WriteLine("User login failed");
            }
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("User account deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("User account updated");
        }
    }
}
