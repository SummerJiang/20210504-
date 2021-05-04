using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page
{
    public static class Pageing
    {
        /// <summary>
        ///     分頁功能
        /// </summary>
        /// <param name="query">資料集合</param>
        /// <param name="currentPage">所在頁數</param>
        /// <param name="pageSize">一頁幾筆</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IQueryable<T> ToPageList<T>(this IQueryable<T> query, int currentPage, int pageSize)
        {

            var skip = (currentPage - 1) * pageSize;
            var temp = query.Skip(skip);
            return temp.Take(pageSize);
        }
    }
}
