using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public override bool Equals(object obj)
        {
            Project project = obj as Project;
            if (project != null)
                return this.Id.Equals(project.Id);

            return false;
        }
    }
}
