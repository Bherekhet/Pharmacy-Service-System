using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_service_system.Class;

namespace Pharmacy_service_system
{
    public partial class DisplayWindow : Form
    {
        Notice notObj = new Notice();
        public DisplayWindow()
        {
            InitializeComponent();
            userControl11.BringToFront();
            buttonRefill.BackColor = Color.Brown;
        }
        

        private void buttonRefill_Click(object sender, EventArgs e)
        {
            button1Prescription.BackColor = Color.LightSeaGreen;
            button1Records.BackColor = Color.LightSeaGreen;
            buttonStatusNotice.BackColor = Color.LightSeaGreen;
            buttonRefill.BackColor = Color.Brown;
            userControl11.BringToFront();
        }

        private void button1Prescription_Click(object sender, EventArgs e)
        {
            buttonRefill.BackColor = Color.LightSeaGreen;
            button1Prescription.BackColor = Color.Brown;
            button1Records.BackColor = Color.LightSeaGreen;
            buttonStatusNotice.BackColor = Color.LightSeaGreen;
            userControl21.BringToFront();

        }
        private void button1Records_Click(object sender, EventArgs e)
        {
            buttonRefill.BackColor = Color.LightSeaGreen;
            button1Prescription.BackColor = Color.LightSeaGreen;
            button1Records.BackColor = Color.Brown;
            buttonStatusNotice.BackColor = Color.LightSeaGreen;
            userControl41.BringToFront();
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            buttonRefill.BackColor = Color.LightSeaGreen;
            button1Prescription.BackColor = Color.LightSeaGreen;
            button1Records.BackColor = Color.LightSeaGreen;
            buttonStatusNotice.BackColor = Color.Brown;
            userControl51.BringToFront();
        }
    }
}
