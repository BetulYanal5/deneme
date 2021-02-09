using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new CSGamerManager(new MernisServiceAdapter());
            Console.WriteLine("Kayıt olmalısınız.");
            Console.WriteLine("Lütfen TC kimliğinizi, Adınızı, Soyadınızı ve Doğum Yılınızı alt alta girin");
            Gamer gamer = new Gamer()
            {
                NationalityId = Console.ReadLine().ToString(),
                FirstName = Console.ReadLine().ToString().ToUpper(),
                LastName= Console.ReadLine().ToString().ToUpper(), 
                YearOfBirth= Convert.ToInt32(Console.ReadLine())
            };
            gamerManager.Save(gamer);
            Game game = new Game()
            {
                GameName = "FİFA 21",
                GamePrice = 499.99

            };

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(gamer,game);
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Save(game);

            Console.ReadLine();
            
            
        }
    }
}
