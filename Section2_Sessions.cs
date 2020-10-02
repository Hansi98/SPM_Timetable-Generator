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
    public partial class Section2_Sessions : Form
    {
        SessonServiceImpl sService = new SessonServiceImpl();
        public Section2_Sessions()
        {
            InitializeComponent();
            draw();
        }

        private void RS1_addSession_Click(object sender, EventArgs e)
        {
            new Section2_addSession().Show();
        }

        private void Section2_Sessions_Load(object sender, EventArgs e)
        {

        }

        public void R1S1changeHeader()
        {
            if (R1S1LecDataGrid.Columns["sessionID"] != null)
                R1S1LecDataGrid.Columns["sessionID"].HeaderText = "Session ID";

            if (R1S1LecDataGrid.Columns["GroupID"] != null)
                R1S1LecDataGrid.Columns["GroupID"].HeaderText = "Group ID";

            if (R1S1LecDataGrid.Columns["SubCode"] != null)
                R1S1LecDataGrid.Columns["SubCode"].HeaderText = "Subject Code";

            if (R1S1LecDataGrid.Columns["StudentCount"] != null)
                R1S1LecDataGrid.Columns["StudentCount"].HeaderText = "Student Count";


                
        }

        public void draw()
        {
            R1S1LecDataGrid.DataSource = sService.getAllSessions();
            this.R1S1changeHeader();
            RS1_totSes.Text = sService.getAllCount().ToString();
        }

        private void R1s_SessionRefresh_Click(object sender, EventArgs e)
        {
            draw();
        }

        private void RS1_searchSession_TextChanged(object sender, EventArgs e)
        {


            if (RS1_searchSession.Text.Trim() == "")
            {

                draw();

            }
            else
            {
                R1S1LecDataGrid.DataSource = sService.searchSession(RS1_searchSession.Text.Trim());
                R1S1changeHeader();
            }
        }

        private void RS1_searchSession_Click(object sender, EventArgs e)
        {
            RS1_searchSession.Text = null;
        }

        private void RS1_deleteSes_Click(object sender, EventArgs e)
        {
            if (R1S1LecDataGrid.CurrentCell.ColumnIndex > 0)
            {
                MessageBox.Show("Please Select the Session Id of the Relevent Session that  you want to delete", "Select a Session ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                string empID = R1S1LecDataGrid.CurrentCell.Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure that you want to Delete Session " + empID + " ? This Session Details will be permenantly deleted!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (sService.deleteSession(empID))
                    {
                        MessageBox.Show("Session Data permenantly deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        draw();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured During The Deletion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }

        private void RS1_viewSes_Click(object sender, EventArgs e)
        {
            if (R1S1LecDataGrid.CurrentCell.ColumnIndex > 0)
            {
                MessageBox.Show("Please Select the Session Id of the Relevent Session", "Select a Session ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                string empID = R1S1LecDataGrid.CurrentCell.Value.ToString();
                new section2_viewSession(sService.getSingleSession(empID)).Show();
            }
        }

        private void SesPortalbtnclose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
