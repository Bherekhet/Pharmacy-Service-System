using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_service_system.Class
{
    class Prescription
    {
        string connectionCLass = "server=csdatabase.eku.edu;port=3306;database=csc340_db;username=stu_csc340;password=Colonels18;SslMode=none";

        string ID;
        string medication;
        string patientID;
        string doctorID;
        int pharmacyID;
        string status;
        string type;
        string dosage;
        int refillTotal;
        string startDate;
        string endDate;
        string lastRefillDate;
        int refillCount;

        public Prescription()
        {

        }

        public Prescription(int input)
        {
            //list to hold prescription from doctor
            List<string> prescList = new List<string>();

            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "SELECT * FROM wzb_prescription WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            cmd.Parameters.AddWithValue("@ID", input);

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    //populate the get methods when object gets created
                    ID = (myReader["ID"].ToString());
                    medication = myReader["Medication"].ToString();
                    patientID = (myReader["Patient_ID"].ToString());
                    doctorID = (myReader["Doctor_ID"].ToString());
                    status = myReader["Status"].ToString();
                    type = myReader["Type"].ToString();
                    dosage = myReader["Dosage"].ToString();
                    startDate = myReader["Start_date"].ToString();
                    endDate = myReader["End_date"].ToString();
                    lastRefillDate = (myReader["Last_refill_date"]).ToString();
                    refillTotal = Int32.Parse(myReader["Refill_Total"].ToString());
                    refillCount = Int32.Parse(myReader["Refill_Count"].ToString());

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
        }

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
        // When Medicine is Ready ---------- W ---Medicine is ready
        //funtion methods


        //queries database for new prescription from doctor(notice)
        public List<string> receiveNewPrescription()
        {
            //list to hold prescription from doctor
            List<string> prescList = new List<string>();

            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "SELECT * FROM wzb_prescription WHERE Status = 'New' and Type = 'NP'";
            MySqlCommand cmd = new MySqlCommand(query, myConn);

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    //populate the get methods when object gets created
                    prescList.Add(ID = (myReader["ID"].ToString()));
                    prescList.Add(doctorID = (myReader["doctor_ID"].ToString()));
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


            return prescList;
        }

        //queries database for new Refill from Patient(notice)
        public List<string> receiveNewRefill()
        {
            //list to hold refill from Patient
            List<string> prescList = new List<string>();

            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "SELECT * FROM wzb_prescription WHERE Status = 'New' and Type = 'RE'";
            MySqlCommand cmd = new MySqlCommand(query, myConn);

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    //populate the get methods when object gets created
                    prescList.Add(ID = (myReader["ID"].ToString()));
                    prescList.Add(patientID = (myReader["patient_ID"].ToString()));
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



            return prescList;
        }


        //get methods

        public string getID()
        {
            return ID;
        }
        public string getMedication()
        {
            return medication;
        }
        public string getPatientID()
        {
            return patientID;
        }
        public string getDoctorID()
        {
            return doctorID;
        }
        public int getPharmacyID()
        {
            return pharmacyID;
        }
        public string getStatus()
        {
            return status;
        }
        public string getType()
        {
            return type;
        }
        public string getDosage()
        {
            return dosage;
        }
        public string getStartDate()
        {
            return startDate;
        }
        public string getEndDate()
        {
            return endDate;
        }
        public string getLastRefillDate()
        {
            return lastRefillDate;
        }
        public int getRefillTotal()
        {
            return refillTotal;
        }

        public int getRefillCount()
        {
            return refillCount;
        }
    }
}
