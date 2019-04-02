using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GMIS.DOI.Projects.Dtos;
using System;

namespace GMIS.DOI.ProjectInfos.ProgramTypes
{
    public interface IProgramTypeAppService : IAsyncCrudAppService<Dto_Project, Guid, PagedResultRequestDto, Dto_Project, Dto_Project>
    {
    }
}
