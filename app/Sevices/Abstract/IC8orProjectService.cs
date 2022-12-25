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
          Task<bool> AddC8orProject(C8orProjectDTO cp);
          Task<ServiceResponse<List<C8orProjectDTO>>> GetListProjectsForC8or(Direction direction,int userId);
          Task<ServiceResponse<List<C8orProjectDTO>>> GetListC8orsForPjt(Direction direction, int userId);
    }
}