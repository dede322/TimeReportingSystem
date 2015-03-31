using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class UserCoreModel
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Locale { get; set; }
        public string TimeZone { get; set; }

        public override bool Equals(object obj)
        {
            UserCoreModel user = obj as UserCoreModel;
            if (user != null)
                return this.Id.Equals(user.Id);

            return false;
        }
    }
}
