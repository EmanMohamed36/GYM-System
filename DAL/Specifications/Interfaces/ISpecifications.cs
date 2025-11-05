using DAL.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Specifications.Interfaces
{
    public interface ISpecifications<TEntity> where TEntity : BaseEntity, new()

    {
        public Expression<Func<TEntity,bool>>? Criteria { get;}

        public List<Expression<Func<TEntity,object>>> Include {  get;}

        public Expression<Func<TEntity,object>> OrderBy { get;}
        public Expression<Func<TEntity, object>> OrderByDescending { get; }

        public int Skip {  get; }

        public int Take { get; }

        public bool IsPaginated { get; }

    }
}
