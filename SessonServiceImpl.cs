using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Institute___Timetable_Generator
{
    class SessonServiceImpl : sessionServiceInt
    {
        MySqlConnection con = new DBconnection().getConnection();
        public bool addSession(Session S)
        {
            bool holder=false;
            MySqlCommand mysqlcommand = new MySqlCommand("sessionAddorEdit", this.con);
            mysqlcommand.CommandType = CommandType.StoredProcedure;
            mysqlcommand.Parameters.AddWithValue("_checkDigit", 0);
            mysqlcommand.Parameters.AddWithValue("_groupId",S.groupID);
            mysqlcommand.Parameters.AddWithValue("_sessionID", 0);
            mysqlcommand.Parameters.AddWithValue("_tag",S.tag);
            mysqlcommand.Parameters.AddWithValue("_subCode", S.subCode);
            mysqlcommand.Parameters.AddWithValue("_studentCount", S.studentCount);
            mysqlcommand.Parameters.AddWithValue("_duration", S.duration);

            if (mysqlcommand.ExecuteNonQuery() >= 1)
            {
                MySqlDataAdapter data = new MySqlDataAdapter("sessionMaxId", this.con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                data.Fill(table);
                String val;
                
                
                    val =Convert.ToString( table.Rows[0]["maxID"]);

                

                for (int i = 0; i < S.LecList.Count; i++)
                {
                    MySqlCommand mysqlcommand2 = new MySqlCommand("addtoSessionLecsTable", this.con);
                    mysqlcommand2.CommandType = CommandType.StoredProcedure;
                    mysqlcommand2.Parameters.AddWithValue("_sId",val );
                    mysqlcommand2.Parameters.AddWithValue("_eId", S.LecList[i].ID1);
                    mysqlcommand2.Parameters.AddWithValue("_name", S.LecList[i].FName + " " + S.LecList[i].lName);
                    mysqlcommand2.Parameters.AddWithValue("_fac", S.LecList[i].Faculty);
                    mysqlcommand2.Parameters.AddWithValue("_dept", S.LecList[i].Dept);
                    mysqlcommand2.Parameters.AddWithValue("_building", S.LecList[i].Building);

                    if (mysqlcommand2.ExecuteNonQuery() >= 1)
                    {
                        holder = true;
                    }
                    else
                    {
                        holder = false;
                        break;
                    }

                }


                if (holder == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {

                return false;
            }

        }

        public bool deleteSession(string ID)
        {
            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand("deleteSession", this.con);
                mysqlcommand.CommandType = CommandType.StoredProcedure;
                mysqlcommand.Parameters.AddWithValue("_sessionID", ID);

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
                MessageBox.Show("Connection Error Ocuured During Deleting Session Data, Please Re-Try again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

            }

            return false;
        }

        public int getAllCount()
        {
            MySqlDataAdapter data = new MySqlDataAdapter("getSessionCount", this.con);
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

        public DataTable getAllSessions()
        {

            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter("getAllSessions", this.con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                data.Fill(table);

                return table;

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Connection Error Ocuured During Load Data, Please Re-Try By Closing and opening the Portal again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

            }

            return null;
        }

        public DataTable getLecturersbySessionID(string sesID)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("getLecsbySessionID", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.AddWithValue("sesID", sesID);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

        public List<string> getMainGroups()
        {
            List<string> list = new List<string>();
            MySqlDataAdapter data = new MySqlDataAdapter("getAllMainGroups", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            data.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                string name = (String)(table.Rows[i]["GroupID"]);


                list.Add(name);
            }
            return list;
        }

        public Session getSingleSession(string ID)
        {
            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter("getSessionBySessionID", this.con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.AddWithValue("_ID", ID);
                DataTable table = new DataTable();
                data.Fill(table);

                return new Session(Convert.ToInt32(table.Rows[0]["sessionID"].ToString()), table.Rows[0]["GroupID"].ToString(), table.Rows[0]["Tag"].ToString(), table.Rows[0]["SubCode"].ToString(), table.Rows[0]["StudentCount"].ToString(), table.Rows[0]["duration"].ToString());
            }
            catch (MySqlException error2)
            {
                MessageBox.Show("Connection Error Ocuured During Load Session Data, Please Re-Try again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            return null;
        }

        public List<string> getSubGroups()
        {
            List<string> list = new List<string>();
            MySqlDataAdapter data = new MySqlDataAdapter("getAllSubGroups", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            data.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                string name = (String)(table.Rows[i]["GroupID"]);


                list.Add(name);
            }
            return list;
        }

        public List<string> getTags()
        {
            List<string> list = new List<string>();
            MySqlDataAdapter data = new MySqlDataAdapter("getAllTags", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            data.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                string name = (String)(table.Rows[i]["TagName"]);


                list.Add(name);
            }
            return list;
        }

        public DataTable searchSession(string searchString)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("sessionSearch", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.AddWithValue("_searchString", searchString);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

        public DataTable searchSessionbyLec(string searchString)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("searchSessionByLecturer", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.AddWithValue("_sString", searchString);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

        public bool updateSession(Session S)
        {
            throw new NotImplementedException();
        }
    }
}
