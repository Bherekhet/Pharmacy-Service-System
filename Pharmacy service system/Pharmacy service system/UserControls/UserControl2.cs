using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_service_system.Class;

namespace Pharmacy_service_system
{
    public partial class UserControl2 : UserControl
    {
        //initialize objects
        Prescription prescObj;
        Pharmacy pharObj = new Pharmacy();
        Notice notObj = new Notice();

        public UserControl2()
        {
            InitializeComponent();
            //to populate listview on prescription page with prescriptions
            loadPrescription();

        }

        //method get list of prescription from prescription class
        public void loadPrescription()
        {
            //list to hold presc. detail
            List<string> prescList = new List<string>();

            //create presc. object
            Prescription preObj = new Prescription();
            prescList = preObj.receiveNewPrescription();

            //create Pharmacy object for doctor and patient name
            Pharmacy pharObj = new Pharmacy();


            //create a list for listView
            for (int i = 0; i < prescList.Count; i += 2)
            {
                ListViewItem listItem = new ListViewItem(prescList[i].ToString() + "                           " + pharObj.getDoctorName(Int32.Parse(prescList[i + 1].ToString())));
                listView1.Items.Add(listItem);
            }

        }

        private void buttonShowDetail_Click(object sender, EventArgs e)
        {
            string prescID = "";//stores prescription id to late fill out details textboxes
            
            //get the id of prescription, when the coresponding list view is selected
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                prescID = item.ToString();
                prescObj = new Prescription(Int32.Parse(prescID.Substring(15, 20).ToString()));

                textBoxPatientFullName.Text = pharObj.getPatientName(Int32.Parse(prescObj.getPatientID()));
                textBoxPrescID.Text = prescObj.getID();
                textBoxMedicineName.Text = prescObj.getMedication();
                textBoxDosage.Text = prescObj.getDosage();
                textBoxTotalRefill.Text = prescObj.getRefillTotal().ToString();

            }
            else
            {
                MessageBox.Show("Please select a prescription");
            }
            

        }

        private void buttonAck_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (textBoxPrescID.Text == "")
            {
                MessageBox.Show("Please select a prescription");
            }
            else
            {
                check = notObj.acknowledgePrescription(Int32.Parse(textBoxPrescID.Text));

                //checking the query went through
                if (check == 0)
                {
                    MessageBox.Show("Something went wrong, please try again. ");
                }
                else
                    MessageBox.Show("You have acknowledged the arrival of sent prescription. ");

                listView1.Items.Clear();
                loadPrescription();
                clear();
            }

            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = "";
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            loadPrescription();
        }

        public void clear()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = "";
            }
        }
    }
}
