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
        public static int newlecs=0;

        

        LecturerServiceImpl Lservice = new LecturerServiceImpl();
        public Section1_Lecturers()
        {
            InitializeComponent();
            RS1_newLecs.Text = newlecs.ToString();

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
           

                if (RS1_searchLec.Text.Trim()=="") {

                    draw();
                    
                }
                else {
                    R1S1LecDataGrid.DataSource = Lservice.searchLecturer(RS1_searchLec.Text.Trim());
                    R1S1changeHeader();
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

       

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            RS1_newLecs.Text = newlecs.ToString();
        }

        private void RS1_viewLecturer_Click(object sender, EventArgs e)
        {
            if (R1S1LecDataGrid.CurrentCell.ColumnIndex>0)
            {
                MessageBox.Show("Please Select the Employee Id of the Relevent Employee","Select an Employee ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
               string empID = R1S1LecDataGrid.CurrentCell.Value.ToString();
               new Section1_viewLecturer(Lservice.getSingleLecturer(empID)).Show();
            }
        }

        private void RS1_deleteLecturer_Click(object sender, EventArgs e)
        {
            if (R1S1LecDataGrid.CurrentCell.ColumnIndex > 0)
            {
                MessageBox.Show("Please Select the Employee Id of the Relevent Employee that  you want to delete", "Select an Employee ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                string empID = R1S1LecDataGrid.CurrentCell.Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure that you want to Delete Lecturer " + empID + " ? This Lecturer Details will be permenantly deleted!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Lservice.deleteLecturer(empID))
                    {
                        MessageBox.Show("Lecturer Data permenantly deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        draw();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured During The Deletion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }

        private void R1s_LecRefresh_Click(object sender, EventArgs e)
        {
            draw();
        }
    }
}
