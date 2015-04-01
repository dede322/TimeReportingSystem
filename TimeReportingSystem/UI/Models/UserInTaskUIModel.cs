using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class UserInTaskUIModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid TaskId { get; set; }

        public override bool Equals(object obj)
        {
            UserInTaskUIModel userInTask = obj as UserInTaskUIModel;
            if (userInTask != null)
                return this.Id.Equals(userInTask.Id);

            return false;
        }
    }
}
