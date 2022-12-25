using ServiceLayer.Helpers.Contants;
using ServiceLayer.Helpers.Enums;
using ServiceLayer.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{

    public class Account : IAccount
    {


        public void Login(string email, string password)
        {

            int roleId = 1;
            if (email != "test@code.edu.az")
            {
                Console.WriteLine(Errors.NotFound);

            }
            else if (password != "test12345")
            {
                Console.WriteLine(Errors.NotFound);

            }
            if (roleId == (int)Roles.SuperAdmin)

            {
                Console.WriteLine("Giris ugurludur");
            }
            else
            {
                Console.WriteLine("Xos geldin user");
            }


        }
    }










}
