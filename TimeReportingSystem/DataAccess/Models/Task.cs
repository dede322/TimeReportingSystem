using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        TaskState State { get; set; }

        public override bool Equals(object obj)
        {
            Task task = obj as Task;
            if (task != null)
                return this.Id.Equals(task.Id);

            return false;
        }
    }
}
