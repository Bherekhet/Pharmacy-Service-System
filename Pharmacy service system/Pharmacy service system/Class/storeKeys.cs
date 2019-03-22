using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_service_system.Class
{
    public class storeKeys
    {
        public static string connectionCLass = "server=csdatabase.eku.edu;port=3306;database=csc340_db;username=stu_csc340;password=Colonels18;SslMode=none";
        public static string loginUserName;
        public static string loggedInfo { get => loginUserName; set => loginUserName = value; }

        public static int validateUser(string uName, string pass)
        {
            string userName = "";
            string password = "";
            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "Select user_name, password from wzb_loginInfo where user_name =@U and password = @P";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            cmd.Parameters.AddWithValue("@U", uName);
            cmd.Parameters.AddWithValue("@P", pass);

            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    userName = myReader["User_name"].ToString();
                    password = myReader["Password"].ToString();
                    if ((userName == uName) && (password == pass))
                    {
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
            return 0;
        }
    }
}
