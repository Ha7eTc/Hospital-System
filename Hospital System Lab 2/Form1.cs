using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Entity entity = new Hospital(); 
            MessageBox.Show(entity.IsValid().ToString());
        }

        //private void InitializeComponent()
        //{
        //    SuspendLayout();
        //    // 
        //    // Form1
        //    // 
        //    ClientSize = new Size(282, 253);
        //    Name = "Form1";
        //    ResumeLayout(false);

        //}
    }
}
