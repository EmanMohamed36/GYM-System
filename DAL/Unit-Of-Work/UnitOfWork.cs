using DAL.Data;
using DAL.Models.Shared;
using DAL.Repositories.Classes;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public class UnitOfWork(ApplicationDbContext _dbContext) : IUnitOfWork
    {   
        private readonly Dictionary<Type,object> _repositories = new Dictionary<Type,object>();
        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity, new()
        {
            var EntityType = typeof(TEntity);
            if (_repositories.TryGetValue(EntityType, out var repository))
                return (IGenericRepository < TEntity >) repository;

            var newRepo = new GenericRepository<TEntity>(_dbContext);

            _repositories.Add(EntityType, newRepo);
            return newRepo;
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
