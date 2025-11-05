using DAL.Models.Shared;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity,new() ;

        public int SaveChanges();


    }
}
