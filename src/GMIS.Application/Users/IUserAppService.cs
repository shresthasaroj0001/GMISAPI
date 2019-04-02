using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GMIS.Roles.Dto;
using GMIS.Users.Dto;

namespace GMIS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
