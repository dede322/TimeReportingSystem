﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class UserInProject
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; }
        public UserLevel userLevel { get; set; }

        public override bool Equals(object obj)
        {
            UserInProject userInProject = obj as UserInProject;
            if (userInProject != null)
                return this.Id.Equals(userInProject.Id);

            return false;
        }
    }
}
