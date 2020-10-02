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
    public partial class Section5_AddDayTimeslot_Grp : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int daytimesession = 0;


        public Section5_AddDayTimeslot_Grp()
        {
            InitializeComponent();
            fillTimetableGrid_grp();
        }

        private void hansi_daytimeAdd_grp_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                string timeslot = hansi_timetableslot_grp.SelectedItem.ToString();
                string day = hansi_timetableday_grp.SelectedItem.ToString();

                mySqlCon.Open();
                String query = "UPDATE sessions SET Day = '" + day + "', Time = '" + timeslot + "' WHERE sessionID = " + daytimesession + "";

                Console.WriteLine(query);

                MySqlCommand cmd = new MySqlCommand(query, mySqlCon);
                cmd.ExecuteNonQuery();

                clearInputs();
                MessageBox.Show("Day and Timeslots added successfully!");

                this.Dispose();

            }
        }

        void fillTimetableGrid_grp()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("TimetableViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTimeLec = new DataTable();
                sqlDa.Fill(dataTimeLec);
                hansi_adddaytimetablegrid_grp.DataSource = dataTimeLec;
                hansi_adddaytimetablegrid_grp.Columns[0].Visible = false;
            }
        }


        public void hansi_daytimeAdd_grp_DoubleClick(object sender, EventArgs e)
        {
            if (hansi_adddaytimetablegrid_grp.CurrentRow.Index != -1)
            {
                daytimesession = Convert.ToInt32(hansi_adddaytimetablegrid_grp.CurrentRow.Cells[0].Value.ToString());
                hansi_daytimeslotname_grp.Text = hansi_adddaytimetablegrid_grp.CurrentRow.Cells[1].Value.ToString();
            }
        }


        private void hansi_daytimeAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                string timeslot = hansi_timetableslot_grp.SelectedItem.ToString();
                string day = hansi_timetableday_grp.SelectedItem.ToString();

                mySqlCon.Open();
                String query = "UPDATE sessions SET Day = '" + day + "', Time = '" + timeslot + "' WHERE sessionID = " + daytimesession + "";

                Console.WriteLine(query);

                MySqlCommand cmd = new MySqlCommand(query, mySqlCon);
                cmd.ExecuteNonQuery();

                clearInputs();
                MessageBox.Show("Day and Timeslots added successfully!");

                this.Dispose();

            }
        }

        void clearInputs()
        {
            daytimesession = 0;
            hansi_timetableslot_grp.Text = "";
            hansi_timetableday_grp.Text = "";
            hansi_daytimeslotname_grp.Text = "";

        }


        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

    }
}
