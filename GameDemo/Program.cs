using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() { GamerId = 1, GamerFirstName = "Semih", GamerLastName = "Arslan", GamerNationalityId = "11111111111", GamerDateOfBirth = "1900.5.5" };

            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Add(gamer1);

            Game game1 = new Game() { GameName = "Grand Theft Auto V", GamePrice = 500 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            GameOwnerManager gameOwnerManager = new GameOwnerManager();
            gameOwnerManager.OwnGame(game1, gamer1);

            Campaign campaign1 = new Campaign { CampaignName = "Student Campaign", CampaignDiscountAmount = 50 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.BuyWithCampaign(game1, campaign1, gamer1);

        }
    }
}
