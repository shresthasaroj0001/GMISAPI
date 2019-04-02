using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using GMIS.Entity.ProjectInformation;
using System.ComponentModel.DataAnnotations;

namespace GMIS.DOI.ProjectInfos.ProgramTypes.Dto
{
    [AutoMap(typeof(ProgramType))]
    public class Dto_ProgramType : EntityDto<int>
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public byte Order { get; set; }
    }
}