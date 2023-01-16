using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
namespace app.Sevices.Abstract
{
    public interface IC8orService
    {
        Task<ServiceResponse<List<Collabor8orDTO>>> GetAllCollabor8ors();
        Task<ServiceResponse<List<Collabor8orDTO>>> GetC8orsByUserId(int userId);
        Task<ServiceResponse<bool>> AddC8or(Collabor8orDTO c);
        Task<bool> UpdateC8or(Collabor8orDTO c8or);
        Task<bool> DeleteC8or(int id);

    }
}