using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Pharmacy_service_system.Class;

namespace Pharmacy_service_system
{
    public partial class LoginPage : Form
    {
        public string loginUserName;
        public string loginPassword;
        //private int attempt = 3;

        public LoginPage()
        {
            InitializeComponent();
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            storeKeys sK = new storeKeys();
            int check = 0;

            check = storeKeys.validateUser(textBoxUserName.Text, textBoxPassword.Text);
            
            if(check == 0)
            {
                MessageBox.Show("Please enter the correct username and password! ");
            }
            else
            {
                DisplayWindow DW = new DisplayWindow();
                DW.Show();
                this.Hide();
            }

            
        }
    }
}
