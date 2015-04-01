using Core.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ProjectCore
    {
        JsonRepository<ProjectCoreModel> repository = new JsonRepository<ProjectCoreModel>("Projects.json");

        public IEnumerable<ProjectCoreModel> GetAll()
        {
            return repository.GetAll();
        }
    }
}
