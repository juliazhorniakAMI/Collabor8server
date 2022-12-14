using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.ModelsDTO;
namespace app.Sevices.Abstract
{
    public interface IFounderService
    {
        bool CheckIfFounderCreated(int userId);
        Task<FounderDTO> GetFounderByUserId(int userId);
        Task<bool> AddFounder(int userid);
        Task<bool> UpdateFounder(FounderDTO founder);
    }
}