using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TaskCoreModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        TaskStateCoreModel State { get; set; }

        public override bool Equals(object obj)
        {
            TaskCoreModel task = obj as TaskCoreModel;
            if (task != null)
                return this.Id.Equals(task.Id);

            return false;
        }
    }
}
