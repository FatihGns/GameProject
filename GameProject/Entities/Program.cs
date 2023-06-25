using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Concentre;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            UserManager userManager = new UserManager(new NewEStateUserValidationManager());
            User user = new User();

            userManager.Add(user);
            {
                user.Id = 1;
                user.BirthYear = 2006;
                user.FirstName = "FATİH";
                user.LastName = "GÜNEŞ";
                user.IdentityNumber = 1453;
            }




            Campaign camp = new Campaign();
            camp.CampaignName = "Yarı fiyat indirimi";
            camp.DiscountRate = 50;

            Sales sales = new Sales();
            sales.GameName = "Spider-Man Remasted";
            sales.Price = 334;


            SaleManager saleManager = new SaleManager(new SaleValidationManager());
            saleManager.Sale(user, camp, sales);
            Console.ReadLine();


        }
    }
}
