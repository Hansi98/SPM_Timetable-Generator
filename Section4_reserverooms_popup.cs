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
    public partial class Section4_reserverooms_popup : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int reserveroom = 0;

        public Section4_reserverooms_popup()
        {
            InitializeComponent();
            fillroomsCombobox();
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
                        nishikicmbreserveroomsrooms.Items.Add(read.GetValue(0).ToString());
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
            reserveroom = 0;
            nishikicmbreserveroomsrooms.Text = "";
            nishikicmbbuildingsreserveroom.Text = "";
            nishikimtbfreserveroom.Text = "";
            cmbfampm.Text = "";
            nishikimtblreserveroom.Text = "";
            cmblampm.Text = "";
            nishikitxtreserveroomreason.Text = "";
        }

        private void Nishikibtnaddreserverooms_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("room_reserveroomsAdd", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_reserveroomID", reserveroom);
                mySqlCmd.Parameters.AddWithValue("_room", nishikicmbreserveroomsrooms.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_building", nishikicmbbuildingsreserveroom.SelectedItem);

                string date = nishikidtpreserveroom.Value.ToShortDateString();
                

                mySqlCmd.Parameters.AddWithValue("_date", date);

                String stime = nishikimtbfreserveroom.Text + cmbfampm.SelectedItem;
                String etime = nishikimtblreserveroom.Text + cmblampm.SelectedItem;

                mySqlCmd.Parameters.AddWithValue("_stime", stime);
                mySqlCmd.Parameters.AddWithValue("_etime", etime);
                mySqlCmd.Parameters.AddWithValue("_reason", nishikitxtreserveroomreason.Text);
                mySqlCmd.ExecuteNonQuery();

                string room = nishikicmbreserveroomsrooms.SelectedItem.ToString();

                clearInputs();
                MessageBox.Show("Room "+room+" Reserved Successfully");

                this.Dispose();

            }
        }
    }
}
