namespace Hospital_System_Lab_2
{
    partial class FillingInPersonnelInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 




        private void InitializeComponent()
        {
            listViewPersInfo = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            textBoxFirstName = new TextBox();
            label1 = new Label();
            textBoxLastName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxEmail = new TextBox();
            textBoxSpecialization = new TextBox();
            textBoxDepartament = new TextBox();
            label6 = new Label();
            addButtonPersInfo = new Button();
            comboBoxPersType = new ComboBox();
            buttonGetAll = new Button();
            buttonGetAllDoctors = new Button();
            buttonGetAllNurses = new Button();
            buttonSortPersInfo = new Button();
            SuspendLayout();
            // 
            // listViewPersInfo
            // 
            listViewPersInfo.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listViewPersInfo.Location = new Point(483, 178);
            listViewPersInfo.Name = "listViewPersInfo";
            listViewPersInfo.Size = new Size(654, 282);
            listViewPersInfo.TabIndex = 1;
            listViewPersInfo.UseCompatibleStateImageBehavior = false;
            listViewPersInfo.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "#";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "First Name";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Last Name";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Specialization";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Departament";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Personal Type";
            columnHeader7.Width = 120;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(33, 159);
            textBoxFirstName.Multiline = true;
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(125, 44);
            textBoxFirstName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 136);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(33, 245);
            textBoxLastName.Multiline = true;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(125, 44);
            textBoxLastName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 222);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 306);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 220);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 7;
            label4.Text = "Specialization";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 306);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 8;
            label5.Text = "Departament";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(33, 329);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 44);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxSpecialization
            // 
            textBoxSpecialization.Location = new Point(231, 243);
            textBoxSpecialization.Multiline = true;
            textBoxSpecialization.Name = "textBoxSpecialization";
            textBoxSpecialization.Size = new Size(125, 44);
            textBoxSpecialization.TabIndex = 10;
            // 
            // textBoxDepartament
            // 
            textBoxDepartament.Location = new Point(231, 329);
            textBoxDepartament.Multiline = true;
            textBoxDepartament.Name = "textBoxDepartament";
            textBoxDepartament.Size = new Size(125, 44);
            textBoxDepartament.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 136);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 13;
            label6.Text = "Personal Type";
            label6.Click += label6_Click;
            // 
            // addButtonPersInfo
            // 
            addButtonPersInfo.BackColor = SystemColors.ActiveCaption;
            addButtonPersInfo.Location = new Point(146, 391);
            addButtonPersInfo.Name = "addButtonPersInfo";
            addButtonPersInfo.Size = new Size(94, 50);
            addButtonPersInfo.TabIndex = 14;
            addButtonPersInfo.Text = "ADD";
            addButtonPersInfo.UseVisualStyleBackColor = false;
            addButtonPersInfo.Click += addButtonPersInfo_Click;
            // 
            // comboBoxPersType
            // 
            comboBoxPersType.DropDownHeight = 109;
            comboBoxPersType.FormattingEnabled = true;
            comboBoxPersType.IntegralHeight = false;
            comboBoxPersType.ItemHeight = 20;
            comboBoxPersType.Items.AddRange(new object[] { "Doctor", "Nurse" });
            comboBoxPersType.Location = new Point(231, 159);
            comboBoxPersType.Name = "comboBoxPersType";
            comboBoxPersType.Size = new Size(125, 28);
            comboBoxPersType.TabIndex = 15;
            // 
            // buttonGetAll
            // 
            buttonGetAll.BackColor = SystemColors.ActiveCaption;
            buttonGetAll.Location = new Point(483, 106);
            buttonGetAll.Name = "buttonGetAll";
            buttonGetAll.Size = new Size(94, 50);
            buttonGetAll.TabIndex = 16;
            buttonGetAll.Text = "Get all";
            buttonGetAll.UseVisualStyleBackColor = false;
            buttonGetAll.Click += buttonGetAll_Click;
            // 
            // buttonGetAllDoctors
            // 
            buttonGetAllDoctors.BackColor = SystemColors.ActiveCaption;
            buttonGetAllDoctors.Location = new Point(583, 106);
            buttonGetAllDoctors.Name = "buttonGetAllDoctors";
            buttonGetAllDoctors.Size = new Size(94, 50);
            buttonGetAllDoctors.TabIndex = 17;
            buttonGetAllDoctors.Text = "Get all doctors";
            buttonGetAllDoctors.UseVisualStyleBackColor = false;
            buttonGetAllDoctors.Click += buttonGetAllDoctors_Click;
            // 
            // buttonGetAllNurses
            // 
            buttonGetAllNurses.BackColor = SystemColors.ActiveCaption;
            buttonGetAllNurses.Location = new Point(683, 106);
            buttonGetAllNurses.Name = "buttonGetAllNurses";
            buttonGetAllNurses.Size = new Size(94, 50);
            buttonGetAllNurses.TabIndex = 18;
            buttonGetAllNurses.Text = "Get all nurses";
            buttonGetAllNurses.UseVisualStyleBackColor = false;
            buttonGetAllNurses.Click += buttonGetAllNurses_Click;
            // 
            // buttonSortPersInfo
            // 
            buttonSortPersInfo.BackColor = SystemColors.ActiveCaption;
            buttonSortPersInfo.Location = new Point(1043, 106);
            buttonSortPersInfo.Name = "buttonSortPersInfo";
            buttonSortPersInfo.Size = new Size(94, 50);
            buttonSortPersInfo.TabIndex = 19;
            buttonSortPersInfo.Text = "Sort";
            buttonSortPersInfo.UseVisualStyleBackColor = false;
            buttonSortPersInfo.Click += buttonSortPersInfo_Click;
            // 
            // FillingInPersonnelInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 546);
            Controls.Add(buttonSortPersInfo);
            Controls.Add(buttonGetAllNurses);
            Controls.Add(buttonGetAllDoctors);
            Controls.Add(buttonGetAll);
            Controls.Add(comboBoxPersType);
            Controls.Add(addButtonPersInfo);
            Controls.Add(label6);
            Controls.Add(textBoxDepartament);
            Controls.Add(textBoxSpecialization);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxLastName);
            Controls.Add(label1);
            Controls.Add(textBoxFirstName);
            Controls.Add(listViewPersInfo);
            Name = "FillingInPersonnelInformation";
            Text = "Filling In Personnel Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listViewPersInfo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox textBoxFirstName;
        private Label label1;
        private TextBox textBoxLastName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxEmail;
        private TextBox textBoxSpecialization;
        private TextBox textBoxDepartament;
        private Label label6;
        private Button addButtonPersInfo;
        private ComboBox comboBoxPersType;
        private ColumnHeader columnHeader7;
        private Button buttonGetAll;
        private Button buttonGetAllDoctors;
        private Button buttonGetAllNurses;
        private Button buttonSortPersInfo;
    }
}