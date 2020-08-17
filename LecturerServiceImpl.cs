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

namespace ABC_Institute___Timetable_Generator.ServiceImpl
{
    class LecturerServiceImpl : LecturerServicesInt
    {
        MySqlConnection con = new DBconnection().getConnection();

        public bool addLecturer(Lecturer L)
        {
            
            
            MySqlCommand mysqlcommand = new MySqlCommand("lecturerAddorEdit",this.con);
            mysqlcommand.CommandType = CommandType.StoredProcedure;
            mysqlcommand.Parameters.AddWithValue("_",L.FName);
            if (mysqlcommand.ExecuteNonQuery() > 1)
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

        public ArrayList getAllLecturers()
        {
            throw new NotImplementedException();
        }

        public string getNextEmpID()
        {
            throw new NotImplementedException();
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
