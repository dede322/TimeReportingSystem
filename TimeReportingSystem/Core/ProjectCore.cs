using AutoMapper;
using Core.Models;
using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ProjectCore
    {
        JsonRepository<Project> repository;

        public ProjectCore()
        {
            repository = new JsonRepository<Project>(Environment.CurrentDirectory + @"/Repositories/Projects.json");
            MapperCoreConfiguration.Configure();
        }

        public IEnumerable<ProjectCoreModel> GetAll()
        {
            IEnumerable<ProjectCoreModel> projects = 
                Mapper.Map< IEnumerable<Project>, IEnumerable<ProjectCoreModel>>(repository.GetAll());
            return projects;
        }
    }
}
