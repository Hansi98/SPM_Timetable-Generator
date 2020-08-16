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
    public partial class Section1_WorkingDays : Form
    {
        string connectionString = @"SERVER= mysql-11921-0.cloudclusters.net;PORT=11921;DATABASE=mydb;UID=chamika;PASSWORD=asd123+++";
        int wdID = 0;
        String days = "";

        public Section1_WorkingDays()
        {
            InitializeComponent();
            fillWorkingDaysGrid();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HansiWork_minutes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HansiWork_timeslots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void HansiWork_daysbtnadd_Click(object sender, EventArgs e)
        {
                using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                    mySqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("WorkingDaysAddorEdit", mySqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_wdID", wdID);
                    mySqlCmd.Parameters.AddWithValue("_noOfWd", (Int32)HansiWork_daysno.Value);

                if (hansimondaycheckBox.Checked)
                {
                    days += "Monday  ";
                }
                if (hansituesdaycheckBox.Checked)
                {
                    days += "Tuesday  ";
                }
                if (hansiwedcheckBox.Checked)
                {
                    days += "Wednsday  ";
                }
                if (hansithurscheckBox.Checked)
                {
                    days += "Thursday  ";
                }
                if (hansifricheckBox.Checked)
                {
                    days += "Friday  ";
                }
                if (hansisatcheckBox.Checked)
                {
                    days += "Saturday  ";
                }
                if (hansisuncheckBox.Checked)
                {
                    days += "Sunday  ";
                }


                mySqlCmd.Parameters.AddWithValue("_workingDays", days);


                mySqlCmd.ExecuteNonQuery();

                clear();
                MessageBox.Show("Working Days Added Successfully");
                fillWorkingDaysGrid();
                }
               
                }

        private void HansiWork_daysbtnupdate_Click(object sender, EventArgs e)
        {
            //using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            //{
            //    mySqlCon.Open();
            //    MySqlCommand mySqlCmd = new MySqlCommand("WorkingDaysAddorEdit", mySqlCon);
            //    mySqlCmd.CommandType = CommandType.StoredProcedure;
            //    mySqlCmd.Parameters.AddWithValue("_wdID", wdID);
            //    mySqlCmd.Parameters.AddWithValue("_noOfWd", (Int32)HansiWork_daysno.Value);
            //    //mySqlCmd.Parameters.AddWithValue("_workingDays", hansimondaycheckBox.Text.Trim());
            //    //mySqlCmd.Parameters.AddWithValue("_workingDays", hansituesdaycheckBox.Text.Trim());
                
            //    mySqlCmd.ExecuteNonQuery();
            //    clear();
            //    fillWorkingDaysGrid();
            //    MessageBox.Show("Working Days Updated Successfully");

            //}
        }

        void fillWorkingDaysGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("WorkingDaysViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataWorkingDays = new DataTable();
                sqlDa.Fill(dataWorkingDays);
                hansiwork_daystable.DataSource = dataWorkingDays;
            }
        }

        void clear()
        {
            wdID = 0;
           // HansiWork_daysno = 0;
           // hansimondaycheckBox.Text = "";


        }

        private void hansiwork_daystable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (hansiwork_daystable.Columns[e.ColumnIndex].Name == "Update")
            //{
            //    HansiWork_daysno.Text = hansiwork_daystable.CurrentRow.Cells[1].Value.ToString();
            //    wdID = Convert.ToInt32(hansiwork_daystable.CurrentRow.Cells[0].Value.ToString());
            //}

            //if (hansiwork_daystable.Columns[e.ColumnIndex].Name == "Delete")
            //{
                //  vtxtBoxTagName.Text = vdataGridTags.CurrentRow.Cells[1].Value.ToString();
                //  tagID = Convert.ToInt32(vdataGridTags.CurrentRow.Cells[0].Value.ToString());


                //wdID = Convert.ToInt32(hansiwork_daystable.CurrentRow.Cells[0].Value.ToString());
                //using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
                //{
                //    mySqlCon.Open();
                //    MySqlCommand mySqlCmd = new MySqlCommand("WorkingDaysDeleteByID", mySqlCon);
                //    mySqlCmd.CommandType = CommandType.StoredProcedure;
                //    mySqlCmd.Parameters.AddWithValue("_wdID", wdID);
                //    if (MessageBox.Show("Are you sure to delete this working day set ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //    {
                //        mySqlCmd.ExecuteNonQuery();
                //    }


                //    clear();
                //    fillWorkingDaysGrid();
                //    MessageBox.Show(" Working Details Deleted Successfully");

            //    }
            //}
        }

    }
    }

