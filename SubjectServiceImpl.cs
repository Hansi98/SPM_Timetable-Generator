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
            
            
            MySqlCommand mysqlcommand = new MySqlCommand("subjectAddorEdit", this.con);
            mysqlcommand.CommandType = CommandType.StoredProcedure;
            mysqlcommand.Parameters.AddWithValue("_checkDigit", 0);
            mysqlcommand.Parameters.AddWithValue("_code", L.Code);
            mysqlcommand.Parameters.AddWithValue("_name", L.Name);
            mysqlcommand.Parameters.AddWithValue("_lecHr", L.LecHrs);
            mysqlcommand.Parameters.AddWithValue("_tutHr", L.TutHrs);
            mysqlcommand.Parameters.AddWithValue("_labHr", L.LabHr);
            mysqlcommand.Parameters.AddWithValue("_EvalHr", L.evalHr);
            mysqlcommand.Parameters.AddWithValue("_Year", L.Year);
            mysqlcommand.Parameters.AddWithValue("_Semester", L.Sem);

            if (mysqlcommand.ExecuteNonQuery() >= 1)
            {
               
                return true;
            }
            else
            {
               
                return false;
            }


        }

        public bool checkExist(Subject S)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("SubjectbyCode", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.AddWithValue("_Code", S.Code);
            DataTable table = new DataTable();
            data.Fill(table);
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool deleteSubject(string code)
        {
            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand("subjectDeleteById", this.con);
                mysqlcommand.CommandType = CommandType.StoredProcedure;
                mysqlcommand.Parameters.AddWithValue("_Code", code);

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
                MessageBox.Show("Connection Error Ocuured During Deleting Subject Data, Please Re-Try again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

            }

            return false;

        }

        public int getAllCount()
        {
            MySqlDataAdapter data = new MySqlDataAdapter("subjectgetTotCount", this.con);
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

        public List<string> getAllSubCodes()
        {
            List<string> list = new List<string>();
            MySqlDataAdapter data = new MySqlDataAdapter("getAllSubCodes", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            data.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                string name = (String)(table.Rows[i]["Subcode"]);
               

                list.Add(name);
            }
            return list;

        }

        public DataTable getAllSubject()
        {
            MySqlDataAdapter data = new MySqlDataAdapter("viewAllSubjects", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

       

        public Subject getSingleSubject(string code)
        {
            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter("SubjectbyCode", this.con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.AddWithValue("_Code", code);
                DataTable table = new DataTable();
                data.Fill(table);

                return new Subject(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(),Convert.ToInt32( table.Rows[0][2].ToString()), Convert.ToInt32(table.Rows[0][3].ToString()), Convert.ToInt32(table.Rows[0][4].ToString()), Convert.ToInt32(table.Rows[0][5].ToString()), Convert.ToInt32(table.Rows[0][6].ToString()), Convert.ToInt32(table.Rows[0][7].ToString()));
                
            }
            catch (MySqlException error2)
            {
                MessageBox.Show("Connection Error Ocuured During Load Subject Data, Please Re-Try again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            return null;
        }

        public DataTable searchSubject(string searchString)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("subjectSearch", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.AddWithValue("_searchString", searchString);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

        public bool updateSubject(Subject L)
        {
            MySqlCommand mysqlcommand = new MySqlCommand("subjectAddorEdit", this.con);
            mysqlcommand.CommandType = CommandType.StoredProcedure;
            mysqlcommand.Parameters.AddWithValue("_checkDigit", 1);
            mysqlcommand.Parameters.AddWithValue("_code", L.Code);
            mysqlcommand.Parameters.AddWithValue("_name", L.Name);
            mysqlcommand.Parameters.AddWithValue("_lecHr", L.LecHrs);
            mysqlcommand.Parameters.AddWithValue("_tutHr", L.TutHrs);
            mysqlcommand.Parameters.AddWithValue("_labHr", L.LabHr);
            mysqlcommand.Parameters.AddWithValue("_EvalHr", L.evalHr);
            mysqlcommand.Parameters.AddWithValue("_Year", L.Year);
            mysqlcommand.Parameters.AddWithValue("_Semester", L.Sem);

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
