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
    public partial class Section4_roomsessions_popup : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int sessionID = 0;
        string lecname = "";
        string groupid = "";
        string subgroupid = "";
        string time = "";
        string day = "";
        string tag = "";
        string module = "";

        public Section4_roomsessions_popup()
        {
            InitializeComponent();
            fillroomCombobox();
            fillsessionpopupGrid();
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
                        nishikicmbsesroomname.Items.Add(read.GetValue(0).ToString());
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
        void fillsessionpopupGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                String query = "select s.sessionID, s.Lecturer_name, s.Group_ID, s.Subgroup_ID, s.Location, s.Timeslot, s.Day, s.Tag, s.Module from sessions s, c_session c where s.sessionID != c.ConsecutiveSes_01 and s.sessionID != c.ConsecutiveSes_02";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, mySqlCon);
                DataTable dataLocations = new DataTable();
                dataadapter.Fill(dataLocations);
                nihsikidgvsesroomdisplay.DataSource = dataLocations;
                nihsikidgvsesroomdisplay.Columns[0].Visible = false;
            }
        }

        private void Nihsikidgvsesroomdisplay_DoubleClick(object sender, EventArgs e)
        {
            if (nihsikidgvsesroomdisplay.CurrentRow.Index != -1)
            {
                sessionID = Convert.ToInt32(nihsikidgvsesroomdisplay.CurrentRow.Cells[0].Value.ToString());
                //lecname = nihsikidgvsesroomdisplay.CurrentRow.Cells[1].Value.ToString();
                //groupid = nihsikidgvsesroomdisplay.CurrentRow.Cells[2].Value.ToString();
                //subgroupid = nihsikidgvsesroomdisplay.CurrentRow.Cells[3].Value.ToString();
                //time = nihsikidgvsesroomdisplay.CurrentRow.Cells[4].Value.ToString();
                //day = nihsikidgvsesroomdisplay.CurrentRow.Cells[5].Value.ToString();
                //tag = nihsikidgvsesroomdisplay.CurrentRow.Cells[6].Value.ToString();
                //module = nihsikidgvsesroomdisplay.CurrentRow.Cells[7].Value.ToString();
                nishikisessubroom.Text = nihsikidgvsesroomdisplay.CurrentRow.Cells[8].Value.ToString();
                
            }

        }

        private void Btnnishikisesaddrooms_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                string room = nishikicmbsesroomname.SelectedItem.ToString();
                //int sessionID = Convert.ToInt32(nihsikidgvsesroomdisplay.CurrentRow.Cells[0].Value.ToString());

                mySqlCon.Open();
                String query = "UPDATE sessions SET Location = '"+room+"' WHERE sessionID = "+sessionID+";";

                Console.WriteLine(query);

                //MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, mySqlCon);
                //DataTable dataLocations = new DataTable();
                //dataadapter.Fill(dataLocations);
                //nihsikidgvsesroomdisplay.DataSource = dataLocations;
                //nihsikidgvsesroomdisplay.Columns[0].Visible = false;
                MySqlCommand cmd = new MySqlCommand(query, mySqlCon);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Location Added Successfully for the subject,  " + nishikisessubroom.Text);
                this.Dispose();


                //mySqlCon.Open();
                //MySqlCommand mySqlCmd = new MySqlCommand("room_addsessionroom", mySqlCon);
                //mySqlCmd.CommandType = CommandType.StoredProcedure;
                //mySqlCmd.Parameters.AddWithValue("_sesID", sessionID);
                //mySqlCmd.Parameters.AddWithValue("_lecname", lecname);
                //mySqlCmd.Parameters.AddWithValue("_Groupid", groupid);
                //mySqlCmd.Parameters.AddWithValue("_subgroupid", subgroupid);
                //mySqlCmd.Parameters.AddWithValue("_time", time);
                //mySqlCmd.Parameters.AddWithValue("_day", day);
                //mySqlCmd.Parameters.AddWithValue("_tag", tag);
                //mySqlCmd.Parameters.AddWithValue("_module", module);
                //mySqlCmd.Parameters.AddWithValue("_room", nishikicmbsesroomname.SelectedItem);
                //mySqlCmd.ExecuteNonQuery();

                ////clearInputs();
                ////fillLocationGrid();
                //MessageBox.Show("Location Added Successfully for the subject,  "+ nishikisessubroom.Text);

                //this.Dispose();

            }
        }
    }
}
