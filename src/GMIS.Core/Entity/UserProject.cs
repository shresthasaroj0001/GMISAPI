using Abp.Authorization.Users;
using Abp.Domain.Entities.Auditing;
using GMIS.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GMIS.Entity
{
    [Table("UserProjects")]
    public class UserProject : FullAuditedEntity<Guid>
    {
        [ForeignKey("Project")]
        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }
        public virtual AbpUser<User> ProjectUser { get; set; }

    }
}
