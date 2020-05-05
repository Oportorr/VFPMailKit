namespace VFPMailKit
{
    partial class TestEmail
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSsl = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 370);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 41;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Priority";
            // 
            // cboPriority
            // 
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Items.AddRange(new object[] {
            "Normal",
            "Low",
            "High"});
            this.cboPriority.Location = new System.Drawing.Point(127, 374);
            this.cboPriority.Margin = new System.Windows.Forms.Padding(4);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(160, 24);
            this.cboPriority.TabIndex = 39;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(127, 305);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(457, 63);
            this.txtBody.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 307);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Messages";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(127, 277);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(455, 22);
            this.txtSubject.TabIndex = 36;
            this.txtSubject.Text = "Testing From C#";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 280);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Subject";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(127, 249);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(455, 22);
            this.txtTo.TabIndex = 34;
            this.txtTo.Text = "oscarportorreal@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 253);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "To";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(127, 222);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(455, 22);
            this.txtFrom.TabIndex = 32;
            this.txtFrom.Text = "casinopits@gmail.com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 226);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Use SSL";
            // 
            // cboSsl
            // 
            this.cboSsl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSsl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSsl.FormattingEnabled = true;
            this.cboSsl.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboSsl.Location = new System.Drawing.Point(127, 161);
            this.cboSsl.Margin = new System.Windows.Forms.Padding(4);
            this.cboSsl.Name = "cboSsl";
            this.cboSsl.Size = new System.Drawing.Size(160, 24);
            this.cboSsl.TabIndex = 29;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(127, 134);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(455, 22);
            this.txtPass.TabIndex = 28;
            this.txtPass.Text = "CasinoOscarSoft28";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(127, 107);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(455, 22);
            this.txtUser.TabIndex = 26;
            this.txtUser.Text = "casinopits@gmail.com";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "User";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(127, 80);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(455, 22);
            this.txtPort.TabIndex = 24;
            this.txtPort.Text = "587";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "SMTP Port";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(127, 53);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(455, 22);
            this.txtServer.TabIndex = 22;
            this.txtServer.Text = "smtp.gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "SMTP Server";
            // 
            // TestEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboPriority);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboSsl);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Name = "TestEmail";
            this.Text = "TestEmail";
            this.Load += new System.EventHandler(this.TestEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSsl;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
    }
}