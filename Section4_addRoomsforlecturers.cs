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
    public partial class Section4_addRoomsforlecturers : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";

        public Section4_addRoomsforlecturers()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void fillLocationGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                String query = "Select * from room_lecturer";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, mySqlCon);
                DataTable dataLocations = new DataTable();
                dataadapter.Fill(dataLocations);
                dgvnishikilecturerssrooms.DataSource = dataLocations;
                dgvnishikilecturerssrooms.Columns[0].Visible = false;
            }
        }

        private void Btnnishikiaddlecturerrooms_Click(object sender, EventArgs e)
        {
            Section4_roomlecturerpopup lec = new Section4_roomlecturerpopup();

            lec.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            fillLocationGrid();
        }
    }
}
