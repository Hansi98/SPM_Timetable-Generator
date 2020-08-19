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
    public partial class Section1_UpdateSubject : Form
    {
        Subject S;
        SubjectServiceImpl Sservice = new SubjectServiceImpl();

        public Section1_UpdateSubject()
        {
            InitializeComponent();
        }

        public Section1_UpdateSubject(Object obj)
        {
            InitializeComponent();
            this.S = (Subject)obj;
            draw(this.S);
            this.Text = this.Text + " - " + this.S.Code;
        }

        private void RS1_addLecADD_Click(object sender, EventArgs e)
        {
            if ((RS1_addSubName.Text.Trim() == "") || (RS1_addSubLecHr.SelectedItem == null) || (RS1_addSubTutHr.SelectedItem == null) || (RS1_addSubLabHr.SelectedItem == null) || (RS1_addSubEvalHr.SelectedItem == null) || (R1S_addSubYear.SelectedItem == null) || (R1S_addSubSem.SelectedItem == null))
            {
                MessageBox.Show("Please Fill all the Fields! (Middle Name is Optional)", "Neccessary Fields are Empty!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            else
            {






                Subject S = new Subject(this.S.Code, RS1_addSubName.Text.Trim(), Convert.ToInt32( RS1_addSubLecHr.Text.Trim()), Convert.ToInt32(RS1_addSubTutHr.Text.Trim()), Convert.ToInt32(RS1_addSubLabHr.Text.Trim()), Convert.ToInt32(RS1_addSubEvalHr.Text.Trim()), Convert.ToInt32(R1S_addSubYear.Text.Trim()), Convert.ToInt32(R1S_addSubSem.Text.Trim()) );


                if (Sservice.updateSubject(S))
                {
                    MessageBox.Show("Subject Updated Successfully", "Success!",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                    Dispose();


                }
                else
                {
                    MessageBox.Show("Some Error Occured During the Subject Updating, Please Re-Try", "Error!",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);

                }





            }
        }

        public void draw(Object obj)
        {

            Subject l2 = (Subject)obj;

            RS1_addSubCode.Text = l2.Code;
            RS1_addSubName.Text = l2.Name;
            RS1_addSubLecHr.SelectedItem = l2.LecHrs.ToString();
            RS1_addSubTutHr.SelectedItem = l2.TutHrs.ToString();
            RS1_addSubLabHr.SelectedItem = l2.LabHr.ToString();
            RS1_addSubEvalHr.SelectedItem = l2.evalHr.ToString();
            R1S_addSubYear.SelectedItem = l2.Year.ToString();
            R1S_addSubSem.SelectedItem = l2.Sem.ToString();


        }

        private void R1s_uplecReset_Click(object sender, EventArgs e)
        {
            draw(this.S);
        }

        private void RS1_addLecCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
