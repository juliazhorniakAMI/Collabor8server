using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Models.Enums;
using app.ModelsDTO;

namespace app.DLL.Repositories.Abstract
{
    public interface IC8orProjectRepository
    {
          Task<ServiceResponse<bool>> AddC8orProject(C8orProjectDTO cp);
          Task<ServiceResponse<List<C8orProjectDTO>>> GetListProjectsForAllC8or(Direction direction,int userId);
          Task<ServiceResponse<List<C8orProjectDTO>>> GetListC8orsForAllPjt(Direction direction, int userId);
          Task<ServiceResponse<List<C8orProjectDTO>>> GetListProjectsForOneC8or(Direction direction,int c8orId);
          Task<ServiceResponse<List<C8orProjectDTO>>> GetListC8orsForOnePjt(Direction direction, int pId);
          Task<bool> UpdateC8orPjtStatus(int cpId,Status status);
          Task<bool> DeleteC8orProject(int id);
    }
}