using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class TaskReport
    {
        public Guid Id { get; set; }
        public DateTime DateOfReport { get; set; }
        public DateTime Effort { get; set; }
        public string Description { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public Guid IdTask { get; set; }
        public Guid IdUser { get; set; }

        public override bool Equals(object obj)
        {
            TaskReport taskReport = obj as TaskReport;
            if (taskReport != null)
                return this.Id.Equals(taskReport.Id);

            return false;
        }
    }
}
