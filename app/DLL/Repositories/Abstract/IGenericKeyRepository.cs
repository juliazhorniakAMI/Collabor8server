using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.DLL.Repositories.Abstract
{
    public interface IGenericKeyRepository<in TKey, TEntity>
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        TEntity GetById(TKey id);
    }
}