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
    public partial class Section1_Location : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int LocationID = 0;

        public Section1_Location()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        void clearInputs()
        {
            LocationID = 0;
            nishikiDLocations_building_textBox.Text = "";
            nishikiDLocations_capacity_textBox.Text = "";
            nishikiDLocations_room_textBox.Text = "";
            nishikiDLocations_roomtype_lechallradiobtn.Checked = true;

            nishikiDLocation_btndelete.Enabled = false;

        }
        private void NishikiDLocation_btnadd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("LocationAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_LocationID", LocationID);
                mySqlCmd.Parameters.AddWithValue("_Building", nishikiDLocations_building_textBox.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Room", nishikiDLocations_room_textBox.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Capacity", nishikiDLocations_capacity_textBox.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_RoomType", nishikiDLocations_roomtype_lechallradiobtn.Checked ? "Lecture hall" : "Laboratary");
                mySqlCmd.ExecuteNonQuery();

                clearInputs();
                fillLocationGrid();
                MessageBox.Show("Location Added Successfully");

                

            }
        }

        void fillLocationGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("LocationViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataLocations = new DataTable();
                sqlDa.Fill(dataLocations);
                nishikidgvbuilding.DataSource = dataLocations;
                nishikidgvcapacity.DataSource = dataLocations;
                nishikidgvbuilding.Columns[0].Visible = false;
                nishikidgvcapacity.Columns[0].Visible = false;
            }
        }

        private void Nishikidgvbuilding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Section1_Location_Load(object sender, EventArgs e)
        {
            fillLocationGrid();
        }

        private void Nishikidgvbuilding_DoubleClick(object sender, EventArgs e)
        {
            if(nishikidgvbuilding.CurrentRow.Index != -1)
            {
                LocationID = Convert.ToInt32(nishikidgvbuilding.CurrentRow.Cells[0].Value.ToString());
                nishikiDLocations_building_textBox.Text = nishikidgvbuilding.CurrentRow.Cells[1].Value.ToString();
                nishikiDLocations_room_textBox.Text = nishikidgvbuilding.CurrentRow.Cells[2].Value.ToString();
                nishikiDLocations_capacity_textBox.Text = nishikidgvbuilding.CurrentRow.Cells[3].Value.ToString();
                String roomType = nishikidgvbuilding.CurrentRow.Cells[4].Value.ToString();

                if (roomType == "Lecture hall")
                {
                    nishikiDLocations_roomtype_lechallradiobtn.Checked = true;
                }
                else
                    nishikiDLocations_roomtype_labradiobtn.Checked = true;
            }

            nishikiDLocation_btnadd.Enabled = false;
            nishikiDLocation_btndelete.Enabled = Enabled;
        }

        private void Nishikidgvcapacity_DoubleClick(object sender, EventArgs e)
        {
            if (nishikidgvbuilding.CurrentRow.Index != -1)
            {
                LocationID = Convert.ToInt32(nishikidgvbuilding.CurrentRow.Cells[0].Value.ToString());
                nishikiDLocations_building_textBox.Text = nishikidgvbuilding.CurrentRow.Cells[1].Value.ToString();
                nishikiDLocations_room_textBox.Text = nishikidgvbuilding.CurrentRow.Cells[2].Value.ToString();
                nishikiDLocations_capacity_textBox.Text = nishikidgvbuilding.CurrentRow.Cells[3].Value.ToString();
                String roomType = nishikidgvbuilding.CurrentRow.Cells[4].Value.ToString();

                if (roomType == "Lecture hall")
                {
                    nishikiDLocations_roomtype_lechallradiobtn.Checked = true;
                }
                else
                    nishikiDLocations_roomtype_labradiobtn.Checked = true;
            }

            nishikiDLocation_btnadd.Enabled = false;
            nishikiDLocation_btndelete.Enabled = Enabled;
        }

        private void NishikiDLocation_btnupdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("LocationAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_LocationID", LocationID);
                mySqlCmd.Parameters.AddWithValue("_Building", nishikiDLocations_building_textBox.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Room", nishikiDLocations_room_textBox.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Capacity", nishikiDLocations_capacity_textBox.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_RoomType", nishikiDLocations_roomtype_lechallradiobtn.Checked ? "Lecture hall" : "Laboratary");
                mySqlCmd.ExecuteNonQuery();

                clearInputs();
                fillLocationGrid();
                MessageBox.Show("Location Details Updated Successfully!");
                nishikiDLocation_btnadd.Enabled = true;
            }
        }

        private void NishikiDLocation_btnsearchbuilding_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("LocationSearchByBuildingorRoomType", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", nishikiDLocation_buildingsearchtxtbox.Text);
                DataTable dataLocations = new DataTable();
                sqlDa.Fill(dataLocations);
                nishikidgvbuilding.DataSource = dataLocations;
                nishikidgvcapacity.DataSource = dataLocations;
                nishikidgvbuilding.Columns[0].Visible = false;
                nishikidgvcapacity.Columns[0].Visible = false;
            }
        }

        private void NishikiDLocation_btnsearchcapacity_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("LocationSearchByCapacity", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_Capacity",Convert.ToInt32( nishikiDLocation_capacitysearchtxtbox.Text));
                DataTable dataLocations = new DataTable();
                sqlDa.Fill(dataLocations);
                nishikidgvbuilding.DataSource = dataLocations;
                nishikidgvcapacity.DataSource = dataLocations;
                nishikidgvbuilding.Columns[0].Visible = false;
                nishikidgvcapacity.Columns[0].Visible = false;
            }
        }

        private void NishikiDLocation_btnrefreshbuilding_Click(object sender, EventArgs e)
        {
            fillLocationGrid();
        }

        private void NishikiDLocation_btndelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("LocationDeleteByID", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_LocationID", LocationID);

                if (MessageBox.Show("Do you want you delete this tag ?", "Message", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mySqlCmd.ExecuteNonQuery();
                }

                clearInputs();
                fillLocationGrid();
                MessageBox.Show(" Location Deleted Successfully");
                nishikiDLocation_btnadd.Enabled = true;
            }
        }

        private void NishikiDLocation_btnrefreshcapacity_Click(object sender, EventArgs e)
        {
            fillLocationGrid();
        }
    }
}
