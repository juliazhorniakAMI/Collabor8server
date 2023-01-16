using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DLL.Repositories.Abstract;
using app.ModelsDTO;
using app.Sevices.Abstract;

namespace app.Sevices.Impl
{
    public class C8orAccepted4ProjectService : IC8orAccepted4ProjectService
    {
        private readonly IC8orAccepted4ProjectRepository _Repository;
        private readonly IC8orProjectService _cpService;
        public C8orAccepted4ProjectService(IC8orAccepted4ProjectRepository Repository,IC8orProjectService cpService)
        {
            _Repository=Repository;       
            _cpService=cpService;
        }

        public Task<ServiceResponse<bool>> AddAcceptedC8or4Project(C8orAccepted4ProjectDTO cp)
        {
           return _Repository.AddAcceptedC8or4Project(cp);
        }

        public Task<bool> CancelAcceptedC8or(int id)
        {
             
           return _Repository.CancelAcceptedC8or(id);
        }

        public Task<C8orAccepted4ProjectDTO> GetAcceptedC8or4ProjectById(int id)
        {
           return _Repository.GetAcceptedC8or4ProjectById(id);
        }

        public Task<ServiceResponse<List<C8orAccepted4ProjectDTO>>> GetAcceptedC8rs4MyPrjtsByUserId(int userId)
        {
           return _Repository.GetAcceptedC8rs4MyPrjtsByUserId(userId);
        }
        
        public Task<ServiceResponse<List<C8orAccepted4ProjectDTO>>> GetAcceptedMyC8rs4PrjtsByUserId(int userId)
        {
              return _Repository.GetAcceptedMyC8rs4PrjtsByUserId(userId);
        }
        }
    }
