using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Repositories.Abstract;
using app.ModelsDTO;
using app.Sevices.Abstract;

namespace app.Sevices.Impl
{
    public class FounderService : IFounderService
    {
       private readonly IFounderRepository _Repository;
            public FounderService(IFounderRepository Repository)
        {
            _Repository=Repository;       
        }       
         public Task<bool> AddFounder(int userId)
        {
           return _Repository.AddFounder(userId);
        }
        public bool CheckIfFounderCreated(int userId)
        {
            return _Repository.CheckIfFounderCreated(userId);
        }
        public Task<FounderDTO> GetFounderByUserId(int userId)
        {    
            if(CheckIfFounderCreated(userId)){                  
                 return _Repository.GetFounderByUserId(userId);}
            else{
                  AddFounder(userId);
                  return _Repository.GetFounderByUserId(userId);
                }
        }
        public Task<bool> UpdateFounder(FounderDTO founder)
        {
             return _Repository.UpdateFounder(founder);
        }
    }
}