using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Globalization;

namespace Hospital_System_Lab_2
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
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

        private void InitializeComponent()
        {
            MainListView = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            add = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            SearchListView = new TextBox();
            label4 = new Label();
            SearchClickButton = new Button();
            SuspendLayout();
            // 
            // MainListView
            // 
            MainListView.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1, columnHeader7, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            MainListView.Location = new Point(54, 181);
            MainListView.Name = "MainListView";
            MainListView.Size = new Size(1028, 526);
            MainListView.TabIndex = 0;
            MainListView.UseCompatibleStateImageBehavior = false;
            MainListView.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "#";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Discription";
            columnHeader7.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Address";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Doctors";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Patients";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nurses";
            columnHeader6.Width = 200;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1120, 194);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 66);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1120, 171);
            label1.MaximumSize = new Size(100, 100);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1152, 425);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 27);
            textBox2.TabIndex = 3;
            // 
            // add
            // 
            add.BackColor = SystemColors.ActiveCaption;
            add.BackgroundImageLayout = ImageLayout.None;
            add.Location = new Point(1120, 618);
            add.Name = "add";
            add.Size = new Size(94, 46);
            add.TabIndex = 4;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1120, 506);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 66);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1120, 483);
            label2.MaximumSize = new Size(100, 100);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Address";
            label2.Click += label2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1120, 313);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(233, 139);
            textBox4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1120, 290);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 8;
            label3.Text = "Discription";
            // 
            // SearchListView
            // 
            SearchListView.Location = new Point(54, 108);
            SearchListView.Multiline = true;
            SearchListView.Name = "SearchListView";
            SearchListView.Size = new Size(208, 49);
            SearchListView.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 85);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 10;
            label4.Text = "Search";
            // 
            // SearchClickButton
            // 
            SearchClickButton.BackColor = SystemColors.ActiveCaption;
            SearchClickButton.Location = new Point(282, 108);
            SearchClickButton.Name = "SearchClickButton";
            SearchClickButton.Size = new Size(71, 49);
            SearchClickButton.TabIndex = 12;
            SearchClickButton.Text = "lets go";
            SearchClickButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            ClientSize = new Size(1396, 761);
            Controls.Add(SearchClickButton);
            Controls.Add(label4);
            Controls.Add(SearchListView);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(add);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(MainListView);
            Name = "MainForm";
            Text = "Hospital System";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }
        private ListView MainListView;
        private TextBox textBox1;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label1;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private TextBox textBox2;

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private Button add;

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                var name = textBox1.Text;

                var address = textBox3.Text;

                var discription = textBox4.Text;

                var id = Guid.NewGuid();

                var hospital = new Hospital(
                    id,
                    name,
                    address,
                    discription,
                    new List<Doctor>(),
                    new List<Patient>(),
                    new List<Nurse>()
                );

                FileManager.Add(hospital);

                var item = new ListViewItem((MainListView.Items.Count + 1).ToString());

                item.SubItems.Add(name);
                item.SubItems.Add(discription);
                item.SubItems.Add(address);

                item.SubItems.Add(hospital.Doctors.Count.ToString());
                item.SubItems.Add(hospital.Patients.Count.ToString());
                item.SubItems.Add(hospital.Nurses.Count.ToString());

                MainListView.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private TextBox textBox3;
        private Label label2;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private TextBox textBox4;
        private Label label3;
        private TextBox SearchListView;
        private Label label4;
        private Button SearchClickButton;


        private void SearchButtonClick(object sender, EventArgs e)
        {
            try
            {
                // Якщо немає жодної сутності — не виконуємо пошук і виходимо з методу
                if (!DataManager.Entities.Any())
                {
                    return;
                }

                // Очищаємо список перед заповненням знайденими елементами
                MainListView.Items.Clear();

                IEnumerable<IEntity> foundEntities = new List<IEntity>();
                if (string.IsNullOrEmpty(SearchListView.Text))
                {
                    // Якщо поле пошуку порожнє — завантажуємо всі концерти
                    foundEntities = DataManager.Entities;
                }
                else
                {
                    // Інакше — виконуємо пошук по списку концертів
                    // DataManager шукає елементи у списку DataManager.Entities,
                    // до якого ми додавали елементи у обробнику addRecordBtn_Click
                    foundEntities = DataManager.Search(MainListView.Text);
                }

                foreach (IEntity entity in foundEntities)
                {
                    // Кастуємо IEntity до типу Concert, щоб отримати всі потрібні дані
                    // До касту IEntity мав лише властивість Id, але нам потрібні Name та інші
                    // Каст можливий, бо Concert реалізує інтерфейс IEntity
                    var hospitalEntity = entity as Hospital;

                    // Якщо каст успішний — заповнюємо listView знайденими концертами
                    if (hospitalEntity != null)
                    {
                        var item = new ListViewItem(MainListView.Items.Count + 1 + "");
                        item.SubItems.Add(hospitalEntity.Name);
                        item.SubItems.Add(hospitalEntity.Description);
                        item.SubItems.Add(hospitalEntity.Address);
                        item.SubItems.Add("0");
                        item.SubItems.Add("0");
                        item.SubItems.Add("0");

                        MainListView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var name = textBox1.Text;
                var address = textBox3.Text;

                var id = Guid.NewGuid();
                var concert = new Hospital(id, name, address, textBox4.Text, new List<Doctor>, new List<Patient>(), new List<Nurse>());

                // Записати у файл за допомогою методу WriteToFile класу FileManager
                FileManager.WriteToFile(Hospital);

                // Додати до колекції для подальшої роботи з даними за допомогою методу Add класу DataManager
                DataManager.Add(concert);

                var item = new ListViewItem(concertListView.Items.Count + 1 + "");
                item.SubItems.Add(name);
                item.SubItems.Add(descriptionTextBox.Text);
                item.SubItems.Add(durationTextBox.Text);
                item.SubItems.Add(startDateTime.ToString("dd/MM/yyyy hh:mm tt"));
                item.SubItems.Add("0");
                item.SubItems.Add("0");

                concertListView.Items.Add(item);
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }
    }
}
