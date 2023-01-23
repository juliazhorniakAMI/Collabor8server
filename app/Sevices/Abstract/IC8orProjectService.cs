using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Models.Enums;
using app.ModelsDTO;

namespace app.Sevices.Abstract
{
    public interface IC8orProjectService
    {
          Task<ServiceResponse<bool>> AddC8orProject(C8orProjectBrowseDTO cp);
          Task<ServiceResponse<List<C8orProjectDTO>>> GetListProjectsForAllC8or(Direction direction,int userId);
          Task<ServiceResponse<List<C8orProjectDTO>>> GetListC8orsForAllPjt(Direction direction, int userId);
          Task<ServiceResponse<List<C8orProjectDTO>>> GetListProjectsForOneC8or(Direction direction,int c8orId);
          Task<ServiceResponse<List<C8orProjectDTO>>> GetListC8orsForOnePjt(Direction direction, int pId);
          Task<bool> UpdateC8orPjt(C8orProjectDashboardDTO cp);
          Task<bool>DeleteC8orProject(int UserId,string sphereId,int pjtId);
    }
}