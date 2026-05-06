using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public class Treatment : Patient
    {
        public override string FileName => "Treatment.txt";
        public string? TreatmentName { get; set; }
        private decimal? treatmentprice;
        public decimal? TreatmentPrice {

            get { return treatmentprice; }
            set { if (value < 0)
                {
                    treatmentprice = 0;
                }
                else
                {
                    treatmentprice = value;
                }
            }
        }

        public Treatment()
        {
            TreatmentName = string.Empty;
            TreatmentPrice = 0m;
        }
        public Treatment(Guid id, string firstname, string lastname, string email, string phone, string treatmentname, decimal treatmentprice)
            : base(id, firstname, lastname, email, phone)
        {
            TreatmentName = treatmentname;
            TreatmentPrice = treatmentprice;
        }

        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(TreatmentName) && TreatmentPrice > 0;
        }
        public override string Format()
        {
            return $"{base.Format()}[{TreatmentName}][{TreatmentPrice}]";
        }

        public override void Parse(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

            if (parts.Length != 7)
            {
                throw new FormatException("Invalid record format.");
            }

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                throw new FormatException("Invalid ID format.");
            }

            if (!decimal.TryParse(parts[6], out decimal price))
            {
                throw new FormatException("Invalid TreatmentPrice format. Expected a number.");
            }
            TreatmentPrice = price;

            Id = id;
            FirstName = parts[1];
            LastName = parts[2];
            Email = parts[3];
            Phone = parts[4];
            TreatmentName = parts[5];
            TreatmentPrice = price;

        }
    }
}
