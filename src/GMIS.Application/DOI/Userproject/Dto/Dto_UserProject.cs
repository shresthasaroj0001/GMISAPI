using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using GMIS.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMIS.DOI.Userproject.Dto
{
    [AutoMap(typeof(UserProject))]
    public class Dto_UserProject : EntityDto<Guid>
    {
        public Guid ProjectId { get; set; }

        public long UserId { get; set; }
    }
}
