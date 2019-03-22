using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_service_system.Class
{
    class Pharmacy
    {
        string connectionCLass = "server=csdatabase.eku.edu;port=3306;database=csc340_db;username=stu_csc340;password=Colonels18;SslMode=none";

        int ID;
        string name;
        string phone;
        string street1;
        string street2;
        string city;
        char state;
        string country;


        public Pharmacy()
        {

        }
        
        //funtion methods
        //gets the doctor's name
        public string getDoctorName(int ID)
        {
            //doctor name is stored here
            string name = "";

            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "SELECT name FROM wzb_doctor WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id", ID);

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    name = myReader["Name"].ToString();
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

            if (name == "")
                name = "There is no doctor with ID number = " + ID + ".";

            return name;
        }

        public int getDoctorID(string dname)
        {
            //doctor ID is stored here
            int dID = 0; ;

            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "SELECT ID FROM wzb_doctor WHERE name = @nam";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            cmd.Parameters.AddWithValue("@nam", dname);

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    dID = Int32.Parse(myReader["ID"].ToString());
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


            return dID;
        }

        //gets the patient's name
        public string getPatientName(int ID)
        {
            //Patient name is stored here
            string name = "";

            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "SELECT name FROM wzb_patient WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id", ID);

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    name = myReader["Name"].ToString();
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

            if (name == "")
                name = "There is no patient with ID number = " + ID + ".";

            return name;
        }

        public List<string> showPotentialPatients(string potName)
        {
            string patientName = "";
            int potPatientID = 0;
            List<string> patientList = new List<string>();

            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            //query
            string query = "SELECT ID, Name FROM wzb_patient WHERE Name like @name;";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            cmd.Parameters.AddWithValue("@name", "%"+ potName + "%");

            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    potPatientID = Int32.Parse(myReader["ID"].ToString());
                    patientName = myReader["Name"].ToString();

                    patientList.Add(potPatientID.ToString());
                    patientList.Add(patientName);
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
            
            return patientList;
        }

        public List<string> getPatientInformation(int patID)
        {
            string ID, name, gender, age, phone, street1, street2, city, state, country, sickness, prescriptions, allergies, special_or_other = "";

            List<string> patientInfoList = new List<string>();

            string myConnection = connectionCLass;
            MySqlConnection myConn = new MySqlConnection(myConnection);

            

            string query = "SELECT * FROM wzb_patient WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataReader myReader;
            cmd.Parameters.AddWithValue("@id", patID);

            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    patientInfoList.Add(ID = myReader["ID"].ToString());
                    patientInfoList.Add(name = myReader["Name"].ToString());
                    patientInfoList.Add(gender = myReader["Gender"].ToString());
                    patientInfoList.Add(age = (myReader["Age"].ToString()));
                    patientInfoList.Add(phone = myReader["Phone"].ToString());
                    patientInfoList.Add(street1 = myReader["Street_1"].ToString());
                    patientInfoList.Add(street2 = myReader["Street_2"].ToString());
                    patientInfoList.Add(city = myReader["City"].ToString());
                    patientInfoList.Add(state = myReader["State"].ToString());
                    patientInfoList.Add(country = myReader["Country"].ToString());
                    //acceptedDate = DateTime.ParseExact(myReader["Accepted_Date"].ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    patientInfoList.Add(sickness = myReader["Sickness"].ToString());
                    patientInfoList.Add(prescriptions = (myReader["Prescriptions"].ToString()));
                    patientInfoList.Add(allergies = myReader["Allergies"].ToString());
                    patientInfoList.Add(special_or_other = myReader["Special_or_Other"].ToString());
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

            return patientInfoList;
        }



        //get methods
        public int getID()
        {
            return ID;
        }
        public string getName()
        {
            return name;
        }
        public string getPhone()
        {
            return phone;
        }
        public string getStreet1()
        {
            return street1;
        }
        public string getStreet2()
        {
            return street2;
        }
        public string getCity()
        {
            return city;
        }
        public char getState()
        {
            return state;
        }
        public string getCountry()
        {
            return country;
        }
    }
}
