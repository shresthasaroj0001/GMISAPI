using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using GMIS.Entity.ProjectInformation;
using System;

namespace GMIS.DOI.ProjectInfos.ProjectInformations.Dto
{
    [AutoMap(typeof(ProjectInfo))]
    public class Dto_ProjectInfo : EntityDto<int>
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
        public System.DateTime? approved_date { get; set; }
        public System.DateTime? start_date { get; set; }
        public System.DateTime? end_date { get; set; }

        public int ProgramInformationId { get; set; }
        public int ProgramTypeId { get; set; }
        public int ProjectStatusId { get; set; }

        public Guid ProjectId { get; set; }

        public Dto_ProjectInfo()
        {
            this.ProgramInformationId = 0;
            this.Id = 0;
            this.ProgramTypeId = 0;
            this.ProjectStatusId = 0;
            this.project_type = "";
        }
    }
}
