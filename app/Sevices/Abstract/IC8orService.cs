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
        bool CheckIfC8orCreated(int userId);
        Task<Collabor8orDTO> GetC8orByUserId(int userId);
        Task<bool> AddC8or(int userId);
        Task<bool> UpdateC8or(Collabor8orDTO c8or);

    }
}