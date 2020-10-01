using ABC_Institute___Timetable_Generator.Models;
using ABC_Institute___Timetable_Generator.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Institute___Timetable_Generator.ServiceImpl
{
    class LecturerServiceImpl : LecturerServicesInt
    {
        MySqlConnection con = new DBconnection().getConnection();

        public bool addLecturer(Lecturer L)
        {
            
            
            MySqlCommand mysqlcommand = new MySqlCommand("lecturerAddorEdit",this.con);
            mysqlcommand.CommandType = CommandType.StoredProcedure;
            mysqlcommand.Parameters.AddWithValue("_checkDigit", 0);
            mysqlcommand.Parameters.AddWithValue("_Eid", L.ID1);
            mysqlcommand.Parameters.AddWithValue("_fname", L.FName);
            mysqlcommand.Parameters.AddWithValue("_mname", L.mName);
            mysqlcommand.Parameters.AddWithValue("_lname", L.lName);
            mysqlcommand.Parameters.AddWithValue("_faculty", L.Faculty);
            mysqlcommand.Parameters.AddWithValue("_dept", L.Dept);
            mysqlcommand.Parameters.AddWithValue("_center", L.Center);
            mysqlcommand.Parameters.AddWithValue("_building", L.Building);
            mysqlcommand.Parameters.AddWithValue("_Llevel", L.Level);
            mysqlcommand.Parameters.AddWithValue("_Lrank", L.Rank);
            if (mysqlcommand.ExecuteNonQuery() >= 1)
            {
               
                return true;
            }
            else
            {
               
                return false;
            }


        }

        public bool checkExist(Lecturer L)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("lecturergetById", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.AddWithValue("_Eid", L.ID1);
            DataTable table = new DataTable();
            data.Fill(table);
            if (table.Rows.Count==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool deleteLecturer(string EmpID)
        {

            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand("lecturerDeleteById", this.con);
                mysqlcommand.CommandType = CommandType.StoredProcedure;
                mysqlcommand.Parameters.AddWithValue("_Eid", EmpID);

                if (mysqlcommand.ExecuteNonQuery() >= 1)
                {

                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Connection Error Ocuured During Deleting Lecture Data, Please Re-Try again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

            }

            return false;

            
        }

        public int getAllCount()
        {
            MySqlDataAdapter data = new MySqlDataAdapter("lecturerGetTotCount", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            data.Fill(table);
            int val;
            try
            {
                val = Convert.ToInt32(table.Rows[0][0])+0;

            }
            catch (InvalidCastException e)
            {
                return 0;
            }

            return val;
        }

        public DataTable getAllLecturers()
        {
            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter("viewAllLecturers", this.con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                data.Fill(table);

                return table;

            }
            catch(MySqlException error)
            {
                MessageBox.Show("Connection Error Ocuured During Load Lecture Data, Please Re-Try By Closing and opening the Lecturer Portal again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                
            }

            return null;
        }

        public string getNextEmpID()
        {

            MySqlDataAdapter data = new MySqlDataAdapter("lecturerMaxID", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            data.Fill(table);
            int val;
            try
            {
                val = Convert.ToInt32(table.Rows[0][0]) + 1;

            }catch(InvalidCastException e)
            {
                return "1";
            }

                return val.ToString();
            



        }

        public int getOldCount()
        {
            MySqlDataAdapter data = new MySqlDataAdapter("assignedLecturerCount", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            data.Fill(table);
            int val;
            try
            {
                val = Convert.ToInt32(table.Rows[0][0]) + 0;

            }
            catch (InvalidCastException e)
            {
                return 0;
            }

            return val;
        }

        public Lecturer getSingleLecturer(string EmpID)
        {
            try { 
            MySqlDataAdapter data = new MySqlDataAdapter("lecturergetById", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.AddWithValue("_Eid", EmpID);
            DataTable table = new DataTable();
            data.Fill(table);

            return new Lecturer(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(), table.Rows[0][2].ToString(), table.Rows[0][3].ToString(), table.Rows[0][4].ToString(), table.Rows[0][5].ToString(), table.Rows[0][6].ToString(), table.Rows[0][7].ToString(), table.Rows[0][8].ToString(), table.Rows[0][9].ToString());
            }catch(MySqlException error2)
            {
                MessageBox.Show("Connection Error Ocuured During Load Lecture Data, Please Re-Try again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            return null;
        }

        public DataTable searchLecturer(string searchString)
        {

            MySqlDataAdapter data = new MySqlDataAdapter("lecturerSearch", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.AddWithValue("_searchString", searchString);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

        public bool updateLecturer(Lecturer L)
        {
            MySqlCommand mysqlcommand = new MySqlCommand("lecturerAddorEdit", this.con);
            mysqlcommand.CommandType = CommandType.StoredProcedure;
            mysqlcommand.Parameters.AddWithValue("_checkDigit", 1);
            mysqlcommand.Parameters.AddWithValue("_Eid", L.ID1);
            mysqlcommand.Parameters.AddWithValue("_fname", L.FName);
            mysqlcommand.Parameters.AddWithValue("_mname", L.mName);
            mysqlcommand.Parameters.AddWithValue("_lname", L.lName);
            mysqlcommand.Parameters.AddWithValue("_faculty", L.Faculty);
            mysqlcommand.Parameters.AddWithValue("_dept", L.Dept);
            mysqlcommand.Parameters.AddWithValue("_center", L.Center);
            mysqlcommand.Parameters.AddWithValue("_building", L.Building);
            mysqlcommand.Parameters.AddWithValue("_Llevel", L.Level);
            mysqlcommand.Parameters.AddWithValue("_Lrank", L.Rank);
            if (mysqlcommand.ExecuteNonQuery() >= 1)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
