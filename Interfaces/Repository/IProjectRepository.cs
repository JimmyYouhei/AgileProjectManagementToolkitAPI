using AgileProjectManagement.Context.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProjectManagement.Interfaces.Repository
{
    public interface IProjectRepository : IRepository<Project>
    {
        public string ExtendTest();
    }
}
