using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    class User
    {
        Guid Id { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime RegistrationDate { get; set; }
        string Locale { get; set; }
        string TimeZone { get; set; }
    }
}
