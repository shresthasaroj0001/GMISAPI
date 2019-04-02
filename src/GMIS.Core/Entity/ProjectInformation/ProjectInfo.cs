using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GMIS.Entity.ProjectInformation
{
    [Table("DOI_ProjectInfo")]
    public class ProjectInfo : FullAuditedEntity<int>
    {
        public decimal commandarea_gca { get; set; }
        public decimal commandarea_nca { get; set; }
        public string mgmt_system { get; set; }
        public string mgmt_system_other { get; set; }
        public string project_type { get; set; }

        public string project_comment { get; set; }

        public string other_info_prepared_by { get; set; }
        public string other_info_approved_by { get; set; }
        public string other_info_recommended_by { get; set; }

        public bool IsPhaseCompleted { get; set; }
        [Column(TypeName = "date")]
        public DateTime? approved_date { get; set; }
        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }
        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        [ForeignKey("ProgramInformation")]
        public int ProgramInformationId { get; set; }

        [ForeignKey("ProgramType")]
        public int ProgramTypeId { get; set; }

        [ForeignKey("ProjectStatus")]
        public int ProjectStatusId { get; set; }
        
        //one to one relationship
        public virtual ProgramInformation ProgramInformation { get; set; }
        public virtual ProgramType ProgramType { get; set; }
        public virtual ProjectStatus ProjectStatus { get; set; }

        [ForeignKey("Project")]
        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
