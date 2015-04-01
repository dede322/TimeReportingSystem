using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class UserUIModel
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Locale { get; set; }
        public string TimeZone { get; set; }
        public RoleUIModel role { get; set; }

        public override bool Equals(object obj)
        {
            UserUIModel user = obj as UserUIModel;
            if (user != null)
                return this.Id.Equals(user.Id);

            return false;
        }
    }
}