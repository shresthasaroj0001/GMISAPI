using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GMIS.Configuration.Dto;

namespace GMIS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GMISAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
