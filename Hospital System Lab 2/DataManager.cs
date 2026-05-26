using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public class DataManager<T> where T : IEntity 
    {
        public IEnumerable<T> Entities { get; private set; } = new List<T>();
        public T? this[Guid id]
        {
            get
            {
                return Entities.FirstOrDefault(e => e.Id == id);
            }
        }
        public void Add(T entity)
        {
            Entities = Entities.Append(entity);
        }

        public IEnumerable<T> Search(string searchString)
        {
            return Entities.Where(it => it.Search(searchString));
        }

        public IEnumerable<T> Filter(Func<T, bool> filter)
        {
            return Entities.Where(filter);
        }
    }
}
