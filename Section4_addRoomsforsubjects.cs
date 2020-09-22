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
    public partial class Section4_addRoomsforsubjects : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";

        public Section4_addRoomsforsubjects()
        {
            InitializeComponent();
            fillLocationGrid();
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
                String query = "Select * from room_subjects";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, mySqlCon);
                //MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                DataTable dataLocations = new DataTable();
                dataadapter.Fill(dataLocations);
                dgvnishikisubjectsrooms.DataSource = dataLocations;
                dgvnishikisubjectsrooms.Columns[0].Visible = false;
            }
        }

        private void Section4_addRoomsforsubjects_Load(object sender, EventArgs e)
        {

        }

        private void Nishikistatimg_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnnishikiaddsubrooms_Click(object sender, EventArgs e)
        {
            Section4_roomsubjectspopup tags = new Section4_roomsubjectspopup();

            tags.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            fillLocationGrid();
        }
    }
}
