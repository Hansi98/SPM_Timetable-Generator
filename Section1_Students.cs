using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABC_Institute___Timetable_Generator
{
    public partial class Section1_Students : Form
    {
        string connectionString = @"SERVER=mysql-11921-0.cloudclusters.net;PORT=11921;DATABASE=mydb;UID=chamika;PASSWORD=asd123+++";
        int yearsemID = 0;
        int proID = 0;
        int groupID = 0;
        int sgID = 0;

        public Section1_Students()
        {
            InitializeComponent();
            fillTagGridyearandsem();
            fillTagGridpro();
            fillTagGridgroup();
            fillTagGridsubgroup();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void vdataGridys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vdataGridys.Columns[e.ColumnIndex].Name == "Update")
            {
                vtxtBoxYear.Text = vdataGridys.CurrentRow.Cells[1].Value.ToString();
                vtxtSemester.Text = vdataGridys.CurrentRow.Cells[2].Value.ToString();
                yearsemID = Convert.ToInt32(vdataGridys.CurrentRow.Cells[0].Value.ToString());
            }

            if (vdataGridys.Columns[e.ColumnIndex].Name == "Delete")
            {
                //  vtxtBoxTagName.Text = vdataGridTags.CurrentRow.Cells[1].Value.ToString();
                //  tagID = Convert.ToInt32(vdataGridTags.CurrentRow.Cells[0].Value.ToString());


                yearsemID = Convert.ToInt32(vdataGridys.CurrentRow.Cells[0].Value.ToString());
                using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
                {
                    mySqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("ysDeleteByID", mySqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_ysID", yearsemID);
                    if (MessageBox.Show("Do you want you delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mySqlCmd.ExecuteNonQuery();
                    }


                    clearyesrandsem();
                    fillTagGridyearandsem();
                    MessageBox.Show("Deleted Successfully");

                }
            }
        }

        void fillTagGridyearandsem()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ysViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTags = new DataTable();
                sqlDa.Fill(dataTags);
                vdataGridys.DataSource = dataTags;
            }
        }
        void clearyesrandsem()
        {
            vtxtBoxYear.Text = "";
            vtxtSemester.Text = "";
            yearsemID = 0;

        }
        void fillTagGridpro()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("proViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTags = new DataTable();
                sqlDa.Fill(dataTags);
                vdataGridpro.DataSource = dataTags;
            }
        }
        void clearpro()
        {
            vtxtpn.Text = "";
            vtxtdes.Text = "";
            proID = 0;

        }

        private void vbtnAddys_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("ysAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_ysID", yearsemID);
                mySqlCmd.Parameters.AddWithValue("_Year", vtxtBoxYear.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Semester", vtxtSemester.Text.Trim());
                mySqlCmd.ExecuteNonQuery();

                clearyesrandsem();
                fillTagGridyearandsem();
                MessageBox.Show(" Added Successfully");

            }
        }

        private void vtxtBoxYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void vbtnUpdateys_Click(object sender, EventArgs e)
        {

            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("ysAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_ysID", yearsemID);
                mySqlCmd.Parameters.AddWithValue("_Year", vtxtBoxYear.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Semester", vtxtSemester.Text.Trim());
                mySqlCmd.ExecuteNonQuery();

                clearyesrandsem();
                fillTagGridyearandsem();
                MessageBox.Show(" Added Successfully");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vdataGridpro.Columns[e.ColumnIndex].Name == "proUpdate")
            {
                vtxtpn.Text = vdataGridpro.CurrentRow.Cells[1].Value.ToString();
                vtxtdes.Text = vdataGridpro.CurrentRow.Cells[2].Value.ToString();
                proID = Convert.ToInt32(vdataGridpro.CurrentRow.Cells[0].Value.ToString());
            }

            if (vdataGridpro.Columns[e.ColumnIndex].Name == "proDelete")
            {
                //  vtxtBoxTagName.Text = vdataGridTags.CurrentRow.Cells[1].Value.ToString();
                //  tagID = Convert.ToInt32(vdataGridTags.CurrentRow.Cells[0].Value.ToString());


                proID = Convert.ToInt32(vdataGridpro.CurrentRow.Cells[0].Value.ToString());
                using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
                {
                    mySqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("proDeleteByID", mySqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_proID", proID);
                    if (MessageBox.Show("Do you want you delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mySqlCmd.ExecuteNonQuery();
                    }

                    clearpro();
                    fillTagGridpro();
                    MessageBox.Show("Deleted Successfully");

                }
            }
        }

        private void vbtnAddpro_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("proAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_proID", proID);
                mySqlCmd.Parameters.AddWithValue("_proName", vtxtpn.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_proDescription", vtxtdes.Text.Trim());
                mySqlCmd.ExecuteNonQuery();

                clearpro();
                fillTagGridpro();
                MessageBox.Show(" Added Successfully");

            }

        }

        private void vbtnAdddes_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("proAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_proID", proID);
                mySqlCmd.Parameters.AddWithValue("_proName", vtxtpn.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_proDescription", vtxtdes.Text.Trim());
                mySqlCmd.ExecuteNonQuery();

                clearpro();
                fillTagGridpro();
                MessageBox.Show(" updated Successfully");

            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
        }

        private void vtabControl1_TabIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void vtabControl1_Selected(object sender, TabControlEventArgs e)
        {
            MySqlConnection cs = new MySqlConnection(connectionString);

            MySqlDataAdapter ysAdapter = new MySqlDataAdapter("SELECT * FROM yearandsemester", cs);
            MySqlDataAdapter prodapter = new MySqlDataAdapter("SELECT * FROM Programmes", cs);

            DataTable ysDatatable = new DataTable();
            ysAdapter.Fill(ysDatatable);

            DataTable proDatatable = new DataTable();
            prodapter.Fill(proDatatable);

            vcmbys_gn.Items.Clear();
            vcmbys_sgn.Items.Clear();
            vcmbpro_gn.Items.Clear();
            vcmbpro_sgn.Items.Clear();
            for (int i = 0; i < ysDatatable.Rows.Count; i++)
            {
                vcmbys_gn.Items.Add(ysDatatable.Rows[i]["ID"]);
                vcmbys_sgn.Items.Add(ysDatatable.Rows[i]["ID"]);
            }

            for (int i = 0; i < proDatatable.Rows.Count; i++)
            {
                vcmbpro_gn.Items.Add(proDatatable.Rows[i]["proName"]);
                vcmbpro_sgn.Items.Add(proDatatable.Rows[i]["proName"]);
            }

        }

        private void vtabControl1_Click(object sender, EventArgs e)
        {

        }

        private void vbtnAddgroup_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("GroupAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_tID", groupID);
                mySqlCmd.Parameters.AddWithValue("_Year_Semester", vcmbys_gn.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Programme", vcmbpro_gn.Text.Trim()); 
                mySqlCmd.Parameters.AddWithValue("_GroupNo", vtxtgn_gn.Text.Trim());
                mySqlCmd.ExecuteNonQuery();

                cleargroup();
                fillTagGridgroup();
                MessageBox.Show(" Added Successfully");

            }
        }
        public void cleargroup()
        {
            vcmbys_gn.Text = "";
            vcmbpro_gn.Text = "";
            vtxtgn_gn.Text = "";

        }
        public void fillTagGridgroup()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("GroupViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTags = new DataTable();
                sqlDa.Fill(dataTags);
                vdataGridgn.DataSource = dataTags;
            }

        }

        private void vdataGridgn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vdataGridgn.Columns[e.ColumnIndex].Name == "groupDelete")// groupDelete
            {
                //  vtxtBoxTagName.Text = vdataGridTags.CurrentRow.Cells[1].Value.ToString();
                //  tagID = Convert.ToInt32(vdataGridTags.CurrentRow.Cells[0].Value.ToString());


                groupID = Convert.ToInt32(vdataGridgn.CurrentRow.Cells[0].Value.ToString());
                using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
                {
                    mySqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("GroupDeleteByID", mySqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_tID", groupID);
                    if (MessageBox.Show("Do you want you delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mySqlCmd.ExecuteNonQuery();
                    }

                    cleargroup();
                    fillTagGridgroup();
                    MessageBox.Show("Deleted Successfully");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("SubGroupAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_sgID", sgID);
                mySqlCmd.Parameters.AddWithValue("_Year_Semester", vcmbys_sgn.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Programme", vcmbpro_sgn.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_GroupNo", vcmbgn_sgn.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_SubGroupNo", vtxtsgn_sgn.Text.Trim());
                mySqlCmd.ExecuteNonQuery();

                clearsubgroup();
                fillTagGridsubgroup();
                MessageBox.Show(" Added Successfully");

            }
        }
        public void clearsubgroup()
        {
            vcmbys_sgn.Text = "";
            vcmbpro_sgn.Text = "";
            vcmbgn_sgn.Text = "";
            vtxtsgn_sgn.Text = "";

        }
        public void fillTagGridsubgroup()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SubGroupViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTags = new DataTable();
                sqlDa.Fill(dataTags);
                vgatagridSG.DataSource = dataTags;
            }

        }

    }
}
