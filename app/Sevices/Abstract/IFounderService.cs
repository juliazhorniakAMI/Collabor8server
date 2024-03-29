using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.ModelsDTO;
using app.ModelsDTO.Founders;
using app.DLL.Models;
namespace app.Sevices.Abstract
{
    public interface IFounderService
    {
        Task<ServiceResponse<List<FounderDTO>>> GetFoundersByProjectId(int pjtId,int userId);
        Task<List<FoundersForProjectDTO>> GetAllFoundersByProjectId(int pjtId);
        Task<ServiceResponse<List<FounderDTO>>> GetFoundersByUserId(int userId);
        Task<ServiceResponse<bool>> AddOtherFounders(PostOtherFoundersDTO founder);
        Task<ServiceResponse<bool>> AddFounder(FounderDTO founder);
        Task<bool> UpdateFounder(FounderDTO founder);
        Task<bool> DeleteFounder(int id);
    }
}