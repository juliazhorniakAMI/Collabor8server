using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;

namespace app.DLL.Repositories.Abstract
{
    public interface IProjectSupportInfoRepository
    {
          Task<bool> AddSupportInfo(ProjectSupportInfoDTO psi);
          Task<ServiceResponse<List<ProjectSupportInfoDTO>>> GetAllInfoByProjectId(int pjtId);
          Task<bool> UpdateInfoForProject(ProjectSupportInfoDTO psi);
          Task<bool> DeleteInfoFromProject(int id);
    }
}