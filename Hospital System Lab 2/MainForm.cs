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
            columnHeader8 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            add_button = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            SearchListView = new TextBox();
            label4 = new Label();
            SearchClickButton = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            durationFromTextBox = new TextBox();
            durationToTextBox = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            filterButton = new Button();
            SuspendLayout();
            // 
            // MainListView
            // 
            MainListView.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1, columnHeader7, columnHeader3, columnHeader8, columnHeader4, columnHeader5, columnHeader6 });
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
            // columnHeader8
            // 
            columnHeader8.Text = "Hospital operation hours";
            columnHeader8.Width = 200;
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
            // add_button
            // 
            add_button.BackColor = SystemColors.ActiveCaption;
            add_button.BackgroundImageLayout = ImageLayout.None;
            add_button.Location = new Point(1120, 661);
            add_button.Name = "add_button";
            add_button.Size = new Size(94, 46);
            add_button.TabIndex = 4;
            add_button.Text = "ADD";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += Add_Button;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1120, 589);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 66);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1120, 566);
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
            textBox4.Size = new Size(233, 114);
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
            SearchClickButton.Text = "search";
            SearchClickButton.UseVisualStyleBackColor = false;
            SearchClickButton.Click += SearchButtonClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(578, 65);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 13;
            label5.Text = "Hospital operation hours";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(579, 96);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 14;
            label6.Text = "From";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(725, 96);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 15;
            label7.Text = "To";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(704, 133);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 16;
            label8.Text = "-";
            // 
            // durationFromTextBox
            // 
            durationFromTextBox.Location = new Point(579, 119);
            durationFromTextBox.Multiline = true;
            durationFromTextBox.Name = "durationFromTextBox";
            durationFromTextBox.Size = new Size(110, 49);
            durationFromTextBox.TabIndex = 17;
            // 
            // durationToTextBox
            // 
            durationToTextBox.Location = new Point(725, 119);
            durationToTextBox.Multiline = true;
            durationToTextBox.Name = "durationToTextBox";
            durationToTextBox.Size = new Size(125, 48);
            durationToTextBox.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1120, 477);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(233, 66);
            textBox7.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1120, 454);
            label9.Name = "label9";
            label9.Size = new Size(174, 20);
            label9.TabIndex = 20;
            label9.Text = "Hospital operation hours";
            // 
            // filterButton
            // 
            filterButton.BackColor = SystemColors.ActiveCaption;
            filterButton.Location = new Point(870, 119);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(73, 48);
            filterButton.TabIndex = 21;
            filterButton.Text = "search";
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(1396, 761);
            Controls.Add(filterButton);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(durationToTextBox);
            Controls.Add(durationFromTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(SearchClickButton);
            Controls.Add(label4);
            Controls.Add(SearchListView);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(add_button);
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
        private Button add_button;

        private void Add_Button(object sender, EventArgs e)
        {
            try
            {
                var name = textBox1.Text;

                var address = textBox3.Text;

                var discription = textBox4.Text;

                TimeSpan durationOfWork = TimeSpan.Zero;
                if (TimeSpan.TryParse(textBox7.Text, out var durationResult))
                    durationOfWork = durationResult;

                var id = Guid.NewGuid();

                var hospital = new Hospital(
                    id,
                    name,
                    address,
                    discription,
                    durationOfWork,
                    new List<Doctor>(),
                    new List<Patient>(),
                    new List<Nurse>()
                );

                FileManager.Add(hospital);
                DataManager.Add(hospital);

                var item = new ListViewItem((MainListView.Items.Count + 1).ToString());

                item.SubItems.Add(name);
                item.SubItems.Add(discription);
                item.SubItems.Add(address);
                item.SubItems.Add(textBox7.Text);

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
                // якщо немаЇ жодноњ сутност≥ Ч не виконуЇмо пошук ≥ виходимо з методу
                if (!DataManager.Entities.Any())
                {
                    return;
                }

                // ќчищаЇмо список перед заповненн€м знайденими елементами
                MainListView.Items.Clear();

                IEnumerable<IEntity> foundEntities = new List<IEntity>();
                if (string.IsNullOrEmpty(SearchListView.Text))
                {
                    // якщо поле пошуку порожнЇ Ч завантажуЇмо вс≥ концерти
                    foundEntities = DataManager.Entities;
                }
                else
                {
                    // ≤накше Ч виконуЇмо пошук по списку концерт≥в
                    // DataManager шукаЇ елементи у списку DataManager.Entities,
                    // до €кого ми додавали елементи у обробнику addRecordBtn_Click
                    foundEntities = DataManager.Search(SearchListView.Text);
                }

                foreach (IEntity entity in foundEntities)
                {
                    //  астуЇмо IEntity до типу Concert, щоб отримати вс≥ потр≥бн≥ дан≥
                    // ƒо касту IEntity мав лише властив≥сть Id, але нам потр≥бн≥ Name та ≥нш≥
                    //  аст можливий, бо Concert реал≥зуЇ ≥нтерфейс IEntity
                    var hospitalEntity = entity as Hospital;

                    // якщо каст усп≥шний Ч заповнюЇмо listView знайденими концертами
                    if (hospitalEntity != null)
                    {
                        var item = new ListViewItem(MainListView.Items.Count + 1 + "");
                        item.SubItems.Add(hospitalEntity.Name);
                        item.SubItems.Add(hospitalEntity.Description);
                        item.SubItems.Add(hospitalEntity.Address);
                        item.SubItems.Add(textBox7.Text);
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
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ColumnHeader columnHeader8;
        private TextBox durationFromTextBox;
        private TextBox durationToTextBox;
        private TextBox textBox7;
        private Label label9;
        private Button filterButton;



        private void filterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DataManager.Entities.Any())
                {
                    return;
                }

                MainListView.Items.Clear();

                IEnumerable<IEntity> filteredEntities = new List<IEntity>();
                if (string.IsNullOrEmpty(durationFromTextBox.Text) || string.IsNullOrEmpty(durationToTextBox.Text))
                {
                    filteredEntities = DataManager.Entities;
                }
                else
                {
                    filteredEntities = DataManager.Filter(entity =>
                    {
                        TimeSpan? durationFrom = null;
                        if (TimeSpan.TryParse(durationFromTextBox.Text, out var durationFromResult))
                            durationFrom = durationFromResult;

                        TimeSpan? durationTo = null;
                        if (TimeSpan.TryParse(durationToTextBox.Text, out var durationToResult))
                            durationTo = durationToResult;

                        var hospital = entity as Hospital;
                        if (hospital != null && hospital.DurationOfWork != null && durationFrom != null && durationTo != null)
                        {
                            return hospital.DurationOfWork >= durationFrom && hospital.DurationOfWork <= durationTo;
                        }
                        else
                        {
                            return false;
                        }
                    });

                    foreach (IEntity entity in filteredEntities)
                    {
                        if (entity is Hospital hospitalEntity)
                        {
                            var item = new ListViewItem(MainListView.Items.Count + 1 + "");
                            item.SubItems.Add(hospitalEntity.Name);
                            item.SubItems.Add(hospitalEntity.Description);
                            item.SubItems.Add(hospitalEntity.Address);
                            item.SubItems.Add(hospitalEntity.DurationOfWork != null
                                ? hospitalEntity.DurationOfWork.Value.ToString()
                                : string.Empty);
                            item.SubItems.Add("0");
                            item.SubItems.Add("0");
                            item.SubItems.Add("0");

                            MainListView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //filter
        private bool FilterHospitalByDurationOfWork(IEntity entity)
        {
            TimeSpan? durationFrom = null;
            if (TimeSpan.TryParse(durationFromTextBox.Text, out var durationFromResult))
                durationFrom = durationFromResult;

            TimeSpan? durationTo = null;
            if (TimeSpan.TryParse(durationToTextBox.Text, out var durationToResult))
                durationTo = durationToResult;

            var hospital = entity as Hospital;
            if (hospital != null && hospital.DurationOfWork != null && durationFrom != null && durationTo != null)
            {
                return hospital.DurationOfWork >= durationFrom && hospital.DurationOfWork <= durationTo;
            }
            else
            {
                return false;
            }
        }
    }
}
