using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
namespace app.DLL.Repositories.Abstract
{
    public interface IProjectFounderRepository
    {   Task<ServiceResponse<List<ProjectFounderDTO>>> GetAllPjtsByFounderId(int founderId);
        Task<ServiceResponse<List<ProjectFounderDTO>>> GetFoundersByProjectId(int pjtId);
        Task<bool> AddFounderToProject(int founderId,int pjtId);
        Task<bool> DeleteFounderFromProject(int id);
    }
}