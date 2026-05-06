using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public sealed class Nurse: Person
    {
        public override string FileName => "Nurse.txt";
        public string? Departament {  get; set; }
        public Nurse() 
        {
            Departament = string.Empty;
        }
        public Nurse(Guid id, string firstname, string lastname, string email, string departament) 
            : base(id, firstname, lastname, email)
        {
            Departament = departament;
        }

        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(Departament);
        }
        public sealed override string Format()
        {
            return $"{base.Format()}[{Departament}]";
        }
        public void Parse(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

            if (parts.Length != 5)
            {
                throw new FormatException("Invalid record format.");
            }

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                throw new FormatException("Invalid ID format.");
            }

            Id = id;
            FirstName = parts[1];
            LastName = parts[2];
            Email = parts[3];
            Departament = parts[4];
        }
    }
}
