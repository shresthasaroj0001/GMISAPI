using Xunit;

namespace GMIS.Tests
{
    public sealed class MultiTenantFactAttribute : FactAttribute
    {
        public MultiTenantFactAttribute()
        {
            if (!GMISConsts.MultiTenancyEnabled)
            {
                //Skip = "MultiTenancy is disabled.";
            }
        }
    }
}
