using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_service_system.Class
{
    class Notice
    {
        string connectionCLass = "server=csdatabase.eku.edu;port=3306;database=csc340_db;username=stu_csc340;password=Colonels18;SslMode=none";

        int PrescID;
        string type;
        string to;
        string from;
        string message;
        string response;


        //check type and convert to string
        //----------
        // Group
        //----------

        // Doctor
        //----------
        // Set Appt ------------------------ A ---appointment made
        // Grant/Reject Refills ------------ R ---Refill granted/rejected/in process
        // Doctor request for medical records M --medical record request

        // Patient
        //----------
        // Request Phone Call -------------- P ---Phone call request accepted

        //----------
        // Individual
        //----------
        // Pharmacy Recevies Refill Req ---- E ---Refill pharmacy request received
        // Pharmacy Receives New Presc ----- N ---Prescription pharmacy request received
        // When Medicine is Ready ---------- WP ---Medicine is ready
        // Doctor DIscuss with Pharmacy ---- DD 
        // Pharmacy discuss with Doctor ---- DP





        //method to acknowlegde prescription from doctor
        public int acknowledgePrescription(int prescID)
        {
            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "Update wzb_prescription set status = 'Received' where ID = @id and Type = 'NP' ";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id", prescID);
            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                return 1;
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

        public int acknowledgeRefill(int prescID)
        {
            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "Update wzb_prescription set status = 'Received' where ID = @id and Type = 'RE' ";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id", prescID);
            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                return 1;
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

        //get cases sent from doctor
        public List<string> getDoctorNotice()
        {
            Pharmacy pharObj = new Pharmacy();
            List<string> caseList = new List<string>();

            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "Select * from wzb_notice where Type_is = 'DD' and response = '0'";
            MySqlCommand cmd = new MySqlCommand(query, myConn);

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    type = myReader["Type_is"].ToString();
                    response = myReader["Response"].ToString();
                    to = myReader["Send_to"].ToString();
                    from = myReader["Received_from"].ToString();
                    message = myReader["Message"].ToString();
                    caseList.Add(myReader["Received_from"].ToString());
                    caseList.Add(pharObj.getDoctorName(Int32.Parse(from)));
                    caseList.Add(myReader["Message"].ToString());
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
            return caseList;
        }

        public int ackDoctorNotice(int notID) 
        {
            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "Update wzb_notice set response = '1' where Received_from = @ID and Type_is = 'DD'";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            cmd.Parameters.AddWithValue("@ID", notID);
            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                return 1;
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

        public int sendNoticeToDoctor(int docID, string message)
        {
            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "insert into wzb_notice(type_is, response, send_to, received_from, message ) " +
                "values ('DD', '0', @ID, 3, @desc)";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            cmd.Parameters.AddWithValue("@ID", docID);
            cmd.Parameters.AddWithValue("@desc", message);
            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                return 1;
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

        public List<string> getRefillPrescription(int fix)
        {
            string status = "";
            string identifier = "";
            if (fix == 1)
            {
                identifier = "RE";
                status = "Received";
            }
            else if (fix == 0)
            {
                identifier = "NP";
                status = "Received";
            }else if(fix == 2)
            {
                identifier = "RE";
                status = "New";
            }
            else
            {
                identifier = "NP";
                status = "New";
            }

            List<string> list = new List<string>();
            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "Select ID, Medication from wzb_prescription where Type = @iden and status = @stat";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            cmd.Parameters.AddWithValue("@iden", identifier);
            cmd.Parameters.AddWithValue("@stat", status);

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    list.Add(myReader["ID"].ToString());
                    list.Add(myReader["Medication"].ToString());
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
            return list;
        }
        public int releasePatient(int presID)
        {
            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "Update wzb_Prescription set status = 'Ready' where ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            cmd.Parameters.AddWithValue("@ID", presID);
            try
            {
                myConn.Open();
                cmd.ExecuteNonQuery();
                return 1;
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


        public string getType()
        {
            return type;
        }

        public string getTo()
        {
            return to;
        }

        public string getFrom()
        {
            return from;
        }

        public string getMessage()
        {
            return message;
        }

        public string getResponse()
        {
            return response;
        }
    }
}
