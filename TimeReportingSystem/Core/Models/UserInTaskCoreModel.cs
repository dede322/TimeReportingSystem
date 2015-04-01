using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class UserInTaskCoreModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid TaskId { get; set; }

        public override bool Equals(object obj)
        {
            UserInTaskCoreModel userInTask = obj as UserInTaskCoreModel;
            if (userInTask != null)
                return this.Id.Equals(userInTask.Id);

            return false;
        }
    }
}
