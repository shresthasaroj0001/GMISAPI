using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using GMIS.Authorization.Roles;
using GMIS.Authorization.Users;
using GMIS.DOI.Userproject.Dto;
using GMIS.Entity;
using GMIS.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GMIS.DOI.Userproject
{
    [AbpAuthorize]
    public class UserProjectAppService : AsyncCrudAppService<UserProject, Dto_UserProject, Guid, PagedResultRequestDto, Dto_UserProject, Dto_UserProject>
    {
        private readonly IRepository<UserProject, Guid> _userProjectRepository;
        private readonly IRepository<User, long> _userRepository;
        private readonly IRepository<Role> _roleRepository;

        public UserProjectAppService(
            IRepository<UserProject, Guid> _repo,
             IRepository<User, long> userRepository,
             IRepository<Role> roleRepository,
            ICollection<UserRole>  Role) : base(_repo)
        {
            _userProjectRepository = _repo;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        public ListResultDto<UserDto> GetUsersNotAssignedToProject()
        {
            var UserIdsAssignedToProject = _userProjectRepository.GetAll().Where(x => x.IsDeleted == false).ToList(); //yesma  userId matra ayo
            //var DataEntryUsers = _userRepository.GetAllIncluding(q => q.Permissions,mbox =>mbox.Roles)
            //    .Where(x => x.Permissions.Select(permi => permi.Name).Contains("Pages_DataInsert")).ToList();

            //var Users = _userRepository.GetAllIncluding(q => q.Permissions, mbox => mbox.Roles).ToList();

            var UsersOfRoleId4 = _userRepository.GetAllIncluding(x => x.Roles)
                .Where(z => z.Roles.
                Select(q => q.RoleId).Contains(4)).ToList();

           // var Managers =  from users in _userRepository.GetAll() where users.Permissions.Any(r => r.Name == "Pages.DataInsert") select new UserDto { Id = users.Id,EmailAddress = users.EmailAddress };

            //public const string Pages_DataUpdate = "Pages.DataUpdate";
            //public const string Pages_DataInsert = "Pages.DataInsert";

            //from item in
            //    _userRepository.GetAll().Where(x=>x.IsDeleted == false)
            //    join 


            //var UsersOnly = _userRepository.GetAll().Where(x => x.Roles.Contains( ("DATAENTRY")).ToList();

            var result = (from item in UsersOfRoleId4.Where(x => !UserIdsAssignedToProject.Any(userr => userr.UserId == x.Id))
                          select new UserDto
                          {
                              Id = item.Id,
                              EmailAddress = item.EmailAddress,
                              FullName = item.FullName,
                              Name = item.Name
                          }).ToList();

            return new ListResultDto<UserDto>(result);
        }

    }
}
