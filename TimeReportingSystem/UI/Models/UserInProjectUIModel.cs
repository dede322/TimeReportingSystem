using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class UserInProjectUIModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; }
        public UserLevelUIModel userLevel { get; set; }

        public override bool Equals(object obj)
        {
            UserInProjectUIModel userInProject = obj as UserInProjectUIModel;
            if (userInProject != null)
                return this.Id.Equals(userInProject.Id);

            return false;
        }
    }
}