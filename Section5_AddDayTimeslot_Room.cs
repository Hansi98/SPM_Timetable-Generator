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
    public partial class Section5_AddDayTimeslot_Room : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int daytimesession_room = 0;

        public Section5_AddDayTimeslot_Room()
        {
            InitializeComponent();
            fillTimetableGrid_Room();
        }

        void fillTimetableGrid_Room()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("TimetableViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTimeLec = new DataTable();
                sqlDa.Fill(dataTimeLec);
                hansi_adddaytimetablegrid_room.DataSource = dataTimeLec;
                hansi_adddaytimetablegrid_room.Columns[0].Visible = false;
            }
        }

        void clearInputs()
        {
            daytimesession_room = 0;
            hansi_timetableslot_room.Text = "";
            hansi_timetableday_room.Text = "";
            hansi_daytimeslotname_room.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        public void hansi_daytimeAdd_room_DoubleClick(object sender, EventArgs e)
        {
            if (hansi_adddaytimetablegrid_room.CurrentRow.Index != -1)
            {
                daytimesession_room = Convert.ToInt32(hansi_adddaytimetablegrid_room.CurrentRow.Cells[0].Value.ToString());
                hansi_daytimeslotname_room.Text = hansi_adddaytimetablegrid_room.CurrentRow.Cells[1].Value.ToString();
            }
        }


        private void hansi_daytimeAdd_room_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                string timeslot = hansi_timetableslot_room.SelectedItem.ToString();
                string day = hansi_timetableday_room.SelectedItem.ToString();

                mySqlCon.Open();
                String query = "UPDATE sessions SET Day = '" + day + "', Time = '" + timeslot + "' WHERE sessionID = " + daytimesession_room + "";

                Console.WriteLine(query);

                MySqlCommand cmd = new MySqlCommand(query, mySqlCon);
                cmd.ExecuteNonQuery();

                clearInputs();
                MessageBox.Show("Day and Timeslots added successfully!");

                this.Dispose();

            }
        }
    }
}
