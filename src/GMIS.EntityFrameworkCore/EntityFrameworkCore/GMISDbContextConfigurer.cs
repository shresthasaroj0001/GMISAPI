using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GMIS.EntityFrameworkCore
{
    public static class GMISDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GMISDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GMISDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
