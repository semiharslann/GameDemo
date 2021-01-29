using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class CampaignManager : ICampaignService
    {
        public void BuyWithCampaign(Game gameV, Campaign campaignV, Gamer gamerV)
        {
            Console.WriteLine(gamerV.GamerFirstName + " " + gamerV.GamerLastName + " bought " + gameV.GameName + " with " + campaignV.CampaignDiscountAmount + "% discount using " + campaignV.CampaignName);
        }
    }
}
