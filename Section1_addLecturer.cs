using ABC_Institute___Timetable_Generator.Models;
using ABC_Institute___Timetable_Generator.ServiceImpl;
using ABC_Institute___Timetable_Generator.Services;
using MySql.Data.MySqlClient;
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
    public partial class Section1_addLecturer : Form

    {
        LecturerServiceImpl Lservice = new LecturerServiceImpl();
        public Section1_addLecturer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RS1_addLecADD_Click(object sender, EventArgs e)
        {
           



            Lecturer L = new Lecturer(RS1_addLecFName.Text.Trim(), RS1_addLecMName.Text.Trim(), RS1_addLecLName.Text.Trim(), RS1_addLecFac.Text.Trim(), RS1_addLecDept.Text.Trim(), RS1_addLecCenter.Text.Trim(), RS1_addLecBuilding.Text.Trim(), RS1_addLecLevel.Text.Trim(), RS1_addLecRank.Text.Trim());

            if (!Lservice.addLecturer(L))
            {
                MessageBox.Show("Some Error Occured");
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Section1_addLecturer_Load(object sender, EventArgs e)
        {
            RS1_addLecEmpID.Text= Lservice.getNextEmpID();
        }
    }
}
