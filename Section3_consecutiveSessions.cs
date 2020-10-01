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
using System.Collections;

namespace ABC_Institute___Timetable_Generator
{
    public partial class Section3_consecutiveSessions : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        public Section3_consecutiveSessions()
        {
            InitializeComponent();
            fillTagGridsessions();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var arlist = new ArrayList();
            foreach (DataGridViewRow item in asdcs12.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    arlist.Add(item.Cells[1].Value.ToString());
                }
            }
            var session = arlist[0];
            int count = arlist.Count;
            for (int i = 0; i < count - 1; i++)

            {
                session = session + "," + arlist[i + 1];
            }
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                string Query = "insert into mydb.consecutivesessions(consecetive_sessions) values('" + session + "');";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, mySqlCon);
                MySqlDataReader MyReader2;
                mySqlCon.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Consecutive Session Added" + Environment.NewLine + "Session IDs : " + session);
                while (MyReader2.Read())
                {
                }
                mySqlCon.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            //    {
            //      mySqlCon.Open();
            //      MySqlDataAdapter sqlDa = new MySqlDataAdapter("sessiongetByGroupID", mySqlCon);
            //       sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            //        sqlDa.SelectCommand.Parameters.AddWithValue("_Group_ID", visalcmbconsegid.Text.Trim());
            //        DataTable datasessions = new DataTable();
            //        sqlDa.Fill(datasessions);
            //        visaldatagridconse.DataSource = datasessions;
            //    }

            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {


                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("sessiongetByGroupID", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_Group_ID", visalcmbconsegid.Text.Trim());
                DataTable dataTags = new DataTable();
                sqlDa.Fill(dataTags);


               
           



                foreach (DataRow item in dataTags.Rows)
                {
                    int aa = asdcs12.Rows.Add();
                    asdcs12.Rows[aa].Cells[0].Value = "false";
                    asdcs12.Rows[aa].Cells[1].Value = item["sessionID"].ToString();
                    asdcs12.Rows[aa].Cells[2].Value = item["Lecturer_Name"].ToString();
                    asdcs12.Rows[aa].Cells[3].Value = item["Group_ID"].ToString();
                    asdcs12.Rows[aa].Cells[4].Value = item["Subgroup_ID"].ToString();
                    asdcs12.Rows[aa].Cells[5].Value = item["Location"].ToString();
                    asdcs12.Rows[aa].Cells[6].Value = item["Timeslot"].ToString();
                    asdcs12.Rows[aa].Cells[7].Value = item["Day"].ToString();
                    asdcs12.Rows[aa].Cells[8].Value = item["Tag"].ToString();
                    asdcs12.Rows[aa].Cells[9].Value = item["Module"].ToString();



                }
                     {
                    int aa = asdcs12.Rows.Add();
                    asdcs12.Rows[aa].Cells[0].Value = "false";
                    asdcs12.Rows[aa].Cells[1].Value = null;
                    asdcs12.Rows[aa].Cells[2].Value = null;
                    asdcs12.Rows[aa].Cells[3].Value = null;
                    asdcs12.Rows[aa].Cells[4].Value = null;
                    asdcs12.Rows[aa].Cells[5].Value = null;
                    asdcs12.Rows[aa].Cells[6].Value = null;
                    asdcs12.Rows[aa].Cells[7].Value = null;
                    asdcs12.Rows[aa].Cells[8].Value = null;
                    asdcs12.Rows[aa].Cells[9].Value = null;



                }

            }
        }

        private void visaldatagridconse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void fillTagGridsessions()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("Select * from newsessions", mySqlCon);
                //sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTags = new DataTable();
                sqlDa.Fill(dataTags);
               

                foreach (DataRow item in dataTags.Rows)
                {
                    int aa = visaldatagridconse.Rows.Add();
                    visaldatagridconse.Rows[aa].Cells[0].Value = "false";
                    visaldatagridconse.Rows[aa].Cells[1].Value = item["sessionID"].ToString();
                    visaldatagridconse.Rows[aa].Cells[2].Value = item["Lecturer_Name"].ToString();
                    visaldatagridconse.Rows[aa].Cells[3].Value = item["Group_ID"].ToString();
                    visaldatagridconse.Rows[aa].Cells[4].Value = item["Subgroup_ID"].ToString();
                    visaldatagridconse.Rows[aa].Cells[5].Value = item["Location"].ToString();
                    visaldatagridconse.Rows[aa].Cells[6].Value = item["Timeslot"].ToString();
                    visaldatagridconse.Rows[aa].Cells[7].Value = item["Day"].ToString();
                    visaldatagridconse.Rows[aa].Cells[8].Value = item["Tag"].ToString();
                    visaldatagridconse.Rows[aa].Cells[9].Value = item["Module"].ToString();
                }
             //   visaldatagridconse.DataSource = dataTags;


            }

        }

        private void visalcmbconsegid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Section3_consecutiveSessions_Load(object sender, EventArgs e)
        {
            MySqlConnection cs = new MySqlConnection(connectionString);
            MySqlDataAdapter grouplotdapter = new MySqlDataAdapter("SELECT * FROM groupinfo", cs);
          

            DataTable groupDatatable = new DataTable();
            grouplotdapter.Fill(groupDatatable);

          

            visalcmbconsegid.Items.Clear();
          

            for (int i = 0; i < groupDatatable.Rows.Count; i++)
            {
                visalcmbconsegid.Items.Add((groupDatatable.Rows[i]["GroupID"]));
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
