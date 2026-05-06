using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public class Hospital : Entity, IEntity
    {
        public override string FileName => "Hospital.txt";

        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public List<Doctor>? Doctors { get; set; }
        public List<Patient>? Patients { get; set; }
        public List<Nurse>? Nurses { get; set; }

        public Hospital()
        {
            Name = string.Empty;
            Address = string.Empty;
            Description = string.Empty;
            Doctors = new List<Doctor>();
            Patients = new List<Patient>();
            Nurses = new List<Nurse>();
        }
        public Hospital(Guid id, string name, string address, string description, List<Doctor> doctors, List<Patient> patients, List<Nurse> nurses = null)
            : base(id)
        {
            this.Name = name;
            this.Address = address;
            this.Description = description;
            this.Doctors = doctors;
            this.Patients = patients;
            this.Nurses = nurses;
        }

        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Address) && !string.IsNullOrEmpty(Description)
                && Doctors?.Count > 0
                && Patients?.Count > 0 && Nurses?.Count > 0;
        }

        public override string Format()
        {
            var DoctorsId = new List<string>();
            foreach (var doctor in Doctors)
            {
                DoctorsId.Add(doctor.Id.ToString());
            }
            var PatientsId = new List<string>();
            foreach (var patient in Patients)
            {
                PatientsId.Add(patient.Id.ToString());
            }
            var NursesId = new List<string>();
            foreach (var nurse in Nurses)
            {
                NursesId.Add(nurse.Id.ToString());
            }
            var DoctorsIdStr = string.Join(", ", DoctorsId);
            var PatientsIdStr = string.Join(", ", PatientsId);
            var NursesIdStr = string.Join(", ", NursesId);
            return $"{base.Format()}[{Name}][{Address}][{Description}][{DoctorsIdStr}][{PatientsIdStr}][{NursesIdStr}]";
        }

        public virtual void Parse(string record)
        {
            // 1. Стандартна перевірка на порожнечу
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            // 2. Розбиваємо рядок. Очікуємо 2 частини: Назва та Адреса
            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

            // 3. Перевірка формату (мінімум 2 поля)
            if (parts.Length < 3)
            {
                throw new FormatException("Invalid hospital record format. Expected [Name][Address][Description].");
            }

            // 4. Присвоєння значень
            Name = parts[0];
            Address = parts[1];
            Description = parts[2];

            // 5. Очищуємо списки перед новим заповненням (опціонально)
            Doctors?.Clear();
            Patients?.Clear();
            Nurses?.Clear();
        }

        public bool Search(string stringSearch)
        {
            return Name!.Contains(stringSearch, StringComparison.OrdinalIgnoreCase) ||
                   Address!.Contains(stringSearch, StringComparison.OrdinalIgnoreCase) ||
                   Description!.Contains(stringSearch, StringComparison.OrdinalIgnoreCase);
        }

    }
    
}
