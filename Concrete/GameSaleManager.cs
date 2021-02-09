using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameSaleManager : IGameSaleService
    {  
        public void Sale(Gamer gamer,Game game)
        {
            Console.WriteLine(game.GameName+" adlı oyun "+gamer.FirstName+" adlı kişiye satıldı.");
            Console.WriteLine("İndirimsiz fiyat=" + game.GamePrice);  
        }
    }
}
