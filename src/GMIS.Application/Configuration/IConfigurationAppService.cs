using System.Threading.Tasks;
using GMIS.Configuration.Dto;

namespace GMIS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
