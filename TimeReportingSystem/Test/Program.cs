using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonRepository<User> userJson = new JsonRepository<User>("Users.json"); 
            User user = new User() {
                Id = Guid.NewGuid(), 
                FirstName = "Fedr",
                LastName = "Kukin",
                Login = "Fedya",
                Password = "koni",
                Locale = "Ru",
                TimeZone = "01",
                RegistrationDate = new DateTime(1990, 3, 23)
            };

            //userJson.Add(user);

            //for(int i = userJson.Elements.Count - 1; i >= 0; i--)
            //{
            //    userJson.Delete(userJson.Elements[i]);
            //}

            //userJson.Delete(user);
        }
    }
}
