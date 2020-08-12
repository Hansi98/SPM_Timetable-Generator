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
    public partial class Section1_tags : Form
    {

        string connectionString = @"SERVER=mysql-11768-0.cloudclusters.net;PORT=11776;DATABASE=mydb;UID=chamika;PASSWORD=asd123+++";
        int tagID = 0;
        public Section1_tags()
        {
            InitializeComponent();
            fillTagGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("TagAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_TagID", tagID);
                mySqlCmd.Parameters.AddWithValue("_TagName", vtxtBoxTagName.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                clear();
                fillTagGrid();
                MessageBox.Show("Tag Updated Successfully");

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("TagAddorEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_TagID",tagID);
                mySqlCmd.Parameters.AddWithValue("_TagName", vtxtBoxTagName.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
           
                clear();
                fillTagGrid();
                MessageBox.Show(" New Tag Added Successfully");

            }
        }
        void fillTagGrid()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("TagViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTags = new DataTable();
                sqlDa.Fill(dataTags);
                vdataGridTags.DataSource = dataTags;
            }
        }
        void clear()
        {
            vtxtBoxTagName.Text = "";
            tagID = 0;

        }

        private void vdataGridTags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (vdataGridTags.Columns[e.ColumnIndex].Name == "Update") {
                vtxtBoxTagName.Text =vdataGridTags.CurrentRow.Cells[1].Value.ToString();
                tagID = Convert.ToInt32(vdataGridTags.CurrentRow.Cells[0].Value.ToString());
            }

            if (vdataGridTags.Columns[e.ColumnIndex].Name == "Delete")
            {
                //  vtxtBoxTagName.Text = vdataGridTags.CurrentRow.Cells[1].Value.ToString();
                //  tagID = Convert.ToInt32(vdataGridTags.CurrentRow.Cells[0].Value.ToString());


                tagID = Convert.ToInt32(vdataGridTags.CurrentRow.Cells[0].Value.ToString());
                using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
                {
                    mySqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("TagDeleteByID", mySqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_TagID", tagID);
                    if(MessageBox.Show("Do you want you delete this tag ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mySqlCmd.ExecuteNonQuery();
                    }
                 
                   
                    clear();
                    fillTagGrid();
                    MessageBox.Show(" Tag Deleted Successfully");

                }
            }

        }
    }
}
