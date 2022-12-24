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
    public class C8orService : IC8orService
    {
         private readonly IC8orRepository _Repository;
            public C8orService(IC8orRepository Repository)
        {
            _Repository=Repository;       
        }
        public Task<bool> AddC8or(Collabor8orDTO c)
        {
           return _Repository.AddC8or(c);
        }
        public  Task<ServiceResponse<List<Collabor8orDTO>>> GetC8orsByUserId(int userId)
        {
            return _Repository.GetC8orsByUserId(userId);
        }
        public Task<bool> UpdateC8or(Collabor8orDTO c8or)
        {
            return _Repository.UpdateC8or(c8or);
        }
         public Task<bool> DeleteC8or(int id)
        {
            return _Repository.DeleteC8or(id);
        }

        public Task<ServiceResponse<List<Collabor8orDTO>>> GetAllCollabor8ors()
        {  
            return _Repository.GetAllCollabor8ors();
        }
    }
}