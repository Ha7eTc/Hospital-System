using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public static class DataManager
    {
        public static IEnumerable<IEntity> Entities { get; private set; } = new List<IEntity>();
        public static void Add(IEntity entity)
        {
            Entities = Entities.Append(entity);
        }

        public static IEnumerable<IEntity> Search(string searchString)
        {
            foreach (var entity in Entities)
            {
                if (entity.Search(searchString))
                {
                    yield return entity;
                }
            }
        }

        public static IEnumerable<IEntity> Filter(FilterDelegate filter)
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
