using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Repositories.Abstract;
using app.ModelsDTO;
using app.Sevices.Abstract;

namespace app.Sevices.Impl
{
    public class PMService : IPMService
    {
        private readonly IPMRepository _Repository;
        public PMService(IPMRepository Repository)
        {
            _Repository = Repository;
        }
        public Task<bool> Addpm(int userId)
        {
            return _Repository.Addpm(userId);
        }

        public bool CheckIfPMCreated(int userId)
        {
            return _Repository.CheckIfPMCreated(userId);
        }

        public Task<PMDTO> GetPMByUserId(int userId)
        {
            if (CheckIfPMCreated(userId))
            {
                return _Repository.GetPMByUserId(userId);
            }
            else
            {
                Addpm(userId);
                return _Repository.GetPMByUserId(userId);
            }
        }
    }
}