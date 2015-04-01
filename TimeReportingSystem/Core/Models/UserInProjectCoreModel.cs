using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class UserInProjectCoreModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; }
        public UserLevelCoreModel userLevel { get; set; }

        public override bool Equals(object obj)
        {
            UserInProjectCoreModel userInProject = obj as UserInProjectCoreModel;
            if (userInProject != null)
                return this.Id.Equals(userInProject.Id);

            return false;
        }
    }
}
