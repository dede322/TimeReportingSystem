using AutoMapper;
using Core.Models;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class MapperCore
    {
        public MapperCore()
        {
            Mapper.CreateMap<UserCoreModel, User>();
            Mapper.CreateMap<User, UserCoreModel>();

            Mapper.CreateMap<ProjectCoreModel, Project>();
            Mapper.CreateMap<Project, ProjectCoreModel>();

            Mapper.CreateMap<TaskCoreModel, DataAccess.Models.Task>();
            Mapper.CreateMap<DataAccess.Models.Task, TaskCoreModel>();

            Mapper.CreateMap<TaskReportCoreModel, TaskReport>();
            Mapper.CreateMap<TaskReport, TaskReportCoreModel>();

            Mapper.CreateMap<TaskStateCoreModel, TaskState>();
            Mapper.CreateMap<TaskState, TaskStateCoreModel>();
        }
    }
}
