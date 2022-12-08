using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Repositories.Abstract
{
    public interface IGenericKeyRepository<in TKey, TEntity>
    {
        Task<bool> Add(TEntity entity);
        Task<bool> Update(TEntity entity);
        Task<bool> Delete(TEntity entity);
        Task<TEntity> GetById(TKey id);
    }
}