using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class ProjectUIModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public override bool Equals(object obj)
        {
            ProjectUIModel project = obj as ProjectUIModel;
            if (project != null)
                return this.Id.Equals(project.Id);

            return false;
        }
    }
}