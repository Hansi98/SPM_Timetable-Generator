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

        public bool deleteLecturer(string EmpID)
        {
            throw new NotImplementedException();
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
            MySqlDataAdapter data = new MySqlDataAdapter("viewAllLecturers", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
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

        public Lecturer getSingleLecturer(string EmpID)
        {
            throw new NotImplementedException();
        }

        public ArrayList searchLecturer(string searchString)
        {
            throw new NotImplementedException();
        }

        public bool updateLecturer(Lecturer L)
        {
            throw new NotImplementedException();
        }
    }
}
