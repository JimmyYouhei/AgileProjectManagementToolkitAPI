using AgileProjectManagement.Context.Entity;
using AgileProjectManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProjectManagement.Dto
{
    public class ProjectDto
    {
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }

        public string ProjectVersion { get; set; }
    }
}
