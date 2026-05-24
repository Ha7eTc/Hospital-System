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
        public TimeSpan? DurationOfWork { get; set; }
        public List<Doctor>? Doctors { get; set; }
        public List<Patient>? Patients { get; set; }
        public List<Nurse>? Nurses { get; set; }

        public Hospital()
        {
            Name = string.Empty;
            Address = string.Empty;
            Description = string.Empty;
            DurationOfWork = TimeSpan.Zero;
            Doctors = new List<Doctor>();
            Patients = new List<Patient>();
            Nurses = new List<Nurse>();
        }
        public Hospital(Guid id, string name, string address, string description,TimeSpan durationOfWork, List<Doctor> doctors, List<Patient> patients, List<Nurse> nurses = null)
            : base(id)
        {
            this.Name = name;
            this.Address = address;
            this.Description = description;
            this.DurationOfWork = durationOfWork;
            this.Doctors = doctors;
            this.Patients = patients;
            this.Nurses = nurses;
        }

        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Address) && !string.IsNullOrEmpty(Description)
                && DurationOfWork != null && Doctors?.Count > 0 && Patients?.Count > 0 && Nurses?.Count > 0;
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
            return $"{base.Format()}[{Name}][{Address}][{Description}][{DurationOfWork}][{DoctorsIdStr}][{PatientsIdStr}][{NursesIdStr}]";
        }

        public override void Parse(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

            if (parts.Length < 4)
            {
                throw new FormatException("Invalid hospital record format. Expected [Name][Address][Description][DurationOfWork].");
            }

            Id = Guid.Parse(parts[0]);
            Name = parts[1];
            Address = parts[2];
            Description = parts[3];

            if (parts.Length > 4 && TimeSpan.TryParse(parts[4], out TimeSpan duration))
                DurationOfWork = duration;
            else
                DurationOfWork = TimeSpan.Zero;

            Doctors?.Clear();
            Patients?.Clear();
            Nurses?.Clear();
        }

        public override bool Search(string stringSearch)
        {
            return Name!.Contains(stringSearch, StringComparison.OrdinalIgnoreCase) ||
                   Address!.Contains(stringSearch, StringComparison.OrdinalIgnoreCase) ||
                   Description!.Contains(stringSearch, StringComparison.OrdinalIgnoreCase);
        }

    }
    
}
