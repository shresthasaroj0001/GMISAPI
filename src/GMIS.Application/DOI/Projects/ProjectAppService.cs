using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using GMIS.DOI.Projects.Dtos;
using GMIS.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using GMIS.DOI.Userproject.Dto;
using Abp.UI;

namespace GMIS.DOI.Projects
{
    [AbpAuthorize]
    public class ProjectAppService : AsyncCrudAppService<Project, Dto_Project, Guid, PagedProjectResultRequestDto, Dto_Project, Dto_Project>
    {
        public readonly IRepository<Project, Guid> _projectRepository;
        public readonly IRepository<UserProject, Guid> _userProjectRepo; //relation table nai yehi ho
        public ProjectAppService(
            IRepository<Project, Guid> repo,
            IRepository<UserProject, Guid> userProjectRepo
            ) : base(repo)
        {
            _projectRepository = repo;
            _userProjectRepo = userProjectRepo;
        }

        public override Task<PagedResultDto<Dto_Project>> GetAll(PagedProjectResultRequestDto input)
        {
            //var query = _projectRepository.GetAllIncluding().Where(x => x.IsDeleted == false);
            //query.

            return base.GetAll(input);
        }

        public async Task<PagedResultDto<Dto_ProjectUserCount>> GetAllWithUserCount(PagedResultRequestDto input)
        {
            //var result = (from r in userManager.UserRoles
            //              join u in userManager.Users on r.UserId equals u.Id
            //              group new { r, u } by new { r.RoleId } into grp
            //              select new { name = grp.FirstOrDefault().r.Name, count = grp.Count() }).ToList();

            var query = ( from item in
                            _projectRepository.GetAll().Where(x => x.IsDeleted == false)
                                select new Dto_ProjectUserCount
                                {
                                    Id = item.Id,
                                    Name = item.Name,
                                    Counts = item.UserProjects.Count()
                                });
            var totalCount = await AsyncQueryableExecuter.CountAsync(query);

            var result = await AsyncQueryableExecuter.ToListAsync(query);

            return new PagedResultDto<Dto_ProjectUserCount>(totalCount, result.Skip(input.SkipCount).Take(input.MaxResultCount).ToList());
        }

        public override Task<Dto_Project> Create(Dto_Project input)
        {
            var result = _projectRepository.FirstOrDefault(x =>(String.Equals(x.Name, input.Name, StringComparison.OrdinalIgnoreCase)));

            if (result != null)
            {
                throw new UserFriendlyException("Project Name Already Used");
            }

            return base.Create(input);
        }


        public void GetAllProjectUser(PagedResultRequestDto input)
        {
            //from item in
            //_projectRepository.GetAll().Where(x=>x.IsDeleted == false)
            //   join t2 in 
            //   _userProjectRepo.GetAll().Where(xx=>xx.IsDeleted == false)
            //   on item.Id eq

            // yeta garnu dai
            //_projectRepository.GetAll();
            //var result = _userProjectRepo.GetAllIncluding(c => c.Project, b => b.ProjectUsers)
            //    .Select(c => new
            //    {
            //        projectId= c.ProjectId,
            //        projectName= c.Project.Name,
            //        userId= c.UserId,
            //        userName = c.ProjectUsers.FirstOrDefault().Name
            //    })
            //    .GroupBy(c=>c.projectId)
            //    .Select(x=> new {
            //        projectId = x.First().projectId,
            //        projectName = x.First().projectName,
            //        Users = x.Select(innerItem => new {
            //            userId = x.First().userId,
            //            username = x.First().userName
            //        })
            //    });
            //result.ToList();

        }

       

        //public void GetAllProjectUser(PagedProjectUserResultRequestDto input)
        //{
        //    from projects in
        //    _projectRepository.GetAllIncluding().Where(x => x.IsDeleted == false)
        //    join users in
        //    _userProjectRepo.GetAllIncluding().Where(userproject => userproject.IsDeleted == false)
        //    on projects.Id equals users.ProjectId into eGroup
        //    from d in eGroup.DefaultIfEmpty()
        //    select new 
        //    {
        //        ProjectName = projects.Name,
        //        User = 

        //    }


        //    _projectRepository.GetAllIncluding().Where(x => 
        //        x.IsDeleted == false || 
        //        x.UserProjects.
        //        );

        //    //filtering
        //    if (!string.IsNullOrEmpty(input.Keyword))
        //    {
        //        string keyword = input.Keyword.ToLower();
        //        results.
        //        query = query.Where(x =>
        //        x.UserFirstName.ToLower().StartsWith(keyword) ||
        //        x.UserEmail.ToLower().Contains(keyword)).ToList();
        //    }


        //    from users in _userProjectRepo.GetAll().Where(x =>x.IsDeleted==false)
        //    join 
        //    projects in _projectRepository.GetAll().Where(proj=>proj.IsDeleted== false)
        //    on users.ProjectId = Projects.



        //    var query = (from project in
        //                           _projectRepository.GetAll().Where(projects => projects.IsDeleted == false)
        //                 join users in
        //                 _userProjectRepo.GetAll().Where(user => user.IsDeleted == false)
        //                 on project.Id equals users.ProjectId
        //                 select new Dto_UserProjectViewModel
        //                 {
        //                     ProjectName = project.Name,
        //                     UserEmail = users.User.EmailAddress,
        //                     UserLastName = users.User.Surname,
        //                     UserFullName = users.User.FullName,
        //                     UserFirstName = users.User.UserName
        //                 }).ToList();


        //    var totalCount = query.Count();
        //    //skipping
        //    query = query.Skip(input.SkipCount).Take(input.MaxResultCount).ToList();

        //    return new PagedResultDto<LeadsDto>(totalCount, result.Skip(input.SkipCount).Take(input.MaxResultCount).ToList());
        //}
    }
}
