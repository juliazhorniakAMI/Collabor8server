using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.ModelsDTO;

namespace app.Sevices.Abstract
{
    public interface IPMService
    {
        Task<bool> Addpm(int userId);
        bool CheckIfPMCreated(int userId);
        Task<PMDTO> GetPMByUserId(int userId);
    }
}