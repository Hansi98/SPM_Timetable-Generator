using ABC_Institute___Timetable_Generator.ServiceImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Institute___Timetable_Generator
{
    public partial class Section1_Lecturers : Form

    {
        LecturerServiceImpl Lservice = new LecturerServiceImpl();
        public Section1_Lecturers()
        {
            InitializeComponent();
           
            draw();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void RS1_addLecturer_Click(object sender, EventArgs e)
        {
            new Section1_addLecturer().Show();
        }

        private void RS1_addLecturer_Click_1(object sender, EventArgs e)
        {
            new Section1_addLecturer().Show();
        }

        private void LecturerPortalbtnclose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void RS1_searchLec_TextChanged(object sender, EventArgs e)
        {
            if (RS1_searchLec.Text == null){
                MessageBox.Show("Show all Details");
            }
            else
            {
                MessageBox.Show("Show Search content");
            }
        }

        private void RS1_searchLec_MouseClick(object sender, MouseEventArgs e)
        {
            RS1_searchLec.Text = null;
        }

        public void R1S1changeHeader()
        {
            if (R1S1LecDataGrid.Columns["Eid"] != null)
                R1S1LecDataGrid.Columns["Eid"].HeaderText = "Employee ID";

            if (R1S1LecDataGrid.Columns["fname"] != null)
                R1S1LecDataGrid.Columns["fname"].HeaderText = "First Name";

            if (R1S1LecDataGrid.Columns["mname"] != null)
                R1S1LecDataGrid.Columns["mname"].HeaderText = "Middle Name";

            if (R1S1LecDataGrid.Columns["lname"] != null)
                R1S1LecDataGrid.Columns["lname"].HeaderText = "Last Name";
                 
            if (R1S1LecDataGrid.Columns["faculty"] != null)
                R1S1LecDataGrid.Columns["faculty"].HeaderText = "Faculty";

            if (R1S1LecDataGrid.Columns["dept"] != null)
                R1S1LecDataGrid.Columns["dept"].HeaderText = "Department";

            if (R1S1LecDataGrid.Columns["center"] != null)
                R1S1LecDataGrid.Columns["center"].HeaderText = "Center";

            if (R1S1LecDataGrid.Columns["building"] != null)
                R1S1LecDataGrid.Columns["building"].HeaderText = "Building";

            if (R1S1LecDataGrid.Columns["Llevel"] != null)
                R1S1LecDataGrid.Columns["Llevel"].HeaderText = "Level";
           
            if (R1S1LecDataGrid.Columns["Lrank"] != null)
                R1S1LecDataGrid.Columns["Lrank"].HeaderText = "Rank";
        }

        public void draw()
        {
            R1S1LecDataGrid.DataSource = Lservice.getAllLecturers();
            this.R1S1changeHeader();
            RS1_totLecs.Text = Lservice.getAllCount().ToString();
        }

        private void Section1_Lecturers_Activated(object sender, EventArgs e)
        {
            draw();
            MessageBox.Show("tHIS eXECUTED");
        }
    }
}
