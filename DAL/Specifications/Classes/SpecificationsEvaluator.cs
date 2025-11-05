using BLL.Specifications.Interfaces;
using DAL.Models.Shared;
using DAL.Specifications.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Specifications.Classes
{
    public static class SpecificationsEvaluator
    {
        public static IQueryable<TEntity> CreateQuery<TEntity>(IQueryable<TEntity> inputQuery, ISpecifications<TEntity> specifications)
            where TEntity : BaseEntity, new()
        {
            var query = inputQuery;
            #region Criteria

            if (specifications.Criteria is not null)
            {
                query = query.Where(specifications.Criteria);
            }
            #endregion

            #region Ordering
            if (specifications.OrderBy is not null)
            { 
                query = query.OrderBy(specifications.OrderBy);
            }

            if (specifications.OrderByDescending is not null)
            {
                query = query.OrderByDescending(specifications.OrderByDescending);
            }

            #endregion


            #region Include
            if (specifications.Include is not null && specifications.Include.Any()) 
            {
               query = specifications.Include.Aggregate(query , (current , IncludeExpression) => current.Include(IncludeExpression));

            }
            #endregion


            #region Pagination

            if (specifications.IsPaginated)
            { 
                query = query.Skip(specifications.Skip).Take(specifications.Take);
            }
            #endregion

            return query;
        }
    }
}
