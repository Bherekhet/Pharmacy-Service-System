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
    public partial class UserControl5 : UserControl
    {
        Notice notObj = new Notice();
        public int selected1 = 0;
        public int selected2 = 0;
        public UserControl5()
        {
            InitializeComponent();
            loadCase();
            loadPrescStatus();
            loadRefillStatus();
        }


        public void loadCase()
        {
            //list to hold presc. detail
            List<string> caseList = new List<string>();

            //create notice. object
            Notice notObj = new Notice();
            caseList = notObj.getDoctorNotice();

            //create a list for listView
            for (int i = 0; i < caseList.Count; i+=3)
            {
                ListViewItem listItem = new ListViewItem(caseList[i].ToString());
                listItem.SubItems.Add(caseList[i + 1].ToString());
                listItem.SubItems.Add(caseList[i + 2].ToString());
                listView2.Items.Add(listItem);
            }

        }


        //1 = refill
        //0 = prescription
        public void loadRefillStatus()
        {
            List<string> list = new List<string>();

            list = notObj.getRefillPrescription(1);
            //create a list for listView
            for (int i = 0; i < list.Count; i += 2)
            {
                ListViewItem listItem = new ListViewItem(list[i].ToString());
                listItem.SubItems.Add(list[i + 1].ToString());
                listView1.Items.Add(listItem);
            }

        }

        public void loadPrescStatus()
        {
            List<string> list = new List<string>();

            list = notObj.getRefillPrescription(0);
            for (int i = 0; i < list.Count; i += 2)
            {
                ListViewItem listItem = new ListViewItem(list[i].ToString());
                listItem.SubItems.Add(list[i + 1].ToString());
                listView3.Items.Add(listItem);
            }
        }
        private void buttonAck_Click(object sender, EventArgs e)
        {
            Notice notObj = new Notice();
            int check = 0;

            string noticeID = (listView2.SelectedItems[0].Text);
            Console.WriteLine(noticeID);

            if(noticeID.Length == 0)
            {
                MessageBox.Show("Please select a notice first. ");
            }
            else
            {
                check = notObj.ackDoctorNotice(Int32.Parse(noticeID));

                if (check == 1)
                {
                    MessageBox.Show("You have acknowledged the arrival of doctor notice");
                    listView2.Items.Clear();
                    loadCase();
                }
                else
                {
                    MessageBox.Show("Something went wrong, Please try again. ");
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            loadCase();
        }

        private void buttonSendNotice_Click(object sender, EventArgs e)
        {
            int check = 0;
            int docID;
            Notice notObj = new Notice();
            Pharmacy pharObj = new Pharmacy();


            //get doc ID;
            string temp = (pharObj.getDoctorID(textBoxDoctorName.Text).ToString());

            if (Int32.Parse(temp) == 0)
            {
                MessageBox.Show("Doctor doesn't exist. ");
            }
            else
            {
                docID = Int32.Parse(temp);
                check = notObj.sendNoticeToDoctor(docID, textBoxDescription.Text);
                if (check == 1)
                {
                    MessageBox.Show("You have successfully sent a case to doctor. ");
                    textBoxDoctorName.Text = "";
                    textBoxDescription.Text = "";
                }
                else
                {
                    MessageBox.Show("Something went wrong, Please try again. ");
                }
            } 
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDoctorName.Text = "";
            textBoxDescription.Text = "";
        }

        private void buttonReleasePatient_Click(object sender, EventArgs e)
        {
            int check = 0;

            if ((listView1.SelectedItems.Count > 0))
            {
                selected1 = Int32.Parse(listView1.SelectedItems[0].Text);
                check = notObj.releasePatient(selected1);
                if (check == 1)
                {
                    MessageBox.Show("'Medication ready' is sent... ");
                    textBoxDoctorName.Text = "";
                    textBoxDescription.Text = "";
                }
                else
                {
                    MessageBox.Show("Something went wrong, Please try again. ");
                }
            }
            else if ((listView3.SelectedItems.Count > 0))
            {
                selected2 = Int32.Parse(listView3.SelectedItems[0].Text);
                check = notObj.releasePatient(selected2);
                if (check == 1)
                {
                    MessageBox.Show("'Medication ready' is sent... ");
                    textBoxDoctorName.Text = "";
                    textBoxDescription.Text = "";
                }
                else
                {
                    MessageBox.Show("Something went wrong, Please try again. ");
                }
            }
            else
            {
                MessageBox.Show("Please select from the list first. ");

            }

        }

        private void buttonRefreshPage_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView3.Items.Clear();
            loadPrescStatus();
            loadRefillStatus();
        }

        
    }
}
