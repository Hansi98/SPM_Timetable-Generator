using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABC_Institute___Timetable_Generator
{
    public partial class Section1_WorkingDays : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        int wdID = 0;
        int whID = 0;
        string days = "";
        string newdate = "";

        public Section1_WorkingDays()
        {
            InitializeComponent();
            fillWorkingDaysGrid();
            fillWorkingHoursGrid();

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
                
                if (hansimondaycheckBox.Checked == true)
                {
                    days += "Monday ";
                }
                if (hansituesdaycheckBox.Checked == true)
                {
                    days += "Tuesday ";
                }
                if (hansiwedcheckBox.Checked == true)
                {
                    days += "Wednesday ";
                }
                if (hansithurscheckBox.Checked == true)
                {
                    days += "Thursday ";
                }
                if (hansifricheckBox.Checked == true)
                {
                    days += "Friday ";
                }
                if (hansisatcheckBox.Checked == true)
                {
                    days += "Saturday ";
                }
                if (hansisuncheckBox.Checked == true)
                {
                    days += "Sunday ";
                }

                mySqlCmd.Parameters.AddWithValue("_wdID", wdID);
                mySqlCmd.Parameters.AddWithValue("_noOfWrkDays", (Int32)HansiWork_daysno.Value);
                mySqlCmd.Parameters.AddWithValue("_WorkingDays", days);


                MessageBox.Show("Check whether no of working days and working days are equal");


                mySqlCmd.ExecuteNonQuery();

                clear();
                MessageBox.Show("Working Days Added Successfully");
                fillWorkingDaysGrid();
            }

        }

        private void HansiWork_daysbtnupdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("WorkingDaysAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;

                if (hansimondaycheckBox.Checked == true)
                {
                    newdate += "Monday ";
                }
                if (hansituesdaycheckBox.Checked == true)
                {
                    newdate += "Tuesday ";
                }
                if (hansiwedcheckBox.Checked == true)
                {
                    newdate += "Wednesday ";
                }
                if (hansithurscheckBox.Checked == true)
                {
                    newdate += "Thursday ";
                }
                if (hansifricheckBox.Checked == true)
                {
                    newdate += "Friday ";
                }
                if (hansisatcheckBox.Checked == true)
                {
                    newdate += "Saturday ";
                }
                if (hansisuncheckBox.Checked == true)
                {
                    newdate += "Sunday ";
                }
                
                mySqlCmd.Parameters.AddWithValue("_wdID", wdID);
                mySqlCmd.Parameters.AddWithValue("_noOfWrkDays", Convert.ToInt32(HansiWork_daysno.Text.Trim()));
                mySqlCmd.Parameters.AddWithValue("_WorkingDays", newdate);
                
                mySqlCmd.ExecuteNonQuery();
                clear();
                MessageBox.Show("Working Days Updated Successfully");
                fillWorkingDaysGrid();
            }
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
            HansiWork_daysno.Value = 0;
            hansimondaycheckBox.Checked = false;
            hansituesdaycheckBox.Checked = false;
            hansiwedcheckBox.Checked = false;
            hansithurscheckBox.Checked = false;
            hansifricheckBox.Checked = false;
            hansisatcheckBox.Checked = false;
            hansisuncheckBox.Checked = false;

        }

        private void hansiwork_daystable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (hansiwork_daystable.Columns[e.ColumnIndex].Name == "hwrk_Update")

            {
                string day = hansiwork_daystable.CurrentRow.Cells[2].Value.ToString();

                    string[] splitdayslist = day.Split(' ');

                    foreach (var word in splitdayslist)
                    {
                        System.Console.WriteLine(word);
                        if (word == "Monday")
                        {
                            hansimondaycheckBox.Checked = true;
                        }
                        if (word == "Tuesday")
                        {
                            hansituesdaycheckBox.Checked = true;
                        }
                        if (word == "Wednesday")
                        {
                            hansiwedcheckBox.Checked = true;
                        }
                        if (word == "Thursday")
                        {
                            hansithurscheckBox.Checked = true;
                        }
                        if (word == "Friday")
                        {
                            hansifricheckBox.Checked = true;
                        }
                        if (word == "Saturday")
                        {
                            hansisatcheckBox.Checked = true;
                        }
                        if (word == "Sunday")
                        {
                            hansisuncheckBox.Checked = true;
                        }
                    }
                    HansiWork_daysno.Text = hansiwork_daystable.CurrentRow.Cells[1].Value.ToString();

                    wdID = Convert.ToInt32(hansiwork_daystable.CurrentRow.Cells[0].Value.ToString());
                }


            if (hansiwork_daystable.Columns[e.ColumnIndex].Name == "hwrk_delete")
            {

                wdID = Convert.ToInt32(hansiwork_daystable.CurrentRow.Cells[0].Value.ToString());
                using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
                {
                    mySqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("WorkingDaysDeleteByID", mySqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_wdID", wdID);
                    if (MessageBox.Show("Do you want you delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mySqlCmd.ExecuteNonQuery();
                    }
                    clear();
                    MessageBox.Show("Working Days Deleted Successfully");
                    fillWorkingDaysGrid();
                    
                }
            }

        }

        private void HansiWork_hoursaddbtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("WorkingHoursAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_whID", whID);
                mySqlCmd.Parameters.AddWithValue("_noOfWrkHours", HansiWork_hours.Text.Trim() + " : " + HansiWork_minutes.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_WorkingSlots", hansiwork_hourslots.Text.Trim());
                
                mySqlCmd.ExecuteNonQuery();

                clearHour();
                MessageBox.Show("Working Hours Added Successfully");
                fillWorkingHoursGrid();
            }

        }

        void clearHour()
        {
            whID = 0;
            HansiWork_hours.Text = "";
            HansiWork_minutes.Text = "";
            hansiwork_hourslots.Text = "";

        }

        void fillWorkingHoursGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("WorkingHoursViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataWorkingHours = new DataTable();
                sqlDa.Fill(dataWorkingHours);
                hansiwork_hourstable.DataSource = dataWorkingHours;
            }
        }

        private void hansiwork_hourstable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           

            if (hansiwork_hourstable.Columns[e.ColumnIndex].Name == "h_update")
            {
                
                    string time = hansiwork_hourstable.CurrentRow.Cells[1].Value.ToString();
                    string[] list = time.Split(':');
                    foreach (string ti in list)
                    {
                        Console.WriteLine(ti);
                    }
                
                    hansiwork_hourslots.Text = hansiwork_hourstable.CurrentRow.Cells[2].Value.ToString();
                
                
                HansiWork_hours.Text = list[0] ;
                HansiWork_minutes.Text = list[1];

                whID = Convert.ToInt32(hansiwork_hourstable.CurrentRow.Cells[0].Value.ToString());
            }

            if (hansiwork_hourstable.Columns[e.ColumnIndex].Name == "h_delete")
            {

                whID = Convert.ToInt32(hansiwork_hourstable.CurrentRow.Cells[0].Value.ToString());
                using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
                {
                    mySqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("WorkingHoursDeleteByID", mySqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_whID", whID);
                    if (MessageBox.Show("Do you want you delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mySqlCmd.ExecuteNonQuery();
                    }


                    clearHour();
                    fillWorkingHoursGrid();
                    MessageBox.Show("Working Hours Deleted Successfully");

                }
            }

        }

        private void hansiwork_hourupdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("WorkingHoursAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_whID", whID);

                //if (hansiwork_hourstable.Columns[e.ColumnIndex].Name == "h_update")
                //{

                //    string time = hansiwork_hourstable.CurrentRow.Cells[1].Value.ToString();
                //    string[] list = time.Split(':');
                //    foreach (string ti in list)
                //    {
                //        Console.WriteLine(ti);
                //    }

                mySqlCmd.Parameters.AddWithValue("_noOfWrkHours", HansiWork_hours.Text.Trim() +" : "+ HansiWork_minutes.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_WorkingSlots", hansiwork_hourslots.Text.Trim());
                mySqlCmd.ExecuteNonQuery();

                clearHour();
                fillWorkingHoursGrid();
                MessageBox.Show("Working Hours Updated Successfully");
            }
        }

        
        
    }
}

