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
    public partial class Section5_AddDayTimeslot : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int daytimesession = 0;

        public Section5_AddDayTimeslot()
        {
            InitializeComponent();
            fillTimetableGrid();
        }


       
        public void hansi_adddaytimetablegrid_DoubleClick(object sender, EventArgs e)
        {
            if (hansi_adddaytimetablegrid.CurrentRow.Index != -1)
            {
                daytimesession = Convert.ToInt32(hansi_adddaytimetablegrid.CurrentRow.Cells[0].Value.ToString());
                hansi_daytimeslotname.Text = hansi_adddaytimetablegrid.CurrentRow.Cells[1].Value.ToString();
            }
        }


        private void hansi_daytimeAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                string timeslot = hansi_timetableslot.SelectedItem.ToString();
                string day = hansi_timetableday.SelectedItem.ToString();

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

        void fillTimetableGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("TimetableViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTimeLec = new DataTable();
                sqlDa.Fill(dataTimeLec);
                hansi_adddaytimetablegrid.DataSource = dataTimeLec;
                hansi_adddaytimetablegrid.Columns[0].Visible = false;
            }
        }

        void clearInputs()
        {
            daytimesession = 0;
            hansi_timetableslot.Text = "";
            hansi_timetableday.Text = "";
            hansi_daytimeslotname.Text = "";

        }


        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

      
    }
}
