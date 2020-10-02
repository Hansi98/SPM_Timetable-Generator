using System;
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
    public partial class Section3_nooverlappingSessions : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int sessionID1 = 0;
        public Section3_nooverlappingSessions()
        {
            InitializeComponent();
            fillTagGridsessionsadj();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void fillTagGridsessionsadj()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("getMasterTable", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTags = new DataTable();
                sqlDa.Fill(dataTags);
                visalgdvadj1.DataSource = dataTags;
                visalgdvadj2.DataSource = dataTags;
               // visalgdvadj3.DataSource = dataTags;
            }

        }

        private void Section3_nooverlappingSessions_Load(object sender, EventArgs e)
        {
            MySqlConnection cs = new MySqlConnection(connectionString);
            MySqlDataAdapter lecAdapter = new MySqlDataAdapter("SELECT * FROM lecturer", cs);
            MySqlDataAdapter timeslotdapter = new MySqlDataAdapter("SELECT * FROM workinghours", cs);
            MySqlDataAdapter grouplotdapter = new MySqlDataAdapter("SELECT * FROM groupinfo", cs);
            MySqlDataAdapter subgroupotdapter = new MySqlDataAdapter("SELECT * FROM subgroupinfo", cs);

            DataTable lecDatatable = new DataTable();
            lecAdapter.Fill(lecDatatable);

            DataTable timeslotDatatable = new DataTable();
            timeslotdapter.Fill(timeslotDatatable);

            DataTable groupDatatable = new DataTable();
            grouplotdapter.Fill(groupDatatable);

            DataTable subgroupDatatable = new DataTable();
            subgroupotdapter.Fill(subgroupDatatable);

            visalcmbadjLecturer.Items.Clear();
            visalcmbadjts1.Items.Clear();
          

            visalcmbadjgroup.Items.Clear();
            visalcmbadjts2.Items.Clear();
        

          //  visalcmdmugsgroup.Items.Clear();
         //   visalcmbadjts3.Items.Clear();
        

            for (int i = 0; i < lecDatatable.Rows.Count; i++)
            {
                var name1 = (lecDatatable.Rows[i]["fname"]);
                var name2 = (lecDatatable.Rows[i]["lname"]);
                var name = name1 + " " + name2;

                visalcmbadjLecturer.Items.Add(name);
            }
            for (int i = 0; i < timeslotDatatable.Rows.Count; i++)
            {
                visalcmbadjts1.Items.Add((timeslotDatatable.Rows[i]["noOfWrkHours"]));
                visalcmbadjts2.Items.Add((timeslotDatatable.Rows[i]["noOfWrkHours"]));
             
            }
            for (int i = 0; i < groupDatatable.Rows.Count; i++)
            {
                visalcmbadjgroup.Items.Add((groupDatatable.Rows[i]["GroupID"]));
            }
            for (int i = 0; i < subgroupDatatable.Rows.Count; i++)
            {
            
            }

        }

        private void visalbtnadjseach1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("MasterTablefilterByLecturerName&Time", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_lecturerName", visalcmbadjLecturer.Text);
                sqlDa.SelectCommand.Parameters.AddWithValue("_time", visalcmbadjts1.Text);
                DataTable dataLocations = new DataTable();
                sqlDa.Fill(dataLocations);
                visalgdvadj1.DataSource = dataLocations;
                
            }
        }

        private void visalbtnrefresh1_Click(object sender, EventArgs e)
        {
            fillTagGridsessionsadj();
        }

        private void visalgdvadj1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (visalgdvadj1.Columns[e.ColumnIndex].Name == "Edit1")
            {
                visalcmbadjday1.Text = visalgdvadj1.CurrentRow.Cells[7].Value.ToString();
              
                sessionID1 = Convert.ToInt32(visalgdvadj1.CurrentRow.Cells[1].Value.ToString());
            }

          
        }

        private void visalbtnadjfix1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("newsessionAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_sessionID", sessionID1);
                mySqlCmd.Parameters.AddWithValue("_Day", visalcmbadjday1.Text.Trim().ToString());
               
                mySqlCmd.ExecuteNonQuery();

                visalcmbadjday1.Text = "";
                fillTagGridsessionsadj();
                MessageBox.Show(" Fixed Successfully");

            }
        }

        private void visalgdvadj2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (visalgdvadj2.Columns[e.ColumnIndex].Name == "Edit2")
            {
                visalcmbadjday2.Text = visalgdvadj2.CurrentRow.Cells[7].Value.ToString();

                sessionID1 = Convert.ToInt32(visalgdvadj2.CurrentRow.Cells[1].Value.ToString());
            }
        }

        private void visalbtnrefresh2_Click(object sender, EventArgs e)
        {
            fillTagGridsessionsadj();
        }

        private void visalbtnrefresh3_Click(object sender, EventArgs e)
        {
            fillTagGridsessionsadj();
        }

        private void visalbtnadjseach2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("MasterTablefilterByTime&GroupID", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_groupID", visalcmbadjgroup.Text);
                sqlDa.SelectCommand.Parameters.AddWithValue("_time", visalcmbadjts2.Text);
                DataTable dataLocations = new DataTable();
                sqlDa.Fill(dataLocations);
                visalgdvadj2.DataSource = dataLocations;

            }
        }

        private void visalbtnadjfix2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("newsessionAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_sessionID", sessionID1);
                mySqlCmd.Parameters.AddWithValue("_Day", visalcmbadjday2.Text.Trim().ToString());
                mySqlCmd.ExecuteNonQuery();

                visalcmbadjday2.Text = "";
                fillTagGridsessionsadj();
                MessageBox.Show(" Fixed Successfully");

            }
        }

        private void visalbtnadjseach3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
              //  mySqlCon.Open();
              //  MySqlDataAdapter sqlDa = new MySqlDataAdapter("sessiongetBySubGroupAndTimeslot", mySqlCon);
               // sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
             //   sqlDa.SelectCommand.Parameters.AddWithValue("_Subgroup_ID", visalcmdmugsgroup.Text);
//sqlDa.SelectCommand.Parameters.AddWithValue("_Timeslot", visalcmbadjts3.Text);
             //   DataTable dataLocations = new DataTable();
            //    sqlDa.Fill(dataLocations);
            //    visalgdvadj3.DataSource = dataLocations;

            }
        }

        private void visalgdvadj3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    if (visalgdvadj3.Columns[e.ColumnIndex].Name == "Edit3")
//{
       //         visalcmbadjday3.Text = visalgdvadj3.CurrentRow.Cells[7].Value.ToString();

      //          sessionID1 = Convert.ToInt32(visalgdvadj3.CurrentRow.Cells[1].Value.ToString());
         //   }
        }

        private void visalbtnadjfix3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
//mySqlCon.Open();
            //    MySqlCommand mySqlCmd = new MySqlCommand("newsessionAddorEdit", mySqlCon);
           //     mySqlCmd.CommandType = CommandType.StoredProcedure;
        //        mySqlCmd.Parameters.AddWithValue("_sessionID", sessionID1);
//mySqlCmd.Parameters.AddWithValue("_Day", visalcmbadjday3.Text.Trim().ToString());
///mySqlCmd.ExecuteNonQuery();

//visalcmbadjday3.Text = "";
//fillTagGridsessionsadj();
//MessageBox.Show(" Fixed Successfully");

            }
        }
    }
}
