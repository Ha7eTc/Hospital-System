using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public abstract class Entity: IEntity
    {
        public virtual string FileName { get; } = string.Empty;
        public Guid Id { get; set; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Entity(Guid id)
        {
            Id = id;
        }
        public bool IsValid()
        { 
            return Id != Guid.Empty;
        }

        public virtual string Format()
        {
            return "["+Id.ToString()+"]";
        }
        public abstract void Parse(string record);
        public abstract bool Search(string searchString);
    }
}
