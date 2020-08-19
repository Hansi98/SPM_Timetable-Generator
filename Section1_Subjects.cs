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
    public partial class Section1_Subjects : Form
    {
        SubjectServiceImpl Sservice = new SubjectServiceImpl();
        public Section1_Subjects()
        {
            InitializeComponent();
            draw();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RS1_addSubject_Click(object sender, EventArgs e)
        {
            new Section1_addSubject().Show();
        }

        public void R1S1changeHeader()
        {
            if (R1S1SubDataGrid.Columns["code"] != null)
                R1S1SubDataGrid.Columns["code"].HeaderText = "Subject Code";

            if (R1S1SubDataGrid.Columns["name"] != null)
                R1S1SubDataGrid.Columns["name"].HeaderText = "Subject Name";

            if (R1S1SubDataGrid.Columns["lecHr"] != null)
                R1S1SubDataGrid.Columns["lecHr"].HeaderText = "Lecture Hours";

            if (R1S1SubDataGrid.Columns["tutHr"] != null)
                R1S1SubDataGrid.Columns["tutHr"].HeaderText = "Tutorial Hours";

            if (R1S1SubDataGrid.Columns["labHr"] != null)
                R1S1SubDataGrid.Columns["labHr"].HeaderText = "Lab Hours";

            if (R1S1SubDataGrid.Columns["EvalHr"] != null)
                R1S1SubDataGrid.Columns["EvalHr"].HeaderText = "Evaluation Hours";

            if (R1S1SubDataGrid.Columns["year"] != null)
                R1S1SubDataGrid.Columns["year"].HeaderText = "Offered Year";

            if (R1S1SubDataGrid.Columns["semester"] != null)
                R1S1SubDataGrid.Columns["semester"].HeaderText = "Offered Semester";


        }

        public void draw()
        {
            R1S1SubDataGrid.DataSource = Sservice.getAllSubject();
            this.R1S1changeHeader();
          RS1_totSubs.Text = Sservice.getAllCount().ToString();
        }

        private void R1s_subRefresh_Click(object sender, EventArgs e)
        {
            draw();
        }

        private void RS1_searchSub_TextChanged(object sender, EventArgs e)
        {
            if (RS1_searchSub.Text.Trim() == "")
            {

                draw();

            }
            else
            {
                R1S1SubDataGrid.DataSource = Sservice.searchSubject(RS1_searchSub.Text.Trim());
                R1S1changeHeader();
            }
        }

        private void RS1_searchSub_MouseClick(object sender, MouseEventArgs e)
        {
            RS1_searchSub.Text = null;
        }

        private void RS1_viewSubject_Click(object sender, EventArgs e)
        {
            if (R1S1SubDataGrid.CurrentCell.ColumnIndex > 0)
            {
                MessageBox.Show("Please Select the Subject Code of the Relevent Subject.", "Select an Subject Code!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                string code = R1S1SubDataGrid.CurrentCell.Value.ToString();
                new Section1_viewSubject(Sservice.getSingleSubject(code)).Show();
            }
        }

        private void RS1_deleteSubject_Click(object sender, EventArgs e)
        {
            if (R1S1SubDataGrid.CurrentCell.ColumnIndex > 0)
            {
                MessageBox.Show("Please Select the Subject Code of the Relevent Subject that  you want to delete.", "Select an Subject Code!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                string code = R1S1SubDataGrid.CurrentCell.Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure that you want to Delete Subject " + code + " ? This Subject Details will be permenantly deleted!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Sservice.deleteSubject(code))
                    {
                        MessageBox.Show("Subject Data permenantly deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        draw();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured During The Deletion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }
    }
}
