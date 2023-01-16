using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.ModelsDTO;
using app.DLL.Models;
namespace app.DLL.Repositories.Abstract
{
    public interface IC8orRepository
    {
        Task<ServiceResponse<List<Collabor8orDTO>>> GetAllCollabor8ors();
        Task<ServiceResponse<List<Collabor8orDTO>>> GetC8orsByUserId(int userId);
        Task<ServiceResponse<bool>> AddC8or(Collabor8orDTO c);
        Task<bool> UpdateC8or(Collabor8orDTO c8or);
        Task<bool> DeleteC8or(int id);

    }
}