using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using GMIS.Entity.ProjectInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GMIS.DOI.ProjectInfos.ProgramInfo.Dto
{
    [AutoMap(typeof(ProgramInformation))]
    public class Dto_ProgramInformation : EntityDto<int>
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Code { get; set; }

        public byte Order { get; set; }
    }
}
