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
    public partial class Section4_roomlecturer_popup : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int lecID = 0;

        public Section4_roomlecturer_popup()
        {
            InitializeComponent();
            filllecturerCombobox();
            fillroomCombobox();
        }

        void filllecturerCombobox()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                String query = "Select * from lecturer";

                MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                MySqlDataReader read;

                try
                {
                    mySqlCon.Open();
                    read = sql.ExecuteReader();

                    while (read.Read())
                    {
                        nishikicmblecturerrooms.Items.Add(read.GetValue(1).ToString() + " " + read.GetValue(3).ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



            }
        }

        void fillroomCombobox()
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
                        txtnishikilecroomname.Items.Add(read.GetValue(0).ToString());
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

        void clearInputs()
        {
            lecID = 0;
            nishikicmblecturerrooms.Text = "";
            txtnishikilecroomname.Text = "";

        }
        private void Nishikibtnaddlecrooms_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("room_lecturerAdd", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_lecID", lecID);
                mySqlCmd.Parameters.AddWithValue("_lec", nishikicmblecturerrooms.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_room", txtnishikilecroomname.SelectedItem);
                mySqlCmd.ExecuteNonQuery();

                string lec = nishikicmblecturerrooms.SelectedItem.ToString();

                clearInputs();
                MessageBox.Show("Room is Added for the lecturer, " +lec+ " Successfully");

                this.Dispose();

            }
        }
    }
}
