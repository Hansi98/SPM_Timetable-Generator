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
    public partial class Section4_roomgroups_popup : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int groupID = 0;

        public Section4_roomgroups_popup()
        {
            InitializeComponent();
            fillgroupsCombobox();
        }

        void fillgroupsCombobox()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                String query = "Select * from groupinfo";

                MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                MySqlDataReader read;

                try
                {
                    mySqlCon.Open();
                    read = sql.ExecuteReader();

                    while (read.Read())
                    {
                        nishikicmbsubyearrooms.Items.Add(read.GetValue(4).ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



            }
        }

        void fillgrouproomcombobox()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    int count = Convert.ToInt32(txtcapacitysub.Text);
                    Console.WriteLine(count);
                    String query = "select Room from locations where Capacity > "+count;

                    Console.WriteLine(query);

                    MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                    MySqlDataReader read;

                    try
                    {
                        mySqlCon.Open();
                        read = sql.ExecuteReader();

                        while (read.Read())
                        {
                            nishikicmbgroupsrooms.Items.Add(read.GetValue(0).ToString());
                        }
                        MessageBox.Show("Rooms are loaded!");
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

        private void Nishikicmbsubyearrooms_Click(object sender, EventArgs e)
        {
            //txtcapacitysub.Text = "120";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nishikicmbsubyearrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcapacitysub.Text = "120";
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            fillgrouproomcombobox();
            
        }

        private void Nishikicmbgroupsrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        void clearInputs()
        {
            groupID = 0;
            nishikicmbsubyearrooms.Text = "";
            txtcapacitysub.Text = "";
            nishikicmbgroupsrooms.Text = "";
            nishikicmbgroupbuilding.Text = "";

        }
        private void Btnnishikisubaddrooms_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("room_groupAdd", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_groupID", groupID);
                mySqlCmd.Parameters.AddWithValue("_groupname", nishikicmbsubyearrooms.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_stdcount", txtcapacitysub.Text);
                mySqlCmd.Parameters.AddWithValue("_room", nishikicmbgroupsrooms.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_building", nishikicmbgroupbuilding.SelectedItem);
                mySqlCmd.ExecuteNonQuery();

                String group = nishikicmbsubyearrooms.SelectedItem.ToString();

                clearInputs();
                MessageBox.Show("Room Added for the group, " + group + " Successfully!!");

                this.Dispose();
            }
        }
    }
}
