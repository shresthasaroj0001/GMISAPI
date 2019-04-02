using Abp.Domain.Entities.Auditing;
using GMIS.Entity.ProjectInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GMIS.Entity
{
    [Table("DOI_Project")]
    public class Project : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }

        //[ForeignKey("ProgramType")]
        //public int ProgramTypeId { get; set; }
        //public virtual ProgramType ProgramType { get; set; }

        public ICollection<UserProject> UserProjects { get; set; }
    }
}
