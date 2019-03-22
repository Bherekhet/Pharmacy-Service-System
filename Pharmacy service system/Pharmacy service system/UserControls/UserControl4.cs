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
    public partial class UserControl4 : UserControl
    {
        public int patientID;

        Prescription prescObj = new Prescription();
        Notice notObj = new Notice();
        Pharmacy pharObj = new Pharmacy();

        public UserControl4()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            List<string> newList = new List<string>();
            string passName = "";

            if (textBoxFirstName.Text == "")
            {
                if (textBoxLastName.Text == "")
                {
                    passName = textBoxLastName.Text;
                }
                else
                {
                    passName = textBoxLastName.Text;
                } 
            }
            else if(textBoxLastName.Text == "")
            {
                passName = textBoxFirstName.Text;
            }
            else
            {
                passName = textBoxFirstName.Text + " " + textBoxLastName.Text;
            }
                

            newList = pharObj.showPotentialPatients(passName);

            //create a list for listView
            for (int i = 0; i < newList.Count; i+=2)
            {
                ListViewItem listItem = new ListViewItem(newList[i]);
                listItem.SubItems.Add(newList[i + 1]);
                listView1.Items.Add(listItem);
            }


        }

        private void buttonViewPatientRecord_Click(object sender, EventArgs e)
        {
            patientID = Int32.Parse(listView1.SelectedItems[0].Text);
            List<string> infoList = pharObj.getPatientInformation(patientID);

           
            //creates a string array to get patient records through patient class using patient username
            //string[] queriedPatientRecored = patObj.getPatientRecords(patientID);

            //connect the labels with the right patient record(information about patient)
            labelFullName.Text = infoList[1];
            labelPatientGender.Text = infoList[2];
            labelAge.Text = infoList[3];
            labelTelephone.Text = infoList[4];
            labelAddress.Text = infoList[5];
            labelSickness.Text = infoList[6];
            labelAllergies.Text = infoList[7];
            labelSpecial1.Text = infoList[8];
            labelSpecial2.Text = infoList[9];
            
        }
    }
}
