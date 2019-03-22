namespace Pharmacy_service_system
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxCaseMessage = new System.Windows.Forms.TextBox();
            this.textBoxPrescriptionMessage = new System.Windows.Forms.TextBox();
            this.textBoxRefillMessage = new System.Windows.Forms.TextBox();
            this.buttonRefill = new System.Windows.Forms.Button();
            this.buttonPrescription = new System.Windows.Forms.Button();
            this.buttonCase = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonPatientRecords = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged in as \"*Bereket\"";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 64);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(366, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logo spot";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.textBoxCaseMessage);
            this.panel2.Controls.Add(this.textBoxPrescriptionMessage);
            this.panel2.Controls.Add(this.textBoxRefillMessage);
            this.panel2.Location = new System.Drawing.Point(3, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 29);
            this.panel2.TabIndex = 3;
            // 
            // textBoxCaseMessage
            // 
            this.textBoxCaseMessage.Location = new System.Drawing.Point(520, 0);
            this.textBoxCaseMessage.Name = "textBoxCaseMessage";
            this.textBoxCaseMessage.ReadOnly = true;
            this.textBoxCaseMessage.Size = new System.Drawing.Size(181, 22);
            this.textBoxCaseMessage.TabIndex = 5;
            // 
            // textBoxPrescriptionMessage
            // 
            this.textBoxPrescriptionMessage.Location = new System.Drawing.Point(254, 4);
            this.textBoxPrescriptionMessage.Name = "textBoxPrescriptionMessage";
            this.textBoxPrescriptionMessage.ReadOnly = true;
            this.textBoxPrescriptionMessage.Size = new System.Drawing.Size(204, 22);
            this.textBoxPrescriptionMessage.TabIndex = 6;
            // 
            // textBoxRefillMessage
            // 
            this.textBoxRefillMessage.Location = new System.Drawing.Point(17, 7);
            this.textBoxRefillMessage.Name = "textBoxRefillMessage";
            this.textBoxRefillMessage.ReadOnly = true;
            this.textBoxRefillMessage.Size = new System.Drawing.Size(181, 22);
            this.textBoxRefillMessage.TabIndex = 4;
            // 
            // buttonRefill
            // 
            this.buttonRefill.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefill.Location = new System.Drawing.Point(17, 20);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(181, 66);
            this.buttonRefill.TabIndex = 4;
            this.buttonRefill.Text = "Refill";
            this.buttonRefill.UseVisualStyleBackColor = true;
            this.buttonRefill.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPrescription
            // 
            this.buttonPrescription.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrescription.Location = new System.Drawing.Point(254, 20);
            this.buttonPrescription.Name = "buttonPrescription";
            this.buttonPrescription.Size = new System.Drawing.Size(204, 66);
            this.buttonPrescription.TabIndex = 5;
            this.buttonPrescription.Text = "Prescription";
            this.buttonPrescription.UseVisualStyleBackColor = true;
            // 
            // buttonCase
            // 
            this.buttonCase.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCase.Location = new System.Drawing.Point(520, 20);
            this.buttonCase.Name = "buttonCase";
            this.buttonCase.Size = new System.Drawing.Size(181, 66);
            this.buttonCase.TabIndex = 6;
            this.buttonCase.Text = "Case";
            this.buttonCase.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(520, 130);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(181, 66);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonPatientRecords
            // 
            this.buttonPatientRecords.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientRecords.Location = new System.Drawing.Point(254, 130);
            this.buttonPatientRecords.Name = "buttonPatientRecords";
            this.buttonPatientRecords.Size = new System.Drawing.Size(204, 66);
            this.buttonPatientRecords.TabIndex = 8;
            this.buttonPatientRecords.Text = "Patient Records";
            this.buttonPatientRecords.UseVisualStyleBackColor = true;
            // 
            // buttonStatus
            // 
            this.buttonStatus.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatus.Location = new System.Drawing.Point(17, 130);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(181, 66);
            this.buttonStatus.TabIndex = 7;
            this.buttonStatus.Text = "Status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.buttonPatientRecords);
            this.groupBox1.Controls.Add(this.buttonStatus);
            this.groupBox1.Controls.Add(this.buttonCase);
            this.groupBox1.Controls.Add(this.buttonPrescription);
            this.groupBox1.Controls.Add(this.buttonRefill);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(3, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 224);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasks";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxCaseMessage;
        private System.Windows.Forms.TextBox textBoxPrescriptionMessage;
        private System.Windows.Forms.TextBox textBoxRefillMessage;
        private System.Windows.Forms.Button buttonRefill;
        private System.Windows.Forms.Button buttonPrescription;
        private System.Windows.Forms.Button buttonCase;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonPatientRecords;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}