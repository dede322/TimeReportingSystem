using AutoMapper;
using Core;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class ProjectController : Controller
    {
        ProjectCore core;

        public ProjectController()
        {
            core = new ProjectCore();
            MapperUIConfiguration.Configure();
        }

        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<ProjectCoreModel> pr = core.GetAll();
            IEnumerable<ProjectUIModel> projects =
                Mapper.Map<IEnumerable<ProjectCoreModel>, IEnumerable<ProjectUIModel>>(core.GetAll());
            return View(projects);
        }

    }
}
