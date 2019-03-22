using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pharmacy_service_system
{
    public partial class RefillForm : Form
    {
        ArrayList refillRequestList = new ArrayList();
        ArrayList refillRequestlistdetail = new ArrayList();

        HomePage HP = new HomePage();

        public int temp = 0;

        int selectedIndex = -1;
        
        
        
        
        public RefillForm()
        {

            InitializeComponent();
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            HP.Show();
            this.Hide();

        }
       
        private void Refill_Load(object sender, EventArgs e)
        {
            refillRequestList = Refill.indicateNewRefillRequestBrief();
            panel5.Visible = true;
            listBox1.Items.Clear();

            if(refillRequestList != null)
            {
                Console.WriteLine("Yes   " + refillRequestList.Count);

                for(int i=0; i<refillRequestList.Count; i++)
                {
                    Refill thisRefill = (Refill)(refillRequestList[i]);
                    temp = thisRefill.getID(); 
                    String s = thisRefill.getfullName().PadRight(30) + thisRefill.getdateFilledIn();
                    //String s = thisRefill.getlastName().PadRight(10) + thisRefill.getdateFilledIn();
                    Console.WriteLine(s);
                    listBox1.Items.Add(s);
                }
            }
            else
            {
                Console.WriteLine("No");

                String s = "There is not any New Refill Request.";
                listBox1.Items.Add(s);
            }
            

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            selectedIndex = listBox1.SelectedIndex;
            refillRequestlistdetail = Refill.displayALLRefillRequests();
            Console.WriteLine(" Count of DisplayALLRefillRequests " + Refill.displayALLRefillRequests().Count);

            if (refillRequestlistdetail != null)
            {
                Refill thisRefill2 = (Refill)refillRequestlistdetail[selectedIndex];
                Console.WriteLine("Index " + selectedIndex);
                fullName.Text = thisRefill2.getfullName().ToString();
                patientID.Text = thisRefill2.getphyId().ToString();
                medication.Text = thisRefill2.getMedicine().ToString();
                dosage.Text = thisRefill2.getdosage().ToString();
                doctor.Text = thisRefill2.getDoctor().ToString();
                status.Text = thisRefill2.getrefillStatus().ToString();

            }
            else
            {
                Console.WriteLine("There are no new refill requests");
            }

            //to compare with prescription in database
            string myConnection = "server=localhost;port=3306;database=Pharmacy;username=root;password=";
            MySqlConnection conn = new MySqlConnection(myConnection);
            MySqlCommand cmd = new MySqlCommand("select * from refills", conn);
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


        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  Refill thisRefill = (Refill)refillRequestListDetail[selectedIndex];
           // thisRefill.changeStatus("ack");
        }
    }

    
}
/*
       private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           panel5.Hide();
           panel4.Show();
           int index = e.RowIndex;
           DataGridViewRow selectedRow = dataGridView1.Rows[index];
           Patient_ID = selectedRow.Cells[0].Value.ToString();

           string myConnection = "server=localhost;port=3306;database=Pharmacy;username=root;password=";
           MySqlConnection conn = new MySqlConnection(myConnection);
           MySqlCommand cmd = new MySqlCommand("select r.Patient_ID, r.Refill_ID, p.LastName, P.FirstName from refills r, patients p where r.Patient_ID = '"+ Patient_ID+"'", conn);
           conn.Open();

           try
           {

               //MessageBox.Show("Connection open");
               MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
               dataAdapter.SelectCommand = cmd;
               DataTable dst1 = new DataTable();
               dataAdapter.Fill(dst1);
               dataGridView2.DataSource = dst1;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
           finally
           {
               conn.Close();
           }


           DisplayRefillDetails(Patient_ID);


       }
       */
