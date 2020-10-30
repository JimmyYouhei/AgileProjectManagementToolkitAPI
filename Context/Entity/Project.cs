using AgileProjectManagement.AbstractClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProjectManagement.Context.Entity
{
    [Table("project")]
    public class Project : EntityBase
    {

        [Column("project_name")]
        public string ProjectName { get; set; }

        [Column("project_description")]
        public string ProjectDescription { get; set; }

        [Column("project_version")]
        public string ProjectVersion { get; set; }

    }
}