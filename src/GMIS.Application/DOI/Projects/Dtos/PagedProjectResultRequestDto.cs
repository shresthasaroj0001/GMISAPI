using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMIS.DOI.Projects.Dtos
{
    public class PagedProjectResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
