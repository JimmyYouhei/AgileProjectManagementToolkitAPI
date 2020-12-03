using AgileProjectManagement.Context;
using AgileProjectManagement.Context.Entity;
using AgileProjectManagement.Dto;
using AgileProjectManagement.Interfaces;
using AgileProjectManagement.Interfaces.Service;
using AgileProjectManagement.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProjectManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {

        private IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }


        [HttpGet]
        public IEnumerable<Project> GetAll()
        {
            return projectService.GetAll();
        }

        [Route("{id}")]
        [HttpGet]
        public Project GetById(long id)
        {
            return projectService.UpdateVersion(id , "sd");
        }

        [HttpPost]
        public Project CreateNewProject(ProjectDto projectDto)
        {
            var projectToCreate = new Project()
            {
                ProjectDescription = projectDto.ProjectDescription,
                ProjectName = projectDto.ProjectName,
                ProjectVersion = projectDto.ProjectVersion
            };

            return projectService.CreateElement(projectToCreate);
        }

        [Route("{id}")]
        [HttpPut]
        public Project UpdateProject(ProjectDto projectDto , long id)
        {
            var projectToUpdate = new Project()
            {
                Id = id,
                ProjectDescription = projectDto.ProjectDescription,
                ProjectName = projectDto.ProjectName,
                ProjectVersion = projectDto.ProjectVersion
            };

            return projectService.UpdateElement(projectToUpdate);
        }

        [Route("{id}")]
        [HttpDelete]
        public void DeleteProject(long id)
        {
            projectService.DeleteElement(id);
        }
    }
}
