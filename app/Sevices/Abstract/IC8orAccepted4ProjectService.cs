using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;

namespace app.Sevices.Abstract
{
    public interface IC8orAccepted4ProjectService
    {
        Task<bool> AddAcceptedC8or4Project(C8orAccepted4ProjectDTO cp);
        Task<bool> CancelAcceptedC8or(int id);
        Task<ServiceResponse<List<C8orAccepted4ProjectDTO>>> GetAcceptedMyC8rs4PrjtsByUserId(int userId);
        Task<ServiceResponse<List<C8orAccepted4ProjectDTO>>> GetAcceptedC8rs4MyPrjtsByUserId(int userId);
        Task<C8orAccepted4ProjectDTO> GetAcceptedC8or4ProjectById(int id);
    }
}