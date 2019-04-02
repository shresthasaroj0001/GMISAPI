using System.Threading.Tasks;
using Abp.Application.Services;
using GMIS.Sessions.Dto;

namespace GMIS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
