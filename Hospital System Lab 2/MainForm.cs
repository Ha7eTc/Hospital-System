using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Globalization;

namespace Hospital_System_Lab_2
{
    public partial class MainForm : MaterialForm
    {
        private readonly DataManager<Hospital> dataManager;

        private const int PAGE_LIMIT = 5;
        private int currentPage = 0;

        public MainForm()
        {
            InitializeComponent();
            dataManager = new DataManager<Hospital>();

            StatusLabel = new ToolStripStatusLabel();
            statusStrip1.Items.Add(StatusLabel);

            MainListView.SelectedIndexChanged += (sender, e) =>
            {
                if (MainListView.SelectedItems.Count > 0)
                {
                    var index = MainListView.SelectedIndices[0];
                    var hospital = dataManager.Entities.ElementAt(index);
                    StatusLabel.Text = hospital.Format();
                }
            };

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


            var hospitals = FileManager.GetEntities<Hospital>("Hospital.txt");


            var ordered = hospitals
               .OrderBy(x => x.Name);

            ordered.ToList().ForEach(e => dataManager.Add(e));

            hospitals = ordered.Paginate(currentPage, PAGE_LIMIT);
            foreach (var hospital in hospitals)
            {
                dataManager.Add(hospital);
                var item = new ListViewItem(MainListView.Items.Count + 1 + "");
                item.SubItems.Add(hospital.Name);
                item.SubItems.Add(hospital.Description);
                item.SubItems.Add(hospital.Address);
                item.SubItems.Add(hospital.DurationOfWork.ToString());
                item.SubItems.Add(hospital.Doctors.Count.ToString());
                item.SubItems.Add(hospital.Patients.Count.ToString());
                item.SubItems.Add(hospital.Nurses.Count.ToString());

                MainListView.Items.Add(item);
            }
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            durationFromTextBox = new TextBox();
            durationToTextBox = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            filterButton = new Button();
            statusStrip1 = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            sortBtn = new Button();
            prevBtn = new Button();
            nextBtn = new Button();
            pageNumTextBox = new TextBox();
            btnToStaff = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainListView
            // 
            MainListView.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1, columnHeader7, columnHeader3, columnHeader8, columnHeader4, columnHeader5, columnHeader6 });
            MainListView.Location = new Point(12, 230);
            MainListView.Name = "MainListView";
            MainListView.Size = new Size(1372, 221);
            MainListView.TabIndex = 0;
            MainListView.UseCompatibleStateImageBehavior = false;
            MainListView.View = View.Details;
            MainListView.SelectedIndexChanged += MainListView_SelectedIndexChanged;
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
            textBox1.Location = new Point(23, 520);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 66);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 497);
            label1.MaximumSize = new Size(100, 100);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(661, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 27);
            textBox2.TabIndex = 3;
            // 
            // add_button
            // 
            add_button.BackColor = SystemColors.ActiveCaption;
            add_button.BackgroundImageLayout = ImageLayout.None;
            add_button.Location = new Point(23, 607);
            add_button.Name = "add_button";
            add_button.Size = new Size(94, 46);
            add_button.TabIndex = 4;
            add_button.Text = "ADD";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += Add_Button;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(289, 520);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 66);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 502);
            label2.MaximumSize = new Size(100, 100);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Address";
            label2.Click += label2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(567, 520);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(233, 66);
            textBox4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(567, 497);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 8;
            label3.Text = "Discription";
            // 
            // SearchListView
            // 
            SearchListView.Location = new Point(23, 100);
            SearchListView.Multiline = true;
            SearchListView.Name = "SearchListView";
            SearchListView.Size = new Size(208, 49);
            SearchListView.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 77);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 10;
            label4.Text = "Search";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 66);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 13;
            label5.Text = "Hospital operation hours";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 96);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 14;
            label6.Text = "From";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(567, 95);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 15;
            label7.Text = "To";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(546, 132);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 16;
            label8.Text = "-";
            // 
            // durationFromTextBox
            // 
            durationFromTextBox.Location = new Point(430, 118);
            durationFromTextBox.Multiline = true;
            durationFromTextBox.Name = "durationFromTextBox";
            durationFromTextBox.Size = new Size(110, 39);
            durationFromTextBox.TabIndex = 17;
            // 
            // durationToTextBox
            // 
            durationToTextBox.Location = new Point(567, 118);
            durationToTextBox.Multiline = true;
            durationToTextBox.Name = "durationToTextBox";
            durationToTextBox.Size = new Size(125, 39);
            durationToTextBox.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(822, 520);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(233, 66);
            textBox7.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(822, 497);
            label9.Name = "label9";
            label9.Size = new Size(174, 20);
            label9.TabIndex = 20;
            label9.Text = "Hospital operation hours";
            // 
            // filterButton
            // 
            filterButton.BackColor = SystemColors.ActiveCaption;
            filterButton.Location = new Point(430, 159);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(73, 48);
            filterButton.TabIndex = 21;
            filterButton.Text = "Search";
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel });
            statusStrip1.Location = new Point(0, 735);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1396, 26);
            statusStrip1.TabIndex = 22;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(52, 20);
            StatusLabel.Text = "Status:";
            StatusLabel.Click += StatusLabel_Click;
            // 
            // sortBtn
            // 
            sortBtn.BackColor = SystemColors.ActiveCaption;
            sortBtn.Location = new Point(624, 160);
            sortBtn.Name = "sortBtn";
            sortBtn.Size = new Size(68, 46);
            sortBtn.TabIndex = 23;
            sortBtn.Text = "Sort";
            sortBtn.UseVisualStyleBackColor = false;
            sortBtn.Click += sortBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.BackColor = SystemColors.ActiveCaption;
            prevBtn.Location = new Point(23, 165);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(69, 36);
            prevBtn.TabIndex = 24;
            prevBtn.Text = "PREV";
            prevBtn.UseVisualStyleBackColor = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.BackColor = SystemColors.ActiveCaption;
            nextBtn.Location = new Point(137, 165);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(71, 36);
            nextBtn.TabIndex = 25;
            nextBtn.Text = "NEXT";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // pageNumTextBox
            // 
            pageNumTextBox.Location = new Point(98, 170);
            pageNumTextBox.Name = "pageNumTextBox";
            pageNumTextBox.ReadOnly = true;
            pageNumTextBox.Size = new Size(33, 27);
            pageNumTextBox.TabIndex = 26;
            pageNumTextBox.Text = "1";
            pageNumTextBox.TextAlign = HorizontalAlignment.Center;
            pageNumTextBox.TextChanged += textBox5_TextChanged;
            // 
            // btnToStaff
            // 
            btnToStaff.BackColor = SystemColors.ActiveCaption;
            btnToStaff.Location = new Point(1179, 520);
            btnToStaff.Name = "btnToStaff";
            btnToStaff.Size = new Size(117, 59);
            btnToStaff.TabIndex = 27;
            btnToStaff.Text = "Go to staff";
            btnToStaff.UseVisualStyleBackColor = false;
            btnToStaff.Click += button1_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(1396, 761);
            Controls.Add(btnToStaff);
            Controls.Add(pageNumTextBox);
            Controls.Add(nextBtn);
            Controls.Add(prevBtn);
            Controls.Add(sortBtn);
            Controls.Add(statusStrip1);
            Controls.Add(filterButton);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(durationToTextBox);
            Controls.Add(durationFromTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
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
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
                dataManager.Add(hospital);

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


        //private void SearchButtonClick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!dataManager.Entities.Any())
        //        {
        //            return;
        //        }

        //        MainListView.Items.Clear();

        //        IEnumerable<IEntity> foundEntities = new List<IEntity>();
        //        if (string.IsNullOrEmpty(SearchListView.Text))
        //        {
        //            foundEntities = dataManager.Entities;
        //        }
        //        else
        //        {
        //            foundEntities = dataManager.Search(SearchListView.Text);
        //        }

        //        foreach (IEntity entity in foundEntities)
        //        {

        //            var hospitalEntity = entity as Hospital;

        //            if (hospitalEntity != null)
        //            {
        //                var item = new ListViewItem(MainListView.Items.Count + 1 + "");
        //                item.SubItems.Add(hospitalEntity.Name);
        //                item.SubItems.Add(hospitalEntity.Description);
        //                item.SubItems.Add(hospitalEntity.Address);
        //                item.SubItems.Add(textBox7.Text);
        //                item.SubItems.Add("0");
        //                item.SubItems.Add("0");
        //                item.SubItems.Add("0");

        //                MainListView.Items.Add(item);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
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

                if (!dataManager.Entities.Any())
                {
                    return;
                }

                MainListView.Items.Clear();

                IEnumerable<Hospital> foundEntities = new List<Hospital>();
                if (string.IsNullOrEmpty(durationFromTextBox.Text) &&
                    string.IsNullOrEmpty(durationToTextBox.Text) &&
                    string.IsNullOrEmpty(SearchListView.Text))
                {
                    foundEntities = dataManager.Entities
                         .OrderBy(x => x.Name)
                         .Paginate(currentPage, PAGE_LIMIT);
                }
                else
                {
                    TimeSpan? durationFrom = null;
                    if (TimeSpan.TryParse(durationFromTextBox.Text, out var durationFromResult))
                        durationFrom = durationFromResult;

                    TimeSpan? durationTo = null;
                    if (TimeSpan.TryParse(durationToTextBox.Text, out var durationToResult))
                        durationTo = durationToResult;


                    foundEntities = dataManager.Entities
                     .Where(e => (string.IsNullOrEmpty(SearchListView.Text) || e.Search(SearchListView.Text)) &&
                                 (durationFrom == null || durationTo == null ||
                                 (e.DurationOfWork >= durationFrom && e.DurationOfWork <= durationTo)))
                     .OrderBy(x => x.Name)
                     .Paginate(currentPage, PAGE_LIMIT);

                }

                foundEntities.ToList().ForEach(e =>
                {
                    var item = new ListViewItem(MainListView.Items.Count + 1 + "");
                    item.SubItems.Add(e.Name);
                    item.SubItems.Add(e.Description);
                    item.SubItems.Add(e.Address);
                    item.SubItems.Add(e.DurationOfWork != null
                        ? e.DurationOfWork.Value.ToString()
                        : string.Empty);
                    item.SubItems.Add("0");
                    item.SubItems.Add("0");
                    item.SubItems.Add("0");

                    MainListView.Items.Add(item);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //filter
        //private bool FilterHospitalByDurationOfWork(IEntity entity)
        //{
        //    TimeSpan? durationFrom = null;
        //    if (TimeSpan.TryParse(durationFromTextBox.Text, out var durationFromResult))
        //        durationFrom = durationFromResult;

        //    TimeSpan? durationTo = null;
        //    if (TimeSpan.TryParse(durationToTextBox.Text, out var durationToResult))
        //        durationTo = durationToResult;

        //    var hospital = entity as Hospital;
        //    if (hospital != null && hospital.DurationOfWork != null && durationFrom != null && durationTo != null)
        //    {
        //        return hospital.DurationOfWork >= durationFrom && hospital.DurationOfWork <= durationTo;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        private StatusStrip statusStrip1;

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private ToolStripStatusLabel StatusLabel;

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Button sortBtn;



        private void sortBtn_Click(object sender, EventArgs e)
        {
            // Remove all items from the list to fill the list view only with found items
            MainListView.Items.Clear();

            var hospitals = dataManager.Entities
                .OrderBy(x => x.Name);

            foreach (var hospital in hospitals)
            {
                var item = new ListViewItem(MainListView.Items.Count + 1 + "");
                item.SubItems.Add(hospital.Name);
                item.SubItems.Add(hospital.Description);
                item.SubItems.Add(hospital.Address);
                item.SubItems.Add(hospital.DurationOfWork.ToString());
                item.SubItems.Add(hospital.Doctors.Count.ToString());
                item.SubItems.Add(hospital.Patients.Count.ToString());
                item.SubItems.Add(hospital.Nurses.Count.ToString());

                MainListView.Items.Add(item);
            }
        }


        private void hospitalListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure an item is selected
            if (MainListView.SelectedItems.Count > 0)
            {
                // Get the selected index
                int selectedIndex = MainListView.SelectedIndices[0];

                // Get the selected item's text
                string selectedItemText = MainListView.SelectedItems[0].SubItems[7].Text;

                // Hospital to the Guid
                var id = Guid.Parse(selectedItemText);

                // Get only several fields of Hospital to display using LINQ
                var data = dataManager.Entities
                    .Where(x => x.Id == id)
                    .Select(x => x.Name + " " + x.Description + " " + x.DurationOfWork.ToString())
                    .FirstOrDefault();

                if (!string.IsNullOrEmpty(data))
                {
                    statusStrip1.Text = data;
                }
            }
        }
        private Button prevBtn;
        private Button nextBtn;
        private TextBox pageNumTextBox;

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void Paginate()
        {
            MainListView.Items.Clear();

            var data = dataManager.Entities
                .OrderBy(x => x.Name)
                .Skip(currentPage * PAGE_LIMIT)    //replace in future
                .Take(PAGE_LIMIT)
                .ToList();

            data.ForEach(e =>
            {
                var item = new ListViewItem(MainListView.Items.Count + 1 + "");
                item.SubItems.Add(e.Name);
                item.SubItems.Add(e.Description);
                item.SubItems.Add(e.Address);
                item.SubItems.Add(e.DurationOfWork.ToString());
                item.SubItems.Add(e.Doctors.Count.ToString());
                item.SubItems.Add(e.Patients.Count.ToString());
                item.SubItems.Add(e.Nurses.Count.ToString());

                MainListView.Items.Add(item);
            });

            this.pageNumTextBox.Text = (currentPage + 1).ToString();
        }


        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 0 && dataManager.Entities.Any())
            {
                currentPage--;
                Paginate();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < dataManager.Entities.Count() / PAGE_LIMIT && dataManager.Entities.Any())
            {
                currentPage++;
                Paginate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fillingInPersonnelInformation = new FillingInPersonnelInformation();
            fillingInPersonnelInformation.Show();
        }
    }
}
