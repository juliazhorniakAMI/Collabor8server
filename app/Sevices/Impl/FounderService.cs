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
    public class FounderService : IFounderService
    {
       private readonly IFounderRepository _Repository;
            public FounderService(IFounderRepository Repository)
        {
            _Repository=Repository;       
        }       
        public  Task<ServiceResponse<List<FounderDTO>>> GetFoundersByUserId(int userId)
        {
            return _Repository.GetFoundersByUserId(userId);
        }
         public Task<bool> AddFounder(FounderDTO founder)
        {
           return _Repository.AddFounder(founder);
        }
        public Task<bool> UpdateFounder(FounderDTO founder)
        {
             return _Repository.UpdateFounder(founder);
        }
          public Task<bool> DeleteFounder(int id)
        {
            return _Repository.DeleteFounder(id);
        }
         public Task<bool> AddOtherFounders(PostOtherFoundersDTO founder)
        {
           return _Repository.AddOtherFounders(founder);
        }
         public Task<ServiceResponse<List<FounderDTO>>> GetFoundersByProjectId(int pjtId, int userId)
        {
             return _Repository.GetFoundersByProjectId(pjtId,userId);
        }
    }
}