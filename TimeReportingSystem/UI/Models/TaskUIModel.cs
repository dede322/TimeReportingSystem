using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class TaskUIModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public TaskStateUIModel State { get; set; }
        public Guid IdProject { get; set; }


        public override bool Equals(object obj)
        {
            TaskUIModel task = obj as TaskUIModel;
            if (task != null)
                return this.Id.Equals(task.Id);

            return false;
        }
    }
}
