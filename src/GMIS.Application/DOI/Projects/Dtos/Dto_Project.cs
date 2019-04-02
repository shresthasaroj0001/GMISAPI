using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using GMIS.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GMIS.DOI.Projects.Dtos
{
    [AutoMap(typeof(Project))]
    public class Dto_Project : EntityDto<Guid>
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        //public int ProgramInformationId { get; set; }
        //public int ProgramTypeId { get; set; }
    }
}
