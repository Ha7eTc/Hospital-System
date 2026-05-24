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
                T? entity = default;
                foreach (var item in Entities)
                {
                    if (item.Id == id)
                        return item;
                }
                return entity;
            }
        }
        public void Add(T entity)
        {
            Entities = Entities.Append(entity);
        }

        public IEnumerable<T> Search(string searchString)
        {
            foreach (var entity in Entities)
            {
                if (entity.Search(searchString))
                {
                    yield return entity;
                }
            }
        }

        public IEnumerable<T> Filter(FilterDelegate<T> filter)
        {
            foreach (var entity in Entities)
            {
                if (filter.Invoke(entity))
                {
                    yield return entity;
                }
            }
        }
    }
}
