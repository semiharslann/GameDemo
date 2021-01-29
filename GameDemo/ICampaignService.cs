using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface ICampaignService
    {
        void BuyWithCampaign(Game game, Campaign campaign, Gamer gamer);
    }
}
