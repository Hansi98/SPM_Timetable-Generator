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
    public partial class Section4_roomssubgroupspopup : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int subgroupID = 0;

        public Section4_roomssubgroupspopup()
        {
            InitializeComponent();
            fillsubgroupCombobox();
        }

        void fillsubgroupCombobox()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                String query = "Select * from subgroupinfo";

                MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                MySqlDataReader read;

                try
                {
                    mySqlCon.Open();
                    read = sql.ExecuteReader();

                    while (read.Read())
                    {
                        nishikicmbsubyearrooms.Items.Add(read.GetValue(5).ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nishikicmbsubyearrooms_Click(object sender, EventArgs e)
        {
            //txtcapacitygroup.Text = "60";
        }

        private void Nishikicmbsubyearrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcapacitygroup.Text = "60";
        }

        void fillsubgrouproomcombobox()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    int count = Convert.ToInt32(txtcapacitygroup.Text);
                    Console.WriteLine(count);

                    String query = "select Room from locations where Capacity > " + count;

                    Console.WriteLine(query);

                    MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                    MySqlDataReader read;

                    try
                    {
                        mySqlCon.Open();
                        read = sql.ExecuteReader();

                        while (read.Read())
                        {
                            nishikicmbsubgrproomname.Items.Add(read.GetValue(0).ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Choose a group from the dropdown");
                }
            }
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            fillsubgrouproomcombobox();
            MessageBox.Show("Rooms are loaded!");
        }
        void clearInputs()
        {
            subgroupID = 0;
            nishikicmbsubyearrooms.Text = "";
            txtcapacitygroup.Text = "";
            nishikicmbsubgrproomname.Text = "";
            nishikicmbsubgrpbuilding.Text = "";

        }
        private void Btnnishikisubaddrooms_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("room_subgroupAdd", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_subgroupID", subgroupID);
                mySqlCmd.Parameters.AddWithValue("_subgroupname", nishikicmbsubyearrooms.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_stdcount", txtcapacitygroup.Text);
                mySqlCmd.Parameters.AddWithValue("_room", nishikicmbsubgrproomname.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_building", nishikicmbsubgrpbuilding.SelectedItem);
                mySqlCmd.ExecuteNonQuery();

                String subgroup = nishikicmbsubyearrooms.SelectedItem.ToString();

                clearInputs();
                MessageBox.Show("Room Added for the sub-group, " + subgroup + " Successfully!!");

                this.Dispose();
            }
        }
    }
}
