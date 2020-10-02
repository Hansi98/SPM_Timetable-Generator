using ABC_Institute___Timetable_Generator.Models;
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
    public partial class Section2_addSession : Form
    {
        LecturerServiceImpl Lservice = new LecturerServiceImpl();
        SubjectServiceImpl SService = new SubjectServiceImpl();
        SessonServiceImpl SesService = new SessonServiceImpl();

        List<Lecturer> lecList;
        List<string> combolist = null;
        public Section2_addSession()
        {
            InitializeComponent();
            draw();
            loadSubCodes();
            loadGroups();
            loadTags();
            
        }

        private void Section2_addSession_Load(object sender, EventArgs e)
        {

        }

        public void draw()
        {
            R1S2LecDataGrid.DataSource = Lservice.getAllLecturers();
            this.R1S2changeHeader();
            
        }

        public void R1S2changeHeader()
        {
            if (R1S2LecDataGrid.Columns["Eid"] != null)
                R1S2LecDataGrid.Columns["Eid"].HeaderText = "Employee ID";

            if (R1S2LecDataGrid.Columns["fname"] != null)
                R1S2LecDataGrid.Columns["fname"].HeaderText = "First Name";

            if (R1S2LecDataGrid.Columns["mname"] != null)
                R1S2LecDataGrid.Columns["mname"].HeaderText = "Middle Name";

            if (R1S2LecDataGrid.Columns["lname"] != null)
                R1S2LecDataGrid.Columns["lname"].HeaderText = "Last Name";

            if (R1S2LecDataGrid.Columns["faculty"] != null)
                R1S2LecDataGrid.Columns["faculty"].HeaderText = "Faculty";

            if (R1S2LecDataGrid.Columns["dept"] != null)
                R1S2LecDataGrid.Columns["dept"].HeaderText = "Department";

            if (R1S2LecDataGrid.Columns["center"] != null)
                R1S2LecDataGrid.Columns["center"].HeaderText = "Center";

            if (R1S2LecDataGrid.Columns["building"] != null)
                R1S2LecDataGrid.Columns["building"].HeaderText = "Building";

            if (R1S2LecDataGrid.Columns["Llevel"] != null)
                R1S2LecDataGrid.Columns["Llevel"].HeaderText = "Level";

            if (R1S2LecDataGrid.Columns["Lrank"] != null)
                R1S2LecDataGrid.Columns["Lrank"].HeaderText = "Rank";
        }

        public void addToArrayList(Object i)
        {
            Lecturer temp = (Lecturer)i;
            if (lecList == null)
                lecList = new List<Lecturer>();

            lecList.Add( temp );
        }

        public void removeFromList(string id)
        {
            int x = 0;

            for (x = 0; x < lecList.Count; x++)
            {
                if (lecList[x].ID1 == id)
                {
                    lecList.RemoveAt(x);
                }
            }
        }

        public bool checkExsist(string id)
        {
            int x = 0;

            if (lecList == null)
            {
                return false;
            }
            else {

            for (x = 0; x < lecList.Count; x++)
            {
                if (lecList[x].ID1 == id)
                {
                    return true;
                }
            }
            return false;

            }
        }

        private void button2selectLec_Click(object sender, EventArgs e)
        {
            if (R1S2LecDataGrid.CurrentCell.ColumnIndex > 0)
            {
                MessageBox.Show("Please Select the Employee Id of the Relevent Employee", "Select an Employee ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                string empID = R1S2LecDataGrid.CurrentCell.Value.ToString();
                if (!checkExsist(empID)) { 
                addToArrayList(Lservice.getSingleLecturer(empID));
                selectorLecs.Visible = true;

                selectorLecs.Items.Add(lecList[lecList.Count-1].ID1 +"     " + lecList[lecList.Count - 1].FName + " " + lecList[lecList.Count - 1].lName);
                }
                else
                {
                    MessageBox.Show("This Employee is Already added to the Session!", "Already Added!",
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Asterisk);
                }

            }
        }

        private void button1deselectlec_Click(object sender, EventArgs e)
        {
            if (selectorLecs.SelectedIndex<0)
            {
                MessageBox.Show("Please Select a Employee first to De-Select !","Not Selected!",
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Asterisk);

            }
            else
            {
                int index = selectorLecs.SelectedIndex;
                lecList.RemoveAt(index);
                selectorLecs.Items.RemoveAt(index);
            }
        }

        private void loadSub_Click(object sender, EventArgs e)
        {
            loadSub.Visible = false;
            loadMain.Visible = true;
            RS2_stdGroup.Items.Clear();


            List<String> list = SesService.getSubGroups();
            for (int i = 0; i < list.Count; i++)
            {
                RS2_stdGroup.Items.Add(list[i]);
            }



        }

        private void loadMain_Click(object sender, EventArgs e)
        {
            loadSub.Visible = true;
            loadMain.Visible = false;
            RS2_stdGroup.Items.Clear();
            

            List<String> list = SesService.getMainGroups();
            for (int i = 0; i < list.Count; i++)
            {
                RS2_stdGroup.Items.Add(list[i]);
            }


        }

        public void loadSubCodes()
        {
            List<String> list = SService.getAllSubCodes();
            for(int i = 0; i < list.Count; i++)
            {
                RS2_subCode.Items.Add(list[i]);
            }
        }

        public void loadGroups()
        {
            RS2_stdGroup.Items.Clear();


            List<String> list = SesService.getMainGroups();
            for (int i = 0; i < list.Count; i++)
            {
                RS2_stdGroup.Items.Add(list[i]);
            }

        }


        public void loadTags()
        {
            RS2_Tag.Items.Clear();


            List<String> list = SesService.getTags();
            for (int i = 0; i < list.Count; i++)
            {
                RS2_Tag.Items.Add(list[i]);
            }

        }

        private void RS1_addLecCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RS2_searchLec_TextChanged(object sender, EventArgs e)
        {
            if (RS2_searchLec.Text.Trim() == "")
            {

                draw();

            }
            else
            {
                R1S2LecDataGrid.DataSource = Lservice.searchLecturer(RS2_searchLec.Text.Trim());
                R1S2changeHeader();
            }
        }

        private void RS2_searchLec_Click(object sender, EventArgs e)
        {
            RS2_searchLec.Text = null;
        }

        private void RS1_addLecADD_Click(object sender, EventArgs e)
        {
            if ((RS2_Tag.Text.Trim() == "") || (RS2_subCode.Text.Trim() == "") || (RS2_stdGroup.Text.Trim() == "") || (RS2_dura.Text.Trim() == "") || (RS2_stdCount.Text.Trim() == "") || lecList==null) 
                {
                MessageBox.Show("Please Fill all the Fields! (Make sure you have selected atleast a one Employee for the Session)", "Neccessary Fields are Empty!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            else
            {
                Session s = new Session(0, RS2_stdGroup.Text, RS2_Tag.Text, RS2_subCode.Text, RS2_stdCount.Text, RS2_dura.Text, lecList);

                if (SesService.addSession(s))
                {
                    MessageBox.Show("Session Added Successfully", "Success!",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                    Dispose();


                }
                else
                {
                    MessageBox.Show("Some Error Occured During the Session Registration, Please Re-Try", "Error!",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);

                }
            }
        }

        private void RS2_Tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RS2_Tag.Text == "Practical")
            {
                loadSub.Visible = false;
                loadMain.Visible = true;
                RS2_stdGroup.Items.Clear();


                List<String> list = SesService.getSubGroups();
                for (int i = 0; i < list.Count; i++)
                {
                    RS2_stdGroup.Items.Add(list[i]);
                }

            }
            else
            {
                loadSub.Visible = true;
                loadMain.Visible = false;
                RS2_stdGroup.Items.Clear();


                List<String> list = SesService.getMainGroups();
                for (int i = 0; i < list.Count; i++)
                {
                    RS2_stdGroup.Items.Add(list[i]);
                }
            }
        }
    }
}
