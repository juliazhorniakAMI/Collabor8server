using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.ModelsDTO;
namespace app.DLL.Repositories.Abstract
{
    public interface IC8orRepository
    {
        bool CheckIfC8orCreated(int userId);
        Task<Collabor8orDTO> GetC8orByUserId(int userId);
        Task<bool> AddC8or(int userId);
        Task<bool> UpdateC8or(Collabor8orDTO c8or,int c8orId);

    }
}