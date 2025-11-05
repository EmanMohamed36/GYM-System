using DAL.Models.Shared;
using DAL.Specifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity , new()
    {
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity,bool>> expression);

        public Task<TEntity?> GetByIdAsync(int id);

        public Task CreateAsync(TEntity entity);
               
        public void Update(TEntity entity);
               
        public void Delete(int id);

        #region Specifications

        public Task<IEnumerable<TEntity>> GetAllAsync(ISpecifications<TEntity> specifications);
        public Task<TEntity?> GetByIdAsync(ISpecifications<TEntity> specifications);

        Task<int> GetCountSpecificationAsync(ISpecifications<TEntity> specifications);

        #endregion
    }
}
