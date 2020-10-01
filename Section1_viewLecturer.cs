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
    public partial class Section1_viewLecturer : Form
    {
        Lecturer L;
        LecturerServiceImpl Lservice = new LecturerServiceImpl();
        public Section1_viewLecturer()
        {
            InitializeComponent();
        }

        public Section1_viewLecturer( Object obj)
        {
            InitializeComponent();
            this.L = (Lecturer)obj;
            drawData(this.L);
        }

        public void drawData(Object L)
        {

            Lecturer l2 = (Lecturer)L;

            RS1_lecInfoEmpID.Text = l2.ID1;
            RS1_lecInfoFname.Text = l2.FName;
            RS1_lecInfoMname.Text = l2.mName;
            RS1_lecInfoLname.Text = l2.lName;
            RS1_lecInfoFac.Text = l2.Faculty;
            RS1_lecInfoDept.Text = l2.Dept;
            RS1_lecInfoCenter.Text = l2.Center;
            RS1_lecInfoBuilding.Text = l2.Building;
            RS1_lecInfoLevel.Text = l2.Level;
            RS1_lecInfoRank.Text = l2.Rank;

            this.Text = this.Text + " - " + l2.ID1;



        }

        private void RS1_lecInfoRemoveB_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure that you want to Delete Lecturer "+this.L.ID1+" ? This Lecturer Details will be permenantly deleted!", "Confirmation", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Lservice.deleteLecturer(L.ID1))
                {
                    MessageBox.Show("Lecturer Data permenantly deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Error Occured During The Deletion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            
        }

        private void RS1_lecInfoUpdateB_Click(object sender, EventArgs e)
        {
            new Section1_UpdateLecturer(L).Show();
            Dispose();
        }

        private void Section1_viewLecturer_Load(object sender, EventArgs e)
        {

        }
    }
}
