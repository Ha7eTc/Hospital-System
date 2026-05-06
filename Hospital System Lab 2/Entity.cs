using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public class Entity
    {
        public virtual string FileName { get; }
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
    }
}
