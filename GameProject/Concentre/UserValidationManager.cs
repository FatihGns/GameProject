using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concentre
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.Id == 1 && user.BirthYear == 2006 && user.FirstName == "FATİH" && user.LastName == "GÜNEŞ" && user.IdentityNumber == 1543)
            {

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}