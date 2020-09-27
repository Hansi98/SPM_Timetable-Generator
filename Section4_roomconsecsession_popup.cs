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
    public partial class Section4_roomconsecsession_popup : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int consecsessionID = 0;

        public Section4_roomconsecsession_popup()
        {
            InitializeComponent();
            fillconsecsessionGrid();
            fillroomCombobox();
            loadlecNames();
        }
        void fillconsecsessionGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                String query = "select s.sessionID, s.Lecturer_name, s.Group_ID, s.Subgroup_ID, s.Location, s.Timeslot, s.Day, s.Tag, s.Module from sessions s, c_session c where s.sessionID = c.ConsecutiveSes_01 or s.sessionID = c.ConsecutiveSes_02";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, mySqlCon);
                DataTable dataLocations = new DataTable();
                dataadapter.Fill(dataLocations);
                nihsikidgvconsecsesroomdisplay.DataSource = dataLocations;
                nihsikidgvconsecsesroomdisplay.Columns[0].Visible = false;
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
                        nishikicmbconsecsesroomname.Items.Add(read.GetValue(0).ToString());
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

        private void Nihsikidgvconsecsesroomdisplay_DoubleClick(object sender, EventArgs e)
        {
            if (nihsikidgvconsecsesroomdisplay.CurrentRow.Index != -1)
            {
                consecsessionID = Convert.ToInt32(nihsikidgvconsecsesroomdisplay.CurrentRow.Cells[0].Value.ToString());
                nishikiconsecseslecroom.Text = nihsikidgvconsecsesroomdisplay.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void Btnnishikiconsecsesaddrooms_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                string room = nishikicmbconsecsesroomname.SelectedItem.ToString();
                
                mySqlCon.Open();
                String query = "UPDATE sessions SET Location = '"+room+"' WHERE sessionID = "+consecsessionID+"";

                Console.WriteLine(query);

                MySqlCommand cmd = new MySqlCommand(query, mySqlCon);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Location Added Successfully");
                this.Dispose();



            }
        }

        void loadlecNames()
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
                        nishikicmbsearchconsecbylec.Items.Add(read.GetValue(1).ToString() + " " + read.GetValue(3).ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
          private void Searchconsecses_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                string lec = nishikicmbsearchconsecbylec.SelectedItem.ToString();

                mySqlCon.Open();
                String query = "select s.sessionID, s.Lecturer_name, s.Group_ID, s.Subgroup_ID, s.Location, s.Timeslot, s.Day, s.Tag, s.Module from mydb.sessions s, mydb.c_session c where s.sessionID = c.ConsecutiveSes_01 or s.sessionID = c.ConsecutiveSes_02 and Lecturer_name = '"+lec+"'";
                
                Console.WriteLine(query);

                MySqlCommand cmd = new MySqlCommand(query, mySqlCon);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Filtered "+lec+"'s sessions!");
                this.Dispose();



            }
        }
    }
}
