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
    public partial class Section4_addRoomsforsessions : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";

        public Section4_addRoomsforsessions()
        {
            InitializeComponent();
            fillsessionGrid();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void fillsessionGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                String query = "select s.GroupID, s.Tag, s.SubCode, s.Room, s.StudentCount, s.Duration, l.lecturerName, l.fac, l.dept, l.building from mydb.sessions s, mydb.session_lecturers l where s.sessionID = l.sessionID";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, mySqlCon);
                DataTable dataLocations = new DataTable();
                dataadapter.Fill(dataLocations);
                dgvnishikisessionrooms.DataSource = dataLocations;
            }
        }
        private void Btnnishikiaddsessionrooms_Click(object sender, EventArgs e)
        {
            Section4_roomsessions_popup ses = new Section4_roomsessions_popup();

            ses.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            fillsessionGrid();
        }
    }
}
