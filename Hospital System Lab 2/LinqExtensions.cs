using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public static class LinqExtensions
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> data, int currentPage, int skip)
        {
            return data.Skip(currentPage * skip).Take(skip);
        }
    }
}
