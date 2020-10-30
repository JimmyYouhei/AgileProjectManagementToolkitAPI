using AgileProjectManagement.AbstractClass;
using AgileProjectManagement.Context.Entity;
using AgileProjectManagement.Interfaces;
using AgileProjectManagement.Interfaces.Repository;
using AgileProjectManagement.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProjectManagement.Service
{
    public class ProjectService : BaseService<Project> , IProjectService
    {
        internal IProjectRepository projectRepository;
        public ProjectService(IRepository<Project> repository , IProjectRepository projectRepository) : base(repository)
        {
            this.projectRepository = projectRepository;
        }

        public Project UpdateVersion(long id , string version)
        {
            var project = repository.GetById(id);

            project.ProjectVersion = version;

            repository.SaveChanges();

            return project;
        }
    }
}
