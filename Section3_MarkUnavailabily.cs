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
    public partial class Section3_MarkUnavailabily : Form

    {
        int tid1 = 0;
        int tid2 = 0;
        int tid3 = 0;
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        public Section3_MarkUnavailabily()
        {
            InitializeComponent();
            fillTagGridlecdet();
            fillTagGridsessiondet();
            fillTagGridgroupdet();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Session3_MarkUnavailabily_Load(object sender, EventArgs e)
        {
            MySqlConnection cs = new MySqlConnection(connectionString);

            MySqlDataAdapter lecAdapter = new MySqlDataAdapter("SELECT * FROM lecturer", cs);
            MySqlDataAdapter timeslotdapter = new MySqlDataAdapter("SELECT * FROM workinghours", cs);
            MySqlDataAdapter modulelotdapter = new MySqlDataAdapter("SELECT * FROM subject", cs);
            MySqlDataAdapter grouplotdapter = new MySqlDataAdapter("SELECT * FROM groupinfo", cs);
            MySqlDataAdapter subgroupotdapter = new MySqlDataAdapter("SELECT * FROM subgroupinfo", cs);

            DataTable lecDatatable = new DataTable();
            lecAdapter.Fill(lecDatatable);

            DataTable timeslotDatatable = new DataTable();
            timeslotdapter.Fill(timeslotDatatable);

            DataTable modulelotDatatable = new DataTable();
            modulelotdapter.Fill(modulelotDatatable);

             DataTable groupDatatable = new DataTable();
            grouplotdapter.Fill(groupDatatable);

            DataTable subgroupDatatable = new DataTable();
            subgroupotdapter.Fill(subgroupDatatable);

            visalcmbmodulename.Items.Clear();
            visalustimeslotcmb.Items.Clear();

            visalusmodulenamecmb.Items.Clear();
            visalcmdtimeslot.Items.Clear();

            visalcmdmugsgroup.Items.Clear();
            visalcmdmugssubgroup.Items.Clear();
            visalcmdmugstimeslot.Items.Clear();

            for (int i = 0; i < lecDatatable.Rows.Count; i++)
            {
                var name1 = (lecDatatable.Rows[i]["fname"]);
                var name2 = (lecDatatable.Rows[i]["lname"]);
                var name = name1 + " " + name2;

                visalcmbmodulename.Items.Add(name);
            }

            for (int i = 0; i < timeslotDatatable.Rows.Count; i++)
            {
                visalcmdtimeslot.Items.Add((timeslotDatatable.Rows[i]["noOfWrkHours"]));
                visalustimeslotcmb.Items.Add((timeslotDatatable.Rows[i]["noOfWrkHours"]));
                visalcmdmugstimeslot.Items.Add((timeslotDatatable.Rows[i]["noOfWrkHours"]));
            }
            for (int i = 0; i < modulelotDatatable.Rows.Count; i++)
            {
                visalusmodulenamecmb.Items.Add((modulelotDatatable.Rows[i]["name"]));  
            }
            for (int i = 0; i < groupDatatable.Rows.Count; i++)
            {
                visalcmdmugsgroup.Items.Add((groupDatatable.Rows[i]["GroupID"]));
            }
            for (int i = 0; i < subgroupDatatable.Rows.Count; i++)
            {
                visalcmdmugssubgroup.Items.Add((subgroupDatatable.Rows[i]["GroupID"]));
            }


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("LecturerUnavailabilityAdd", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_TID", tid1);
                mySqlCmd.Parameters.AddWithValue("_Lecturer_Name", visalcmbmodulename.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Time_slot", visalcmdtimeslot.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Day", visalcmbday.Text.Trim());


                if(visalcmbday.Text.Trim()==""|| visalcmdtimeslot.Text.Trim()==""|| visalcmbmodulename.Text.Trim()=="")
                {
                    MessageBox.Show("Fields Can not be null!");
                }
                else
                {
                    mySqlCmd.ExecuteNonQuery();

                    clearlecdet();
                    fillTagGridlecdet();
                    MessageBox.Show(" Added Successfully");
                }
               

            }
        }
        public void fillTagGridlecdet()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("LecturerUnavailabilityViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTags = new DataTable();
                sqlDa.Fill(dataTags);
                visalmudataGridView1.DataSource = dataTags;
            }

        }
        public void clearlecdet()
        {
            visalcmbmodulename.Text = "";
            visalcmdtimeslot.Text = "";
            visalcmbday.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("SessionUnavailabilityAdd", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_STID", tid2);
                mySqlCmd.Parameters.AddWithValue("_Module_Name", visalusmodulenamecmb.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Time_Slot", visalustimeslotcmb.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Day", visalusdatecmb.Text.Trim());


                if (visalusmodulenamecmb.Text.Trim() == "" || visalustimeslotcmb.Text.Trim() == "" || visalusdatecmb.Text.Trim() == "")
                {
                    MessageBox.Show("Fields Can not be null!");
                }
                else
                {
                    mySqlCmd.ExecuteNonQuery();

                    clearsessiondet();
                    fillTagGridsessiondet();
                    MessageBox.Show(" Added Successfully");
                }


            }
        }
        public void fillTagGridsessiondet()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SessionUnavailabilityViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTags = new DataTable();
                sqlDa.Fill(dataTags);
                visalmudataGridView2.DataSource = dataTags;
            }

        }
        public void clearsessiondet()
        {
            visalusmodulenamecmb.Text = "";
            visalustimeslotcmb.Text = "";
            visalusdatecmb.Text = "";
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
           
        }

        private void visalbtnmu_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("groupUnavailabilityAdd", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_GTID", tid3);
                mySqlCmd.Parameters.AddWithValue("_Group", visalcmdmugsgroup.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Sub_group", visalcmdmugssubgroup.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Timeslot", visalcmdmugstimeslot.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Day", visalcmdmugsdate.Text.Trim());


                if (visalcmdmugstimeslot.Text.Trim() == "" || visalcmdmugsdate.Text.Trim() == "" ||(visalcmdmugsgroup.Text.Trim() == "" && visalcmdmugssubgroup.Text.Trim() == ""))
                {
                    MessageBox.Show("Fields Can not be null!");
                }
                else
                {
                    mySqlCmd.ExecuteNonQuery();

                    cleargroupdet();
                    fillTagGridgroupdet();
                    MessageBox.Show(" Added Successfully");
                }


            }
        }
        public void fillTagGridgroupdet()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("groupUnavailabilityViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTags = new DataTable();
                sqlDa.Fill(dataTags);
                visalmudataGridView3.DataSource = dataTags;
            }

        }
        public void cleargroupdet()
        {
            visalcmdmugsgroup.Text = "";
            visalcmdmugssubgroup.Text = "";
            visalcmdmugstimeslot.Text = "";
            visalcmdmugsdate.Text = "";
        }
    }
}
