using DAL.Data;
using DAL.Models.Shared;
using DAL.Repositories.Interfaces;
using DAL.Specifications.Classes;
using DAL.Specifications.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Classes
{
    public class GenericRepository<TEntity>(ApplicationDbContext _dbContext) : IGenericRepository<TEntity>
        where TEntity : BaseEntity , new() // not to make genericUser repository as it inherit from base entity 
    {
        public async Task CreateAsync(TEntity entity)
            => await _dbContext.Set<TEntity>().AddAsync(entity);
       

        public void Delete(int id)
        {
            var res = _dbContext.Set<TEntity>().Find(id);
            if (res is null) return;
            _dbContext.Set<TEntity>().Remove(res);
  
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync() 
            =>  await _dbContext.Set<TEntity>().ToListAsync();

        public async Task<TEntity?> GetByIdAsync(int id)
            => await _dbContext.Set<TEntity>().FindAsync(id);

        public void Update(TEntity entity) => _dbContext.Set<TEntity>().Update(entity);


        #region Specifications
        public async Task<IEnumerable<TEntity>> GetAllAsync(ISpecifications<TEntity> specifications)
        {
            return await SpecificationsEvaluator.CreateQuery(_dbContext.Set<TEntity>(), specifications).ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(ISpecifications<TEntity> specifications)
        {
            return await SpecificationsEvaluator.CreateQuery(_dbContext.Set<TEntity>(), specifications).FirstOrDefaultAsync();
        }

        public async Task<int> GetCountSpecificationAsync(ISpecifications<TEntity> specifications)
        {
            return await SpecificationsEvaluator.CreateQuery(_dbContext.Set<TEntity>(), specifications).CountAsync();
        }

        async Task<IEnumerable<TEntity>> IGenericRepository<TEntity>.GetAllAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _dbContext.Set<TEntity>().Where(expression).ToListAsync();
        }
        #endregion


    }
}
