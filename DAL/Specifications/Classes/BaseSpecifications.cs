using DAL.Models.Shared;
using DAL.Specifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Specifications.Classes
{
    internal abstract class BaseSpecifications<TEntity> : ISpecifications<TEntity> where TEntity : BaseEntity, new()
    {

        protected BaseSpecifications(Expression<Func<TEntity, bool>>? criteria) {
            Criteria = criteria;
        }
        #region Criteria
        public Expression<Func<TEntity, bool>>? Criteria  {get;private set;}

        #endregion

        #region Include
        public List<Expression<Func<TEntity, object>>> Include { get; } = [];
        protected void AddInclude(Expression<Func<TEntity, object>> expression)
        { 
            IncludeExpressions.Add(expression);
        }

        #endregion



        #region Ordering

        public Expression<Func<TEntity, object>> OrderBy { get; private set; }

        public Expression<Func<TEntity, object>> OrderByDescending { get; private set; }

        protected void AddOrderBy(Expression<Func<TEntity, object>> orderBYExpression)
        {
            OrderBy = orderBYExpression;
        }

        protected void AddOrderByDescending(Expression<Func<TEntity, object>> orderBYDescExpression)
        {
            OrderByDescending = orderBYDescExpression;
        }



        #endregion

        #region Pagination

        public int Skip { get; private set; }

        public int Take { get; private set; }

        public bool IsPaginated { get; private set; }

        protected void ApplyPagination(int pageSize , int pageIndex)
        {
            IsPaginated = true;
            Take = pageSize;
            Skip = (pageIndex - 1) * pageSize;
        }
        #endregion

    }
}
