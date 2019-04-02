using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using GMIS.DOI.ProjectInfos.ProgramTypes.Dto;
using GMIS.Entity.ProjectInformation;

namespace GMIS.DOI.ProjectInfos.ProgramTypes
{
    public class ProgramTypeAppService : AsyncCrudAppService<ProgramType, Dto_ProgramType, int, PagedResultRequestDto, Dto_ProgramType, Dto_ProgramType>
    {
        private readonly IRepository<ProgramType, int> _repo;

        public ProgramTypeAppService(
            IRepository<ProgramType, int> repo
            ) : base(repo)
        {
            _repo = repo;
        }

    }
}
