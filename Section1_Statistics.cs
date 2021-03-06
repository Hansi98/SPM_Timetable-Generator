﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABC_Institute___Timetable_Generator
{
    public partial class Section1_Statistics : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";

        public Section1_Statistics()
        {
            InitializeComponent();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NishikiDstatistics_lec_btnsubmit_Click(object sender, EventArgs e)
        {
            
                MySqlConnection sqlcon = new MySqlConnection(connectionString);
                MySqlCommand sqlcmd = new MySqlCommand("StatisiticsLecturerbyFaculty", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;


                sqlcon.Open();

                MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {

                nishikifacultylec_chart.Series["Faculty"].Points.AddXY(reader.GetString("faculty"), reader.GetInt32("count"));
            }

            //this.nishikifacultylec_chart.Series["Faculty"].Points.AddXY("faculty of computing", 2);
            //    this.nishikifacultylec_chart.Series["Faculty"].Points.AddXY("faculty of Engineering", 1);
            //    this.nishikifacultylec_chart.Series["Faculty"].Points.AddXY("Faculty of Bussiness & Management", 1);
                 
                sqlcon.Close();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlcon = new MySqlConnection(connectionString);
            MySqlCommand sqlcmd = new MySqlCommand("StatisticsLecturerbyCenter", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcon.Open();

            MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {

                nishikicenterlec_chart.Series["Center"].Points.AddXY(reader.GetString("center"), reader.GetInt32("count"));
            }

            //this.nishikicenterlec_chart.Series["Center"].Points.AddXY("Metro", 1);
            //this.nishikicenterlec_chart.Series["Center"].Points.AddXY("Malabe", 0);
            //this.nishikicenterlec_chart.Series["Center"].Points.AddXY("Kandy", 3);

            sqlcon.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlcon = new MySqlConnection(connectionString);
            MySqlCommand sqlcmd = new MySqlCommand("StatisticsLecturerbyDept", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcon.Open();

            MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {

                nishikideptlec_chart.Series["Department"].Points.AddXY(reader.GetString("dept"), reader.GetInt32("count"));
            }

            //this.nishikideptlec_chart.Series["Department"].Points.AddXY("Software Engineering", 2);
            //this.nishikideptlec_chart.Series["Department"].Points.AddXY("Macanical Engineering", 1);
            //this.nishikideptlec_chart.Series["Department"].Points.AddXY("Marketing", 1);

            sqlcon.Close();
        }

        private void Nishikileclvlchart_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlcon = new MySqlConnection(connectionString);
            MySqlCommand sqlcmd = new MySqlCommand("StatisticsLecturerbyLevel", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcon.Open();

            MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {

                nishikilvllec_chart.Series["Level"].Points.AddXY(reader.GetString("Llevel"), reader.GetInt32("count"));
            }


            //this.nishikilvllec_chart.Series["Level"].Points.AddXY(1, 2);
            //this.nishikilvllec_chart.Series["Level"].Points.AddXY(2, 0);
            //this.nishikilvllec_chart.Series["Level"].Points.AddXY(3, 2);
            //this.nishikilvllec_chart.Series["Level"].Points.AddXY(4, 0);
            //this.nishikilvllec_chart.Series["Level"].Points.AddXY(5, 0);
            //this.nishikilvllec_chart.Series["Level"].Points.AddXY(6, 0);
            //this.nishikilvllec_chart.Series["Level"].Points.AddXY(7, 0);
            //this.nishikilvllec_chart.Series["Level"].Points.AddXY(8, 0);

            sqlcon.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nishikibtnloadlec_Click(object sender, EventArgs e)
        {

            MySqlConnection sqlcon = new MySqlConnection(connectionString);
            MySqlCommand sqlcmd = new MySqlCommand("StatisticsSubjectsbyLechours", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcon.Open();

            MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {

                nishikisubhrschart.Series["Hours"].Points.AddXY(reader.GetString("name"), reader.GetInt32("lecHr"));
            }

            //this.nishikisubhrschart.Series["Hours"].Points.AddXY("Artificial Intelligence", 3);
            //this.nishikisubhrschart.Series["Hours"].Points.AddXY("Machine Learning", 3);

            sqlcon.Close();
        }

        private void Nishikibtnloadtute_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlcon = new MySqlConnection(connectionString);
            MySqlCommand sqlcmd = new MySqlCommand("StatisticsSubjectsbyTutehours", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcon.Open();

            MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {

                nishikisubtutechart.Series["Hours"].Points.AddXY(reader.GetString("name"), reader.GetInt32("tutHr"));
            }

            //this.nishikisubtutechart.Series["Hours"].Points.AddXY("Artificial Intelligence", 1);
            //this.nishikisubtutechart.Series["Hours"].Points.AddXY("Machine Learning", 0);

            sqlcon.Close();
        }

        private void Nishikibtnloadlab_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlcon = new MySqlConnection(connectionString);
            MySqlCommand sqlcmd = new MySqlCommand("StatisticsSubjectsbyLabhours", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcon.Open();

            MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {

                nishikisublabchart.Series["Hours"].Points.AddXY(reader.GetString("name"), reader.GetInt32("labHr"));
            }

            //this.nishikisublabchart.Series["Hours"].Points.AddXY("Artificial Intelligence", 3);
            //this.nishikisublabchart.Series["Hours"].Points.AddXY("Machine Learning", 0);

            sqlcon.Close();
        }

        private void Nishikibtnloadeval_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlcon = new MySqlConnection(connectionString);
            MySqlCommand sqlcmd = new MySqlCommand("StatisticsSubjectsbyEvahours", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcon.Open();

            MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {

                nishikisubevalchart.Series["Hours"].Points.AddXY(reader.GetString("name"), reader.GetInt32("evalHr"));
            }

            //this.nishikisubevalchart.Series["Hours"].Points.AddXY("Artificial Intelligence", 5);
            //this.nishikisubevalchart.Series["Hours"].Points.AddXY("Machine Learning", 0);

            sqlcon.Close();
        }

        private void Nishikistudyearbtn_Click(object sender, EventArgs e)
        {
            
            MySqlConnection sqlcon = new MySqlConnection(connectionString);
            MySqlCommand sqlcmd = new MySqlCommand("StatisticsStudentsbyYear", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcon.Open();

            MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {

                nishikistudyearchart.Series["year"].Points.AddXY(reader.GetString("Year"), reader.GetInt32("GroupNoCount"));
            }


            //this.nishikistudyearchart.Series["year"].Points.AddXY("Y1", 2);
            //this.nishikistudyearchart.Series["year"].Points.AddXY("Y2", 2);

            sqlcon.Close();

        }

        private void Nishikistudprogrammebtn_Click(object sender, EventArgs e)
        {
            
            MySqlConnection sqlcon = new MySqlConnection(connectionString);
            MySqlCommand sqlcmd = new MySqlCommand("StatisticsStudentsbyProgramme", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcon.Open();

            MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {

                nishikistudentprogrammechart.Series["Programme"].Points.AddXY(reader.GetString("Programme"), reader.GetInt32("GroupCount"));
            }

            //this.nishikistudentprogrammechart.Series["Programme"].Points.AddXY("CS", 2);
            //this.nishikistudentprogrammechart.Series["Programme"].Points.AddXY("SE", 2);

            sqlcon.Close();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
            //nishiki
        }
    }
}
