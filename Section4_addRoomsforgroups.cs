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
    public partial class Section4_addRoomsforgroups : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";

        public Section4_addRoomsforgroups()
        {
            InitializeComponent();
            fillgroupGrid();
            fillsubgroupGrid();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        void fillgroupGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
              
                mySqlCon.Open();
                String query = "Select * from room_groups";
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, mySqlCon);
                DataTable dataLocations = new DataTable();
                dataadapter.Fill(dataLocations);


                //string count;
                //MySqlCommand mySqlCmd = new MySqlCommand("test", mySqlCon);
                //mySqlCmd.CommandType = CommandType.StoredProcedure;
                //count = mySqlCmd.ExecuteScalar().ToString();

                //Console.WriteLine(count);

                dgvnishikigroupsrooms.DataSource = dataLocations;
                dgvnishikigroupsrooms.Columns[0].Visible = false;
            }
        }

        void fillsubgroupGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                String query = "Select * from room_subgroups";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, mySqlCon);
                DataTable dataLocations = new DataTable();
                dataadapter.Fill(dataLocations);
                dgvnishikisubgroupsrooms.DataSource = dataLocations;
                dgvnishikisubgroupsrooms.Columns[0].Visible = false;
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            fillgroupGrid();
        }

        private void Btnnishikiaddgroupsrooms_Click(object sender, EventArgs e)
        {
            Section4_roomgroups_popup groups = new Section4_roomgroups_popup();

            groups.ShowDialog();
        }

        private void Btnnishikiaddsubgroupsrooms_Click(object sender, EventArgs e)
        {
            Section4_roomssubgroups_popup subgroups = new Section4_roomssubgroups_popup();

            subgroups.ShowDialog();
        }
       
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            fillsubgroupGrid();
        }
    }
}
