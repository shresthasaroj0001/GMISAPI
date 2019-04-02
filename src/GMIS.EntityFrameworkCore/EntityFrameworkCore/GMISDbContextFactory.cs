using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using GMIS.Configuration;
using GMIS.Web;

namespace GMIS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class GMISDbContextFactory : IDesignTimeDbContextFactory<GMISDbContext>
    {
        public GMISDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GMISDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            GMISDbContextConfigurer.Configure(builder, configuration.GetConnectionString(GMISConsts.ConnectionStringName));

            return new GMISDbContext(builder.Options);
        }
    }
}
