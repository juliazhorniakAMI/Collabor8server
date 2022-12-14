using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public Task<bool> AddC8or(int userId)
        {
           return _Repository.AddC8or(userId);
        }

        public bool CheckIfC8orCreated(int userId)
        {
           return _Repository.CheckIfC8orCreated(userId);
        }

        public Task<Collabor8orDTO> GetC8orByUserId(int userId)
        {
            
            if(CheckIfC8orCreated(userId)){                  
                 return _Repository.GetC8orByUserId(userId);}
            else{
                  AddC8or(userId);
                  return _Repository.GetC8orByUserId(userId);
                }
            }
        public Task<bool> UpdateC8or(Collabor8orDTO c8or)
        {
            return _Repository.UpdateC8or(c8or);
        }
    }
}