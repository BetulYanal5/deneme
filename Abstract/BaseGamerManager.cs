using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" adlı kullanıcı silindi.");
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı kullanıcı eklendi.");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı kullanıcı bilgileri güncellendi.");
        }
    }
}
