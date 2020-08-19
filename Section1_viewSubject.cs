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
    public partial class Section1_viewSubject : Form
    {
        Subject S;
        SubjectServiceImpl Sservice = new SubjectServiceImpl();
        public Section1_viewSubject()
        {
            InitializeComponent();
        }

        public Section1_viewSubject(Object obj)
        {
            InitializeComponent();
            this.S = (Subject)obj;
            drawData(this.S);

        }

        public void drawData(Object L)
        {

            Subject l2 = (Subject)L;

            RS1_subInfoCode.Text = l2.Code;
            RS1_SubSubname.Text = l2.Name;
            RS1_subinfoLH.Text = l2.LecHrs.ToString();
            RS1_subinfoTH.Text = l2.TutHrs.ToString();
            RS1_subinfoLabH.Text = l2.LabHr.ToString();
            RS1_subinfoEH.Text = l2.evalHr.ToString();
            RS1_OfferedYear.Text = l2.Year.ToString();
            RS1_OfferedSem.Text = l2.Sem.ToString();



            this.Text = this.Text + " - " + l2.Code ;



        }

        private void RS1_lecInfoUpdateB_Click(object sender, EventArgs e)
        {
            new Section1_UpdateSubject(this.S).Show();
            Dispose();
        }

        private void RS1_lecInfoRemoveB_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure that you want to Delete Subject " + this.S.Code + " ? This Subject Details will be permenantly deleted!", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Sservice.deleteSubject(S.Code))
                {
                    MessageBox.Show("Subject Data permenantly deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Error Occured During The Deletion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
