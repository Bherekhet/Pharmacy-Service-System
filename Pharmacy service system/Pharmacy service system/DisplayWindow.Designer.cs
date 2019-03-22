namespace Pharmacy_service_system
{
    partial class DisplayWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMainWindow = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStatusNotice = new System.Windows.Forms.Button();
            this.button1Records = new System.Windows.Forms.Button();
            this.buttonRefill = new System.Windows.Forms.Button();
            this.button1Prescription = new System.Windows.Forms.Button();
            this.userControl11 = new Pharmacy_service_system.UserControl1();
            this.userControl51 = new Pharmacy_service_system.UserControl5();
            this.userControl41 = new Pharmacy_service_system.UserControl4();
            this.userControl21 = new Pharmacy_service_system.UserControl2();
            this.panelMainWindow.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainWindow
            // 
            this.panelMainWindow.Controls.Add(this.panel2);
            this.panelMainWindow.Controls.Add(this.panel1);
            this.panelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainWindow.Location = new System.Drawing.Point(0, 0);
            this.panelMainWindow.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainWindow.Name = "panelMainWindow";
            this.panelMainWindow.Size = new System.Drawing.Size(1401, 727);
            this.panelMainWindow.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControl11);
            this.panel2.Controls.Add(this.userControl51);
            this.panel2.Controls.Add(this.userControl41);
            this.panel2.Controls.Add(this.userControl21);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 727);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.buttonStatusNotice);
            this.panel1.Controls.Add(this.button1Records);
            this.panel1.Controls.Add(this.buttonRefill);
            this.panel1.Controls.Add(this.button1Prescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 727);
            this.panel1.TabIndex = 22;
            // 
            // buttonStatusNotice
            // 
            this.buttonStatusNotice.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonStatusNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatusNotice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStatusNotice.Location = new System.Drawing.Point(24, 333);
            this.buttonStatusNotice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStatusNotice.Name = "buttonStatusNotice";
            this.buttonStatusNotice.Size = new System.Drawing.Size(195, 64);
            this.buttonStatusNotice.TabIndex = 28;
            this.buttonStatusNotice.Text = "Status/Notice";
            this.buttonStatusNotice.UseVisualStyleBackColor = false;
            this.buttonStatusNotice.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // button1Records
            // 
            this.button1Records.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Records.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1Records.Location = new System.Drawing.Point(24, 242);
            this.button1Records.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1Records.Name = "button1Records";
            this.button1Records.Size = new System.Drawing.Size(195, 64);
            this.button1Records.TabIndex = 27;
            this.button1Records.Text = "Records";
            this.button1Records.UseVisualStyleBackColor = false;
            this.button1Records.Click += new System.EventHandler(this.button1Records_Click);
            // 
            // buttonRefill
            // 
            this.buttonRefill.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefill.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRefill.Location = new System.Drawing.Point(24, 56);
            this.buttonRefill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(195, 64);
            this.buttonRefill.TabIndex = 24;
            this.buttonRefill.Text = "Refill";
            this.buttonRefill.UseVisualStyleBackColor = false;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRefill_Click);
            // 
            // button1Prescription
            // 
            this.button1Prescription.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1Prescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Prescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1Prescription.Location = new System.Drawing.Point(24, 147);
            this.button1Prescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1Prescription.Name = "button1Prescription";
            this.button1Prescription.Size = new System.Drawing.Size(195, 64);
            this.button1Prescription.TabIndex = 25;
            this.button1Prescription.Text = "Prescription";
            this.button1Prescription.UseVisualStyleBackColor = false;
            this.button1Prescription.Click += new System.EventHandler(this.button1Prescription_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Margin = new System.Windows.Forms.Padding(5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1151, 727);
            this.userControl11.TabIndex = 1;
            // 
            // userControl51
            // 
            this.userControl51.Location = new System.Drawing.Point(0, 0);
            this.userControl51.Margin = new System.Windows.Forms.Padding(5);
            this.userControl51.Name = "userControl51";
            this.userControl51.Size = new System.Drawing.Size(1151, 727);
            this.userControl51.TabIndex = 4;
            // 
            // userControl41
            // 
            this.userControl41.Location = new System.Drawing.Point(0, 0);
            this.userControl41.Margin = new System.Windows.Forms.Padding(5);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(1151, 727);
            this.userControl41.TabIndex = 3;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(0, 0);
            this.userControl21.Margin = new System.Windows.Forms.Padding(5);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1151, 727);
            this.userControl21.TabIndex = 2;
            // 
            // DisplayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1401, 727);
            this.Controls.Add(this.panelMainWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DisplayWindow";
            this.Text = "DisplayWindow";
            this.panelMainWindow.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStatusNotice;
        private System.Windows.Forms.Button button1Records;
        private System.Windows.Forms.Button buttonRefill;
        private System.Windows.Forms.Button button1Prescription;
        private System.Windows.Forms.Panel panel2;
        private UserControl2 userControl21;
        private UserControl1 userControl11;
        private UserControl4 userControl41;
        private UserControl5 userControl51;
    }
}