using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using GMIS.DOI.ProjectInfos.projectStatuss.Dto;
using GMIS.Entity.ProjectInformation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMIS.DOI.ProjectInfos.projectStatuss
{
    public class ProjectStatusAppService : AsyncCrudAppService<ProjectStatus,Dto_ProjectStatus,int, PagedResultRequestDto, Dto_ProjectStatus, Dto_ProjectStatus>
    {
        private readonly IRepository<ProjectStatus,int> _repository;

        public ProjectStatusAppService(IRepository<ProjectStatus,int> repository) : base(repository)
        {
            this._repository = repository;
        }
    }
}
