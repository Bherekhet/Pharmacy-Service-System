using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_service_system
{
    class Refill
    {
        int id;
        int phyID;
        String dosage;
        String fullName;
        String doctor;
        String refillStatus;
        String medicine;
        int refill;
        int refillTotal;
        int refillLeft;
        DateTime startDate;
        DateTime endDate;
        DateTime lastRefillDate;
        DateTime dateFilledIn;

        public Refill()
        {

        }

        /*
        public void changeStatus(String s)
        {
            string conn = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;";
            MySqlConnection myconn = new MySqlConnection(conn);
            try
            {
                Console.Write("Connecting to MySQL...");
                myconn.Open();
                string sql = "UPDATE changprescription SET status=@status WHERE id=@Id";
                MySqlCommand cmd = new MySqlCommand(sql, myconn);

                cmd.Parameters.AddWithValue("@status", s.ToString());
                cmd.Parameters.AddWithValue("@Id", id);
                //MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table has been Updated.");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                myconn.Close();
            }


        }
        

        */
        public static ArrayList indicateNewRefillRequestBrief()
        {
            ArrayList refillRequestList = new ArrayList();
            DataTable myTable = new DataTable();
            string connStr = "server=localhost;user=root;database=pharmacy;port=3306;password=;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Console.WriteLine("Connection is open");
                //string sql = "SELECT Medicine, Doctor from refills where status = 'New'";
                string sql = "SELECT patients.FullName, refills.dateFilledIn, refills.refill_ID from patients join refills on patients.Patient_ID = refills.Patient_ID where status='New' ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@phyId", phyID);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
                Console.WriteLine("Table is ready.");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            //convert the retrieved data to events and save them to the list
            foreach (DataRow row in myTable.Rows)
            {
                Refill newRefillRequest = new Refill();
                newRefillRequest.id = Int32.Parse(row["refill_ID"].ToString());
                newRefillRequest.fullName = row["FullName"].ToString();
                newRefillRequest.dateFilledIn = (DateTime)row["dateFilledIn"];
                refillRequestList.Add(newRefillRequest);
            }
            return refillRequestList;

        }

        
        public static ArrayList indicateNewRefillRequest(int id)
        {
            ArrayList refillRequestList = new ArrayList();

            DataTable myTable = new DataTable();
            string connStr = "server=localhost;user=root;database=pharmacy;port=3306;password=;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * from patients join refills on patients.Patient_ID = refills.Patient_ID where status='New' and refill_ID = @id ORDER BY refill_ID ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            //convert the retrieved data to events and save them to the list
            foreach(DataRow row in myTable.Rows)
            {
                Refill newRefillRequest = new Refill();
                newRefillRequest.fullName = row["FullName"].ToString();
                newRefillRequest.phyID = Int32.Parse(row["Patient_ID"].ToString());
                newRefillRequest.medicine = row["Medicine"].ToString();
                newRefillRequest.dosage = row["Dosage"].ToString();
                newRefillRequest.doctor = row["Doctor"].ToString();
                newRefillRequest.refillStatus = row["Status"].ToString();
                refillRequestList.Add(newRefillRequest);
            }
            return refillRequestList;
            
        } 


        public static ArrayList displayALLRefillRequests()
        {
            ArrayList refillRequestList = new ArrayList();

            DataTable myTable = new DataTable();
            string connStr = "server=localhost;user=root;database=pharmacy;port=3306;password=;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * from patients join refills on patients.Patient_ID = refills.Patient_ID where status='New' ORDER BY refill_ID ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@id", id);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            //convert the retrieved data to events and save them to the list
            foreach (DataRow row in myTable.Rows)
            {
                Refill newRefillRequest = new Refill();
                newRefillRequest.fullName = row["FullName"].ToString();
                newRefillRequest.phyID = Int32.Parse(row["Patient_ID"].ToString());
                newRefillRequest.medicine = row["Medicine"].ToString();
                Console.WriteLine("Medicine of this particular thing is "+newRefillRequest.getMedicine());
                newRefillRequest.dosage = row["Dosage"].ToString();
                newRefillRequest.doctor = row["Doctor"].ToString();
                newRefillRequest.refillStatus = row["Status"].ToString();
                refillRequestList.Add(newRefillRequest);
            }
            return refillRequestList;
        }
       
        public int getphyId()
        {
            return phyID;
        }
        public string getdosage()
        {
            return dosage;
        }

        public int getID()
        {
            return id;
        }

        public string getfullName()
        {
            return fullName;
        }
        
        public String getDoctor()
        {
            return doctor;
        }

        public String getMedicine()
        {
            return medicine;
        }

        public String getrefillStatus()
        {
            return refillStatus;
        }

        public int getRefill()
        {
            return refill;
        }

        public int getRefillTotal()
        {
            return refillTotal;
        }

        public int getRefillLeft()
        {
            return refillLeft;
        }

        public DateTime getStartDate()
        {
            return startDate;
        }

        public DateTime getEndDate()
        {
            return endDate;
        }

        public DateTime getLastRefillDate()
        {
            return lastRefillDate;
        }

        public DateTime getdateFilledIn()
        {
            return dateFilledIn;
        }

    }
    /*
           //string myConnection = "server=localhost;port=3306;database=Pharmacy;username=root;password=";
           string myConnection = "server=localhost;port=3306;database=Pharmacy;username=root;password=";
           MySqlConnection conn = new MySqlConnection(myConnection);
           MySqlCommand cmd = new MySqlCommand("select r.Patient_ID, p.LastName, P.FirstName from refills r, patients p where r.Patient_ID = p.Patient_ID group by r.Refill_ID", conn);
           conn.Open();

           try
           {

               //MessageBox.Show("Connection open");
               MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
               dataAdapter.SelectCommand = cmd;
               DataTable dst1 = new DataTable();
               dataAdapter.Fill(dst1);
               dataGridView1.DataSource = dst1;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
           finally
           {
               conn.Close();
           }
           */


}
