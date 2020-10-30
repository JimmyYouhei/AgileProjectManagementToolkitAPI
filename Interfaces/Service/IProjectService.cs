using AgileProjectManagement.Context.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProjectManagement.Interfaces.Service
{
    public interface IProjectService : IProjectService<Project>
    {
        Project UpdateVersion(long id , string version);
    }
}
