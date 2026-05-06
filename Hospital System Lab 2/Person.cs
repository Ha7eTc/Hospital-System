using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public class Person : Entity, IEntity
    {
        public override string FileName => "Person.txt";

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public Person()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
        }
        public Person(Guid id, string firstname, string lastname, string email) : base(id)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
        }

        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName)
                && !string.IsNullOrEmpty(Email);
        }

        public override string Format()
        {
            return $"{base.Format()}[{FirstName}][{LastName}][{Email}]";
        }
        public virtual void Parse(string record)
        {
            // 1. Перевірка на пустий рядок
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            // 2. Очищення від крайніх дужок та розділення по комбінації ][
            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

            // 3. Перевірка кількості отриманих елементів (має бути 4)
            if (parts.Length != 4)
            {
                throw new FormatException("Invalid record format.");
            }

            // 4. Спроба перетворити перший елемент у формат Guid (унікальний ID)
            if (!Guid.TryParse(parts[0], out Guid id))
            {
                throw new FormatException("Invalid ID format.");
            }

            // 5. Присвоєння значень властивостям об'єкта
            Id = id;
            FirstName = parts[1];
            LastName = parts[2];
            Email = parts[3];



        }
        public bool Search(string stringSearch)
        {
            return FirstName!.Contains(stringSearch, StringComparison.OrdinalIgnoreCase) ||
                   LastName!.Contains(stringSearch, StringComparison.OrdinalIgnoreCase ) ||
                   Email!.Contains(stringSearch, StringComparison.OrdinalIgnoreCase);
        }
    }
}