using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GMIS.DOI.ProjectInfos.ProgramInfo.Dto;

namespace GMIS.DOI.ProjectInfos.ProgramInfo
{
    public interface IProgramInfoAppService : IAsyncCrudAppService<Dto_ProgramInformation, int, PagedResultRequestDto, Dto_ProgramInformation, Dto_ProgramInformation>
    {
    }
}
