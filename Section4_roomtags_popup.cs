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
    public partial class Section4_roomtags_popup : Form
    {

        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int tagID = 0;

        public Section4_roomtags_popup()
        {
            InitializeComponent();
            filltagsCombobox();
            fillroomsCombobox();
        }

        void filltagsCombobox()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                String query = "Select * from tags";

                MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                MySqlDataReader read;

                try
                {
                    mySqlCon.Open();
                    read = sql.ExecuteReader();

                    while (read.Read())
                    {
                        nishikicmbtagsrooms.Items.Add(read.GetValue(1).ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



            }
        }

        void fillroomsCombobox()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                String query = "Select Room from locations";

                MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                MySqlDataReader read;

                try
                {
                    mySqlCon.Open();
                    read = sql.ExecuteReader();

                    while (read.Read())
                    {
                        txtnishikitagsroomname.Items.Add(read.GetValue(0).ToString());
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

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void clearInputs()
        {
            tagID = 0;
            nishikicmbtagsrooms.Text = "";
            nishikicmbbuildingstagsroom.Text = "";
            txtnishikitagsroomname.Text = "";

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("room_tagsAdd", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_tagsId", tagID);
                mySqlCmd.Parameters.AddWithValue("_tags", nishikicmbtagsrooms.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_buildingname", nishikicmbbuildingstagsroom.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_roomname", txtnishikitagsroomname.SelectedItem);
                mySqlCmd.ExecuteNonQuery();

                clearInputs();
                //fillLocationGrid();
                MessageBox.Show("Location Added Successfully");

                this.Dispose();

            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Nishikicmbtagsrooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Txtnishikitagsroomname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Roomtags_popup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
