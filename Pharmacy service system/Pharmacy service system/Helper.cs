using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_service_system
{
    class Helper
    {
        string newRefillCount;
        string newPrescCount;
        string newCaseCount; //not yet implemented 
        

        public Helper()
        {

        }



        public string displayNoticeCount()
        {
            string myConnection = "server=localhost;port=3306;database=pss;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            string query1 = "select count(*) from prescription where status = 'new' and type = 'D'";
            MySqlCommand cmd1 = new MySqlCommand(query1, myConn);

            string query2 = "select count(*) from prescription where status = 'new' and type = 'R'";
            MySqlCommand cmd2 = new MySqlCommand(query2, myConn);


            try
            {
                myConn.Open();
                
                MySqlDataReader myReader1 = cmd1.ExecuteReader();
                if (myReader1.Read())
                {
                    newPrescCount = myReader1.GetString(0);
                }
                myReader1.Close();

                //Console.WriteLine(newPrescCount);

                MySqlDataReader myReader2 = cmd2.ExecuteReader();
                if (myReader2.Read())
                {
                    newRefillCount = myReader2.GetString(0);
                }
                myReader2.Close();
                Console.WriteLine(newRefillCount);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            myConn.Close();

            return newPrescCount + "" + newRefillCount;
        }
        
        public void displayNoticeFromDoctor()
        {

        }

        public void sendPickUpNotice()
        {

        }

        public void acknowlegdeNotice()
        {

        }

        public void checkStatus()
        {

        }

        public void releasePatient()
        {

        }

        public void viewNoticeDetail()
        {

        }
       

        //get methods
        public string getPrescCount()
        {
            return newPrescCount;
        }

        public string getRefillCount()
        {
            return newRefillCount;
        }

        public string getCaseCount()
        {
            return newCaseCount;
        }

       


    }
}
