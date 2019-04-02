using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using GMIS.Entity.ProjectInformation;

namespace GMIS.DOI.ProjectInfos.projectStatuss.Dto
{
    [AutoMap(typeof(ProjectStatus))]
    public class Dto_ProjectStatus : EntityDto<int>
    {
        public string Name { get; set; }
        public byte Order { get; set; }
    }
}
