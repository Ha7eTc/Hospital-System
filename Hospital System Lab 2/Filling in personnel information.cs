using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_System_Lab_2
{
    public partial class FillingInPersonnelInformation : MaterialForm
    {
        public FillingInPersonnelInformation()
        {
            InitializeComponent();

            // Create a material theme manager and apply it to the form
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Define the color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue700,
                Primary.Blue100, Accent.LightBlue200,
                TextShade.WHITE

            );


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void addButtonPersInfo_Click(object sender, EventArgs e)
        {


            try
            {
                var firstName = textBoxFirstName.Text;

                var lastName = textBoxLastName.Text;

                var email = textBoxEmail.Text;

                var specialization = textBoxSpecialization.Text;

                var departament = textBoxDepartament.Text;

                var personalType = comboBoxPersType.Text;

                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please fill in the required fields: First Name, Last Name, Email.");
                    return;
                }

                using (var db = new PersonalContext())
                {
                    Person person;

                    if (personalType == "Doctor")
                    {
                        if (string.IsNullOrWhiteSpace(specialization))
                        {
                            MessageBox.Show("Specialization is required for a Doctor.");
                            return;
                        }
                        person = new Doctor(Guid.NewGuid(), firstName, lastName, email, specialization);
                    }
                    else if (personalType == "Nurse")
                    {
                        if (string.IsNullOrWhiteSpace(departament))
                        {
                            MessageBox.Show("Department is required for a Nurse.");
                            return;
                        }
                        person = new Nurse(Guid.NewGuid(), firstName, lastName, email, departament);
                    }
                    else
                    {
                        person = new Person(Guid.NewGuid(), firstName, lastName, email);
                    }

                    db.Persons.Add(person);
                    db.SaveChanges();
                }



                var item = new ListViewItem((listViewPersInfo.Items.Count + 1).ToString());
                item.SubItems.Add(firstName);
                item.SubItems.Add(lastName);
                item.SubItems.Add(email);
                item.SubItems.Add(specialization);

                item.SubItems.Add(departament);
                item.SubItems.Add(personalType);

                listViewPersInfo.Items.Add(item);


            }

            catch (Exception ex)
            {
                var message = ex.Message;
                if (ex.InnerException != null)
                    message += "\n\nInner Exception:\n" + ex.InnerException.Message;
                MessageBox.Show(message);
            }

        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            using (var db = new PersonalContext())
            {
                var allPersons = db.Persons.ToList();


                listViewPersInfo.Items.Clear();

                foreach (var person in allPersons)
                {
                    var item = new ListViewItem((listViewPersInfo.Items.Count + 1).ToString());
                    item.SubItems.Add(person.FirstName);
                    item.SubItems.Add(person.LastName);
                    item.SubItems.Add(person.Email);
                    listViewPersInfo.Items.Add(item);
                }
            }
        }

        private void buttonGetAllDoctors_Click(object sender, EventArgs e)
        {
            using (var db = new PersonalContext())
            {
                var allDoctors = db.Persons.OfType<Doctor>().ToList();
                listViewPersInfo.Items.Clear();

                foreach (var doctor in allDoctors)
                {
                    var item = new ListViewItem((listViewPersInfo.Items.Count + 1).ToString());
                    item.SubItems.Add(doctor.FirstName);
                    item.SubItems.Add(doctor.LastName);
                    item.SubItems.Add(doctor.Email);
                    item.SubItems.Add(doctor.Specialization);
                    listViewPersInfo.Items.Add(item);
                }
            }
        }


        private void buttonGetAllNurses_Click(object sender, EventArgs e)
        {
            using (var db = new PersonalContext())
            {
                var allNurses = db.Persons.OfType<Nurse>().ToList();
                listViewPersInfo.Items.Clear();

                foreach (var nurse in allNurses)
                {
                    var item = new ListViewItem((listViewPersInfo.Items.Count + 1).ToString());
                    item.SubItems.Add(nurse.FirstName);
                    item.SubItems.Add(nurse.LastName);
                    item.SubItems.Add(nurse.Email);
                    item.SubItems.Add(nurse.Departament);
                    listViewPersInfo.Items.Add(item);
                }
            }
        }


        private void buttonSortPersInfo_Click(object sender, EventArgs e)
        {
            using (var db = new PersonalContext())
            {
                var sortedByLastName = db.Persons
                .OrderBy(p => p.LastName)
                .ToList();
                listViewPersInfo.Items.Clear();

                foreach (var person in sortedByLastName)
                {
                    var item = new ListViewItem((listViewPersInfo.Items.Count + 1).ToString());
                    item.SubItems.Add(person.FirstName);
                    item.SubItems.Add(person.LastName);
                    item.SubItems.Add(person.Email);
                    listViewPersInfo.Items.Add(item);
                }
            }
        }
    }
}
