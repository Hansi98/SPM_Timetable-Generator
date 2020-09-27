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
    public partial class Section4_reserveRoom : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";

        public Section4_reserveRoom()
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
                String query = "Select * from room_reserve";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, mySqlCon);
                //MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                DataTable dataLocations = new DataTable();
                dataadapter.Fill(dataLocations);
                dgvnishikireserverooms.DataSource = dataLocations;
                dgvnishikireserverooms.Columns[0].Visible = false;
            }
        }

        private void Btnnishikiaddreserverooms_Click(object sender, EventArgs e)
        {
            Section4_reserverooms_popup rroom = new Section4_reserverooms_popup();

            rroom.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            fillLocationGrid();
        }
    }
}
