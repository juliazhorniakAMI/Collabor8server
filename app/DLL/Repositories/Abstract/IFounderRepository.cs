using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.ModelsDTO;
using app.DLL.Models;
using app.ModelsDTO.Founders;

namespace app.DLL.Repositories.Abstract
{
    public interface IFounderRepository
    {
        Task<ServiceResponse<bool>> AddOtherFounders(PostOtherFoundersDTO founder);
        Task<ServiceResponse<List<FounderDTO>>> GetFoundersByProjectId(int pjtId,int userId);
        Task<List<FoundersForProjectDTO>> GetAllFoundersByProjectId(int pjtId);
        Task<ServiceResponse<List<FounderDTO>>> GetFoundersByUserId(int userId);
        Task<ServiceResponse<bool>> AddFounder(FounderDTO founder);
        Task<bool> UpdateFounder(FounderDTO founder);
        Task<bool> DeleteFounder(int id);
    }
}