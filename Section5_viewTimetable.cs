using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MySql.Data.MySqlClient;

namespace ABC_Institute___Timetable_Generator
{
    public partial class Section5_viewTimetable : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int daytimesession = 0;
        int daytimesession_grp = 0;
        int daytimesession_room = 0;

        public Section5_viewTimetable()
        {
            InitializeComponent();
            fillLecTimetableGrid();
            fillGrpTimetableGrid();
            fillRoomTimetableGrid();

            filllecturerCombobox();
            fillRoomCombobox();
            fillGroupCombobox();
        }

            string lecturer_name;

        public string Lecturer_name {
            get => lecturer_name;
            set => lecturer_name = HansiTimetable_lec.SelectedItem.ToString(); }
    
        Section5_LecTimetable lec = new Section5_LecTimetable();


        string group_name;

        public string Group_name
        {
            get => group_name;
            set => group_name = HansiTimetable_grp.SelectedItem.ToString();
        }

        Section5_GroupTimetable grp = new Section5_GroupTimetable();

        string room_name;

        public string Room_name
        {
            get => room_name;
            set => room_name = HansiTimetable_room.SelectedItem.ToString();
        }

        Section5_RoomTimetable room = new Section5_RoomTimetable();


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void filllecturerCombobox()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
               
                String query = "Select * from session_lecturers";

                MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                MySqlDataReader read;

                try
                {
                    mySqlCon.Open();
                    read = sql.ExecuteReader();

                    while (read.Read())
                    {
                        HansiTimetable_lec.Items.Add(read.GetValue(2).ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("No Sessions allocated for the selected Lecturer");
                    this.Dispose();
                }

            }
        }


        void fillRoomCombobox()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                String query = "Select * from locations";

                MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                MySqlDataReader read;

                try
                {
                    mySqlCon.Open();
                    read = sql.ExecuteReader();

                    while (read.Read())
                    {
                        HansiTimetable_room.Items.Add(read.GetValue(2).ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("No Sessions allocated for the selected Room");
                    this.Dispose();
                }

            }
        }

        void fillGroupCombobox()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                String query = "Select * from sessions";

                MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                MySqlDataReader read;

                try
                {
                    mySqlCon.Open();
                    read = sql.ExecuteReader();

                    while (read.Read())
                    {
                        HansiTimetable_grp.Items.Add(read.GetValue(1).ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("No Sessions allocated for the selected Group ID");
                    this.Dispose();
                }

            }
        }

        private void hansiwork_daystable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillLecTimetableGrid();
        }

        public void fillLecTimetableGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("TimetableViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTimeLec = new DataTable();
                sqlDa.Fill(dataTimeLec);
                hansi_timelectable.DataSource = dataTimeLec;
                hansi_timelectable.Columns[0].Visible = false;

            }
        }

        private void hansi_timelectable_DoubleClick(object sender, EventArgs e)
        {
            if (hansi_timelectable.SelectedRows.Count != -1)
            {
              
                daytimesession = Convert.ToInt32(hansi_timelectable.CurrentRow.Cells[0].Value.ToString());
                Section5_AddDayTimeslot slot = new Section5_AddDayTimeslot();
                slot.ShowDialog();

            }
        }

        private void hansi_timegrptable_DoubleClick(object sender, EventArgs e)
        {
            if (hansi_timegrptable.SelectedRows.Count != -1)
            {

                daytimesession_grp = Convert.ToInt32(hansi_timegrptable.CurrentRow.Cells[0].Value.ToString());
                Section5_AddDayTimeslot_Grp slot = new Section5_AddDayTimeslot_Grp();
                slot.ShowDialog();

            }
        }

        private void hansi_timeRoomtable_DoubleClick(object sender, EventArgs e)
        {
            if (hansi_timeRoomtable.SelectedRows.Count != -1)
            {

                daytimesession_room = Convert.ToInt32(hansi_timeRoomtable.CurrentRow.Cells[0].Value.ToString());
                Section5_AddDayTimeslot_Room slot = new Section5_AddDayTimeslot_Room();
                slot.ShowDialog();

            }
        }

        private void hansi_timegrptable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillGrpTimetableGrid();
        }

        public void fillGrpTimetableGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("TimetableViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTimeLec = new DataTable();
                sqlDa.Fill(dataTimeLec);
                hansi_timegrptable.DataSource = dataTimeLec;
            }
        }

        public void fillRoomTimetableGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("TimetableViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTimeLec = new DataTable();
                sqlDa.Fill(dataTimeLec);
                hansi_timeRoomtable.DataSource = dataTimeLec;
            }
        }

        private void HansiTimetable_Lecdown_Click(object sender, EventArgs e)
        {
            Section5_ViewLecTimetable timetable = new Section5_ViewLecTimetable(HansiTimetable_lec.SelectedItem.ToString());
            timetable.ShowDialog();
        }

      
        private void HansiTimetable_Addgrp_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("grpTimetableSearch", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_searchString", HansiTimetable_grp.SelectedItem);
                Console.WriteLine(HansiTimetable_grp.SelectedItem);
                DataTable dataLocations = new DataTable();
                sqlDa.Fill(dataLocations);
                hansi_timegrptable.DataSource = dataLocations;
                hansi_timegrptable.Columns[0].Visible = false;
            }
        }

        private void HansiTimetable_roomadd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("roomTimetableSearch", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_searchString", HansiTimetable_room.SelectedItem);
                DataTable dataLocations = new DataTable();
                sqlDa.Fill(dataLocations);
                hansi_timeRoomtable.DataSource = dataLocations;
                hansi_timeRoomtable.Columns[0].Visible = false;
            }
        }

        private void HansiTimetable_Addlec_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("lecTimetableSearch", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_searchString", HansiTimetable_lec.SelectedItem);
                DataTable dataLocations = new DataTable();
                sqlDa.Fill(dataLocations);
                hansi_timelectable.DataSource = dataLocations;
                hansi_timelectable.Columns[0].Visible = false;
            }
        }

     

        private void HansiTimetable_grpDown_Click(object sender, EventArgs e)
        {          
                Section5_ViewGrpTimetable timetablegrp = new Section5_ViewGrpTimetable(HansiTimetable_grp.SelectedItem.ToString());
                timetablegrp.ShowDialog();
        }

        private void HansiTimetable_RoomDown_Click(object sender, EventArgs e)
        {
              Section5_ViewRoomTimetable timetableroom = new Section5_ViewRoomTimetable(HansiTimetable_room.SelectedItem.ToString());
                timetableroom.ShowDialog();

        }

        private void hansi_timeRoomtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillRoomTimetableGrid();
        }

        private void hansi_timelectable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillLecTimetableGrid();
        }
    }
    }
    