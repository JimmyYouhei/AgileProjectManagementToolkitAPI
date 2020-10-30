using AgileProjectManagement.Context;
using AgileProjectManagement.Context.Entity;
using AgileProjectManagement.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProjectManagement.Repository
{
    public class ProjectRepository : BaseRepository<Project> , IProjectRepository
    {
        public ProjectRepository(ProjectDbContext context) : base(context)
        {
        }

        public string ExtendTest()
        {
            return "1.ok";
        }
    }
}
