using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Query_Paginated
{
    public class QueryParams
    {
        #region Pagination

        private const int DefaultPageSize = 5;
        private const int MaxPageSize = 10;


        public int PageIndex { get; set; } = 1;

        private int pageSize;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value > MaxPageSize || value <= 0 ? DefaultPageSize : value; }
        }




        #endregion
    }
}
