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
        Task<ServiceResponse<List<Collabor8orDTO>>> GetC8orsByUserId(int userId);
        Task<bool> AddC8or(int userId);
        Task<bool> UpdateC8or(Collabor8orDTO c8or);
        Task<bool> DeleteC8or(int id);

    }
}