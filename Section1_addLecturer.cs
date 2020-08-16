﻿using ABC_Institute___Timetable_Generator.Models;
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

            if (Lservice.addLecturer(L))
            {
                MessageBox.Show("Lecturer Added Successfully");
                Dispose();
             
                
            }
            else
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

        private void RS1_addLecFac_SelectedIndexChanged(object sender, EventArgs e)

        {
            RS1_addLecDept.SelectedItem = null;
            RS1_addLecDept.Visible = true;
            deptaddleclabel.Visible = true;

            if (RS1_addLecFac.SelectedIndex == 0)
            {
                RS1_addLecDept.Items.Clear();

                RS1_addLecDept.Items.Add("Software Engineering");
                RS1_addLecDept.Items.Add("Cyber Security");
                RS1_addLecDept.Items.Add("IT");
                RS1_addLecDept.Items.Add("Computer Network");
            }

            if (RS1_addLecFac.SelectedIndex == 1)
            {
                RS1_addLecDept.Items.Clear();

                RS1_addLecDept.Items.Add("Civil Engineering");
                RS1_addLecDept.Items.Add("Mechanical Engineering");
                RS1_addLecDept.Items.Add("Eletronic Engineering");
                RS1_addLecDept.Items.Add("Materials Engineering");
            }

            if (RS1_addLecFac.SelectedIndex == 2)
            {
                RS1_addLecDept.Items.Clear();

                RS1_addLecDept.Items.Add("Management");
                RS1_addLecDept.Items.Add("Human Resourse");
                RS1_addLecDept.Items.Add("Marketing");
                RS1_addLecDept.Items.Add("Supply Chain Management");
            }
        }

        private void RS1_addLecCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void RS1_addLecDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            RS1_addLecCenter.Visible = true;
            centaddleclabel.Visible = true;

        }

        private void RS1_addLecCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RS1_addLecBuilding.Visible = true;
            buildaddleclabel.Visible = true;
            RS1_addLecBuilding.SelectedItem = null;

            RS1_addLecLevel.Visible = true;
            leveladdleclabel.Visible = true;

            if (RS1_addLecCenter.SelectedIndex == 0)
            {
                RS1_addLecBuilding.Items.Clear();

                RS1_addLecBuilding.Items.Add("New Building");
                RS1_addLecBuilding.Items.Add("Computing Building");
                RS1_addLecBuilding.Items.Add("Businnes Building");
                RS1_addLecBuilding.Items.Add("Engineering Building");
            }

            if (RS1_addLecCenter.SelectedIndex == 1)
            {
                RS1_addLecBuilding.Items.Clear();

                RS1_addLecBuilding.Items.Add("Main Building");
                RS1_addLecBuilding.Items.Add("A5 Building");
                
            }

            if (RS1_addLecCenter.SelectedIndex == 2)
            {
                RS1_addLecBuilding.Items.Clear();

                RS1_addLecBuilding.Items.Add("B5 Building");
                RS1_addLecBuilding.Items.Add("New Building");
                RS1_addLecBuilding.Items.Add("Tower Building");
               
            }
        }

        private void RS1_addLecLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            RS1_addLecRank.Visible = true;
            RS1_addLecRank.Text = RS1_addLecEmpID.Text +"."+ RS1_addLecLevel.Text;
        }
    }
}
