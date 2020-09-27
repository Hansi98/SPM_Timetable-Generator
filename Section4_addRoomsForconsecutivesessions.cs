using MySql.Data.MySqlClient;
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

namespace ABC_Institute___Timetable_Generator
{
    public partial class Section4_addRoomsForconsecutivesessions : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";

        public Section4_addRoomsForconsecutivesessions()
        {
            InitializeComponent();
            fillconsecsessionGrid();
            
        }

        void fillconsecsessionGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                String query = "select s.sessionID, s.Lecturer_name, s.Group_ID, s.Subgroup_ID, s.Location, s.Timeslot, s.Day, s.Tag, s.Module from sessions s, c_session c where s.sessionID = c.ConsecutiveSes_01 or s.sessionID = c.ConsecutiveSes_02";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, mySqlCon);
                DataTable dataLocations = new DataTable();
                dataadapter.Fill(dataLocations);
                dgvnishikiconsecsessionsrooms.DataSource = dataLocations;
                dgvnishikiconsecsessionsrooms.Columns[0].Visible = false;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void Btnnishikiaddlecturerrooms_Click(object sender, EventArgs e)
        {
            Section4_roomconsecsession_popup consecses = new Section4_roomconsecsession_popup();
            consecses.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            fillconsecsessionGrid();
        }
    }
    }

