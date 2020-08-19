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
    public partial class Section1_addSubject : Form
    {
        SubjectServiceImpl Sservice = new SubjectServiceImpl();
        public Section1_addSubject()
        {
            InitializeComponent();
        }

        private void RS1_addLSubAdd_Click(object sender, EventArgs e)
        {
            String lec=null, tut=null, lab=null, eval=null, year=null, sem=null;
            try
            {
                lec = RS1_addSubLecHr.SelectedItem.ToString();
                tut = RS1_addSubTutHr.SelectedItem.ToString();
                lab = RS1_addSubLabHr.SelectedItem.ToString();
                eval =RS1_addSubEvalHr.SelectedItem.ToString();
                year = R1S_addSubYear.SelectedItem.ToString();
                sem = R1S_addSubSem.SelectedItem.ToString();

                if (RS1_addSubCode.Text.Trim()=="" || RS1_addSubName.Text.Trim()=="")
                {
                    MessageBox.Show("All the Fields are Compulsory, Please Recheck!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    Subject S = new Subject(RS1_addSubCode.Text.Trim(), RS1_addSubName.Text.Trim(), Convert.ToInt32(lec), Convert.ToInt32(tut), Convert.ToInt32(lab), Convert.ToInt32(eval), Convert.ToInt32(year), Convert.ToInt32(sem));


                    if (Sservice.checkExist(S))
                    {
                        MessageBox.Show("This Suject Code is Already Regitered in the System!", "Subject Code Already Exist!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                    }
                    else {
                        if (Sservice.addSubject(S))
                        {
                            MessageBox.Show("Subject Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Dispose();


                        }
                        else
                        {
                            MessageBox.Show("Some Error Occured During Registration of Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    
                }



            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("All the Fields are Compulsory, Please Recheck!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          

           

           
            

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RS1_addSubLecHr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
