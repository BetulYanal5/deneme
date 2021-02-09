using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
   public class CSGamerManager : BaseGamerManager
    {
        private IUserValidationService _userValidationService;
        public CSGamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

       public override void Save(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
                
        }
    }
}
