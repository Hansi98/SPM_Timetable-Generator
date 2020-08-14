using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABC_Institute___Timetable_Generator
{
    class DBconnection
    {
        private String conString = @"SERVER=mysql-11768-0.cloudclusters.net;PORT=11776;DATABASE=mydb;UID=chamika;PASSWORD=asd123+++";
        private MySqlConnection con;
       
        public MySqlConnection getConnection()
        {
            try { 
            MySqlConnection con = new MySqlConnection(conString);
            this.con = con;
            this.con.Open();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return this.con;

        }
        public void closeConnection()
        {
            
            this.con.Close();
            

        }



    }
    
}
