using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.ModelsDTO;
namespace app.DLL.Repositories.Abstract
{
    public interface IFounderRepository
    {
         bool CheckIfFounderCreated(int userId);
        Task<FounderDTO> GetFounderByUserId(int userId);
        Task<bool> AddFounder(int userid);
        Task<bool> UpdateFounder(FounderDTO founder);
    }
}