using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using app.ModelsDTO.C8or;

namespace app.Sevices.Abstract
{
    public interface IC8orService
    {
        Task<ServiceResponse<List<Collabor8orDTO>>> GetAllCollabor8ors();
        Task<ServiceResponse<List<Collabor8orDTO>>> GetC8orsByUserId();
        Task<ServiceResponse<bool>> AddC8or(Collabor8orDTO c);
        Task<bool> UpdateC8or(Collabor8orUpdateDTO c8or);
        Task<bool> DeleteC8or(int id,string sphere);

    }
}