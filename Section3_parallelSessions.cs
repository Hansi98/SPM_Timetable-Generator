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
    public partial class Section3_parallelSessions : Form
    {
        string connectionString = @"SERVER=abcdatabase.mysql.database.azure.com;PORT=3306;DATABASE=mydb;UID=abcadmin@abcdatabase;PASSWORD=ABC@123abc";
        public Section3_parallelSessions()
        {
            InitializeComponent();
            fillTagGridParasessions();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Section3_parallelSessions_Load(object sender, EventArgs e)
        {
            MySqlConnection cs = new MySqlConnection(connectionString);
            MySqlDataAdapter subgrouplotdapter = new MySqlDataAdapter("SELECT * FROM groupinfo", cs);

            DataTable subgroupDatatable = new DataTable();
            subgrouplotdapter.Fill(subgroupDatatable);

            visalcmbparasegid.Items.Clear();


            for (int i = 0; i < subgroupDatatable.Rows.Count; i++)
            {
                visalcmbparasegid.Items.Add((subgroupDatatable.Rows[i]["GroupID"]));
            }
        }
        public void fillTagGridParasessions()
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
                    int aa = visaldatagridparasess1.Rows.Add();
                    visaldatagridparasess1.Rows[aa].Cells[0].Value = "false";
                    visaldatagridparasess1.Rows[aa].Cells[1].Value = item["sessionID"].ToString();
                    visaldatagridparasess1.Rows[aa].Cells[2].Value = item["Lecturer_Name"].ToString();
                    visaldatagridparasess1.Rows[aa].Cells[3].Value = item["Group_ID"].ToString();
                    visaldatagridparasess1.Rows[aa].Cells[4].Value = item["Subgroup_ID"].ToString();
                    visaldatagridparasess1.Rows[aa].Cells[5].Value = item["Location"].ToString();
                    visaldatagridparasess1.Rows[aa].Cells[6].Value = item["Timeslot"].ToString();
                    visaldatagridparasess1.Rows[aa].Cells[7].Value = item["Day"].ToString();
                    visaldatagridparasess1.Rows[aa].Cells[8].Value = item["Tag"].ToString();
                    visaldatagridparasess1.Rows[aa].Cells[9].Value = item["Module"].ToString();



                }
                //   visaldatagridconse.DataSource = dataTags;


            }

        }

        private void visalbtnparasese_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {


                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("sessiongetByGroupID", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_Group_ID", visalcmbparasegid.Text.Trim());
                DataTable dataTags = new DataTable();
                sqlDa.Fill(dataTags);







                foreach (DataRow item in dataTags.Rows)
                {
                    int aa = visaldatagridparasess2.Rows.Add();
                    visaldatagridparasess2.Rows[aa].Cells[0].Value = "false";
                    visaldatagridparasess2.Rows[aa].Cells[1].Value = item["sessionID"].ToString();
                    visaldatagridparasess2.Rows[aa].Cells[2].Value = item["Lecturer_Name"].ToString();
                    visaldatagridparasess2.Rows[aa].Cells[3].Value = item["Group_ID"].ToString();
                    visaldatagridparasess2.Rows[aa].Cells[4].Value = item["Subgroup_ID"].ToString();
                    visaldatagridparasess2.Rows[aa].Cells[5].Value = item["Location"].ToString();
                    visaldatagridparasess2.Rows[aa].Cells[6].Value = item["Timeslot"].ToString();
                    visaldatagridparasess2.Rows[aa].Cells[7].Value = item["Day"].ToString();
                    visaldatagridparasess2.Rows[aa].Cells[8].Value = item["Tag"].ToString();
                    visaldatagridparasess2.Rows[aa].Cells[9].Value = item["Module"].ToString();



                }
                {
                    int aa = visaldatagridparasess2.Rows.Add();
                    visaldatagridparasess2.Rows[aa].Cells[0].Value = "false";
                    visaldatagridparasess2.Rows[aa].Cells[1].Value = null;
                    visaldatagridparasess2.Rows[aa].Cells[2].Value = null;
                    visaldatagridparasess2.Rows[aa].Cells[3].Value = null;
                    visaldatagridparasess2.Rows[aa].Cells[4].Value = null;
                    visaldatagridparasess2.Rows[aa].Cells[5].Value = null;
                    visaldatagridparasess2.Rows[aa].Cells[6].Value = null;
                    visaldatagridparasess2.Rows[aa].Cells[7].Value = null;
                    visaldatagridparasess2.Rows[aa].Cells[8].Value = null;
                    visaldatagridparasess2.Rows[aa].Cells[9].Value = null;

                }

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void visalbtnparasemake_Click(object sender, EventArgs e)
        {
            var arlist = new ArrayList();
            foreach (DataGridViewRow item in visaldatagridparasess2.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    arlist.Add(item.Cells[1].Value.ToString());
                }
            }
            var session = arlist[0];
            int count = arlist.Count;
            for (int i = 0; i < count-1; i++)
              
            {
                session=session+","+arlist[i+1]  ;
            }
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                string Query = "insert into mydb.parallelsessions(parallel_sessions) values('" + session + "');";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, mySqlCon);
                MySqlDataReader MyReader2;
                mySqlCon.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Parallel Session Added" + Environment.NewLine + "Session IDs : "+session);
                while (MyReader2.Read())
                {
                }
                mySqlCon.Close();
            }
        }
    }
}
