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
            String lec=null, tut=null, lab=null, eval=null;
            try
            {
                lec = RS1_addSubLecHr.SelectedItem.ToString();
                tut = RS1_addSubTutHr.SelectedItem.ToString();
                lab = RS1_addSubLabHr.SelectedItem.ToString();
                eval =RS1_addSubEvalHr.SelectedItem.ToString();

                Subject S = new Subject(RS1_addSubCode.Text.Trim(), RS1_addSubName.Text.Trim(), Convert.ToInt32(lec), Convert.ToInt32(tut), Convert.ToInt32(lab), Convert.ToInt32(eval));
                if (Sservice.addSubject(S))
                {
                    MessageBox.Show("Subject Added Successfully");
                    Dispose();


                }
                else
                {
                    MessageBox.Show("Some Error Occured");

                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Please Fill all the Fields");
            }
          

           

           
            

        }
    }
}
