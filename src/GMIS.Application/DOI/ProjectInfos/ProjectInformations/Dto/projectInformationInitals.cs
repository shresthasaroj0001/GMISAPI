using GMIS.DOI.ProjectInfos.ProgramInfo.Dto;
using GMIS.DOI.ProjectInfos.ProgramTypes.Dto;
using GMIS.DOI.ProjectInfos.projectStatuss.Dto;
using System.Collections.Generic;

namespace GMIS.DOI.ProjectInfos.ProjectInformations.Dto
{
    public class ProjectInformationInitals
    {
        public List<Dto_ProgramType> ProgramTypeList { get; set; }
        public List<Dto_ProgramInformation> ProgramInformationList { get; set; }
        public List<Dto_ProjectStatus> ProjectStatusList { get; set; }

        public ProjectInformationInitals()
        {
            this.ProgramInformationList = new List<Dto_ProgramInformation>();
            this.ProgramTypeList = new List<Dto_ProgramType>();
            this.ProjectStatusList = new List<Dto_ProjectStatus>();
        }
    }
}
