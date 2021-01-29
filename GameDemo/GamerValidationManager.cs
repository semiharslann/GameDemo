using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class GamerValidationManager:IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.GamerDateOfBirth == "1900.5.5" && gamer.GamerId == 1 && 
                gamer.GamerFirstName == "Semih" && gamer.GamerLastName == "Arslan" 
                && gamer.GamerNationalityId == "11111111111")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
