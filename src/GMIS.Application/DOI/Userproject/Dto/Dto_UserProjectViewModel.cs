using GMIS.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMIS.DOI.Userproject.Dto
{
    public class Dto_UserProjectViewModel
    {
        public string ProjectName { get; set; }
        public string UserFirstName { get; set; }
        public string UserEmail { get; set; }
        public string UserLastName { get; set; }
        public string UserFullName { get; set; }
    }
}
