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
    public partial class Section1_Statistics : Form
    {
        string connectionString = @"SERVER=mysql-11921-0.cloudclusters.net;PORT=11921;DATABASE=mydb;UID=chamika;PASSWORD=asd123+++";

        public Section1_Statistics()
        {
            InitializeComponent();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NishikiDstatistics_lec_btnsubmit_Click(object sender, EventArgs e)
        {
            if(nishikiDstatistics_leccmb.Text == "Faculty")
            {
                MySqlConnection sqlcon = new MySqlConnection(connectionString);
                MySqlCommand sqlcmd = new MySqlCommand("StatisiticsLecturerbyFaculty", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
               
                sqlcon.Open();
                    
                this.nishikiDstatistics_lecchart.Series["Faculty"].Points.AddXY("faculty of computing", 2);
                this.nishikiDstatistics_lecchart.Series["Faculty"].Points.AddXY("faculty of Engineering", 1);
                this.nishikiDstatistics_lecchart.Series["Faculty"].Points.AddXY("Faculty of Bussiness & Management", 1);
                 
                sqlcon.Close();
            }

            if (nishikiDstatistics_leccmb.Text == "Center")
            {    /*
                MySqlConnection sqlcon = new MySqlConnection(connectionString);
                MySqlCommand sqlcmd = new MySqlCommand("StatisiticsLecturerbyFaculty", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcon.Open();

                this.nishikiDstatistics_lecchart.Series["Faculty"].Points.AddXY("Malabe", 0);
                this.nishikiDstatistics_lecchart.Series["Faculty"].Points.AddXY("Metro", 1);
                this.nishikiDstatistics_lecchart.Series["Faculty"].Points.AddXY("Kandy", 3);

                sqlcon.Close(); */
            }

            if (nishikiDstatistics_leccmb.Text == "Department")
            {   /*
                MySqlConnection sqlcon = new MySqlConnection(connectionString);
                MySqlCommand sqlcmd = new MySqlCommand("StatisiticsLecturerbyFaculty", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcon.Open();

                this.nishikiDstatistics_lecchart.Series["Faculty"].Points.AddXY("faculty of computing", 2);
                this.nishikiDstatistics_lecchart.Series["Faculty"].Points.AddXY("faculty of Engineering", 1);
                this.nishikiDstatistics_lecchart.Series["Faculty"].Points.AddXY("Faculty of Bussiness & Management", 1);

                sqlcon.Close(); */
            }

            if (nishikiDstatistics_leccmb.Text == "Level")
            {
                MessageBox.Show("Level");
            }
        }
    }
}
