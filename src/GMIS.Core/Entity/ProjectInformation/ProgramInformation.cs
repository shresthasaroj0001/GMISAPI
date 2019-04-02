using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GMIS.Entity.ProjectInformation
{
    [Table("DOI_Info_ProgramInfo")]
    public class ProgramInformation : FullAuditedEntity<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public byte Order { get; set; }

        public virtual ICollection<ProjectInfo> ProjectInfos { get; set; }
    }
}
