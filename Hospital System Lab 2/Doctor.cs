using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public sealed class Doctor : Person
    {
        [NotMapped]
        public override string FileName => "Doctor.txt";
        [MaxLength(100)]
        public string? Specialization { get; set; }
        public Doctor()
        {
            Specialization = string.Empty;
        }
        public Doctor(Guid id, string firstname, string lastname, string email, string specialization)
            : base(id, firstname, lastname, email)
        {
            Specialization = specialization;
        }

        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(Specialization);
        }

        public sealed override string Format()
        {
            return $"{base.Format()}[{Specialization}]";
        }
        public override void Parse(string record)
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
            Specialization = parts[4];
        }
    }
}
