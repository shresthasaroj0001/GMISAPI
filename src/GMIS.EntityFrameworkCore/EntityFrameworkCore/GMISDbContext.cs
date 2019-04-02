using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GMIS.Authorization.Roles;
using GMIS.Authorization.Users;
using GMIS.MultiTenancy;
using GMIS.Entity.ProjectInformation;
using GMIS.Entity;

namespace GMIS.EntityFrameworkCore
{
    public class GMISDbContext : AbpZeroDbContext<Tenant, Role, User, GMISDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GMISDbContext(DbContextOptions<GMISDbContext> options)
            : base(options)
        {
        }


        public DbSet<Project> Projects { get; set; }
        public DbSet<UserProject> UserProjects { get; set; }

        //Project Information
        public DbSet<ProgramInformation> ProgramInformations { get; set; }
        public DbSet<ProgramType> ProgramTypes { get; set; }
        public DbSet<ProjectInfo> ProjectInfos { get; set; }
        public DbSet<ProjectStatus> ProjectStatus { get; set; }

    }
}