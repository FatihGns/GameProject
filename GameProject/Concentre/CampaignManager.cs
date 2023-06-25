using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;


namespace GameProject.Concentre
{
    public class CampingManager : ICampaignService
    {

        void ICampaignService.Add(Campaign campaign)
        {
            Console.WriteLine("Kampaya Eklendi");
        }

        void ICampaignService.Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }

        void ICampaignService.Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }
    }
}
