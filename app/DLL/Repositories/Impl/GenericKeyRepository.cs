using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace app.DLL.Repositories.Impl
{
     public class GenericKeyRepository<TKey, TEntity, TContext> : IGenericKeyRepository<TKey, TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        protected readonly TContext Context;

        public GenericKeyRepository(TContext context)
        {
            Context = context;
        } 
        public async Task<bool> Add(TEntity entity)
        {
            var item =  Context.Set<TEntity>().Add(entity);
            await Context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
              await Context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Delete(TEntity entity)
        {
            var result = Context.Set<TEntity>().Remove(entity).Entity;
             await Context.SaveChangesAsync();

            return true;
        }
        public async Task<TEntity> GetById(TKey id)
        {
            return  await Context.Set<TEntity>()
                .FindAsync(id);
        }
    }
}