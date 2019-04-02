using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using GMIS.DOI.ProjectInfos.ProgramInfo.Dto;
using GMIS.Entity.ProjectInformation;

namespace GMIS.DOI.ProjectInfos.ProgramInfo
{
    public class ProgramInfoAppService : AsyncCrudAppService<ProgramInformation, Dto_ProgramInformation, int, PagedResultRequestDto, Dto_ProgramInformation, Dto_ProgramInformation>
    {
        private readonly IRepository<ProgramInformation, int> _repo;

        public ProgramInfoAppService(IRepository<ProgramInformation, int> repo) : base(repo)
        {
            _repo = repo;
        }

    }
}
