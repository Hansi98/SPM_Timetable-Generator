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
    class SubjectServiceImpl : SubjectServicesInt
    {
        MySqlConnection con = new DBconnection().getConnection();

        public bool addSubject(Subject L)
        {
            
            
            MySqlCommand mysqlcommand = new MySqlCommand("subjectAdd", this.con);
            mysqlcommand.CommandType = CommandType.StoredProcedure;
            mysqlcommand.Parameters.AddWithValue("_code", L.Code);
            mysqlcommand.Parameters.AddWithValue("_name", L.Name);
            mysqlcommand.Parameters.AddWithValue("_lecHr", L.LecHrs);
            mysqlcommand.Parameters.AddWithValue("_tutHr", L.TutHrs);
            mysqlcommand.Parameters.AddWithValue("_labHr", L.LabHr);
            mysqlcommand.Parameters.AddWithValue("_EvalHr", L.evalHr);

            if (mysqlcommand.ExecuteNonQuery() >= 1)
            {
               
                return true;
            }
            else
            {
               
                return false;
            }


        }

        public bool deleteSubject(string code)
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

        public DataTable getAllSubject()
        {
            MySqlDataAdapter data = new MySqlDataAdapter("viewAllSubjects", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

       

        public Lecturer getSingleSubject(string code)
        {
            throw new NotImplementedException();
        }

        public ArrayList searchSubject(string searchString)
        {
            throw new NotImplementedException();
        }

        public bool updateSubject(Subject L)
        {
            throw new NotImplementedException();
        }
    }
}
