using AutoMapper;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class MapperUI
    {
        public MapperUI()
        {
            Mapper.CreateMap<UserCoreModel, UserUIModel>();
            Mapper.CreateMap<UserUIModel, UserCoreModel>();

            Mapper.CreateMap<ProjectCoreModel, ProjectUIModel>();
            Mapper.CreateMap<ProjectUIModel, ProjectCoreModel>();

            Mapper.CreateMap<TaskCoreModel, TaskUIModel>();
            Mapper.CreateMap<TaskUIModel, TaskCoreModel>();

            Mapper.CreateMap<TaskReportCoreModel, TaskReportUIModel>();
            Mapper.CreateMap<TaskReportUIModel, TaskReportCoreModel>();

            Mapper.CreateMap<TaskStateCoreModel, TaskStateUIModel>();
            Mapper.CreateMap<TaskStateUIModel, TaskStateCoreModel>();
        }

    }
}