using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
   public interface ICampaignService
    {
        void Save(Game game);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
