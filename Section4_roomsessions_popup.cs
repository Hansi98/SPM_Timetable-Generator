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
        String subject = "";

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
                String query = "select s.sessionID, s.GroupID, s.Tag, s.SubCode, s.StudentCount, s.Duration, l.lecturerName, l.fac, l.dept, l.building from mydb.sessions s, mydb.session_lecturers l where s.sessionID = l.sessionID";

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
                //nishikisessubroom.Text = nihsikidgvsesroomdisplay.CurrentRow.Cells[8].Value.ToString();

                subject = nihsikidgvsesroomdisplay.CurrentRow.Cells[1].Value.ToString();

                nishikisessubroom.Text = subject;

            }

        }

        public void clear()
        {
            sessionID = 0;
            subject = "";
            nishikisessubroom.Text = "";
            nishikicmbsesroomname.Text = "";
        }

        private void Btnnishikisesaddrooms_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                string room = nishikicmbsesroomname.SelectedItem.ToString();

                mySqlCon.Open();
                String query = "update mydb.sessions set Room = '"+room+"' where sessionID = "+sessionID+"";

                Console.WriteLine(query);

                MySqlCommand cmd = new MySqlCommand(query, mySqlCon);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Location Added Successfully for the subject,  " + nishikisessubroom.Text);
                clear();
                this.Dispose();


            }
        }
    }
}
