using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GMIS.Entity.ProjectInformation
{
    [Table("DOI_Info_ProgramType")]
    public class ProgramType : FullAuditedEntity<int>
    {
        public string Name { get; set; }
        public byte Order { get; set; }

        public virtual ICollection<ProjectInfo> ProjectInfos { get; set; }
    }
}