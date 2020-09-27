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
    public partial class Section4_roomsubjects_popup : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int subID = 0;

        public Section4_roomsubjects_popup()
        {
            InitializeComponent();
            filltagsCombobox();
            fillroomsCombobox();
        }

        void fillsubcombobox()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    String year = nishikicmbsubyearrooms.SelectedItem.ToString();
                    String sem = nishikicmbsubsemrooms.SelectedItem.ToString();


                    String query = "select s.name from subject s where year = " + year + " and semester = " + sem;

                    Console.WriteLine(query);

                    MySqlCommand sql = new MySqlCommand(query, mySqlCon);
                    MySqlDataReader read;

                    try
                    {
                        mySqlCon.Open();
                        read = sql.ExecuteReader();

                        while (read.Read())
                        {
                            nishikicmbsubsubjectrooms.Items.Add(read.GetValue(0).ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Choose year and semester from the dropdown");
                }
            }
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
                        nishikicmbsubtagsrooms.Items.Add(read.GetValue(1).ToString());
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
                        txtnishikisubroomname.Items.Add(read.GetValue(0).ToString());
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

        private void Nishikicmbsubsubjectrooms_Click(object sender, EventArgs e)
        {
            //fillsubcombobox();
        }

        private void Nishikicmbsubsubjectrooms_DropDown(object sender, EventArgs e)
        {
            //fillsubcombobox();
        }

        private void Nishikicmbsubsubjectrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fillsubcombobox();
        }

        private void Nishikicmbsubsubjectrooms_MouseClick(object sender, MouseEventArgs e)
        {
            //fillsubcombobox();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            fillsubcombobox();
        }

        void clearInputs()
        {
            subID = 0;
            nishikicmbsubyearrooms.Text = "";
            nishikicmbsubsemrooms.Text = "";
            nishikicmbsubsubjectrooms.Text = "";
            nishikicmbsubtagsrooms.Text = "";
            txtnishikisubroomname.Text = "";

        }

        private void Btnnishikisubaddrooms_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("room_subjectsAdd", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_subID", subID);
                mySqlCmd.Parameters.AddWithValue("_year", nishikicmbsubyearrooms.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_sem", nishikicmbsubsemrooms.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_sub", nishikicmbsubsubjectrooms.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_tag", nishikicmbsubtagsrooms.SelectedItem);
                mySqlCmd.Parameters.AddWithValue("_room", txtnishikisubroomname.SelectedItem);
                mySqlCmd.ExecuteNonQuery();

                String sub = nishikicmbsubsubjectrooms.SelectedItem.ToString();

                clearInputs();
                MessageBox.Show("Room Added for the subject, " + sub + " Successfully!!");

                this.Dispose();
            }
        }
    }
}
