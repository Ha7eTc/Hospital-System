using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public delegate bool FilterDelegate<T>(T entity) where T : IEntity;
}
