using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService { 
        public void Save(Game game)
        {
            game.GamePrice = game.GamePrice-((game.GamePrice * 20)/100);
            Console.WriteLine("İndirimli fiyatı= "+ game.GamePrice);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.DiscountName+" deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.DiscountName +" updated");
        }
    }
}
