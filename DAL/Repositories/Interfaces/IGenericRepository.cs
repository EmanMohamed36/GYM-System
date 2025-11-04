using DAL.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    internal interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {

    }
}
