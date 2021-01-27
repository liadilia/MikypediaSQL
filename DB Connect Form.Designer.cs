
namespace Mikypedia
{
    partial class DBConnectForm
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
            this.DBType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.host = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WAuth = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mikypedia SQL Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DBType
            // 
            this.DBType.FormattingEnabled = true;
            this.DBType.Items.AddRange(new object[] {"MySQL", "MSSQL"});
            this.DBType.Location = new System.Drawing.Point(254, 66);
            this.DBType.Name = "DBType";
            this.DBType.Size = new System.Drawing.Size(319, 21);
            this.DBType.TabIndex = 1;
            this.DBType.Text = "MySQL";
            this.DBType.SelectedIndexChanged += new System.EventHandler(this.DBType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DB type";
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(254, 97);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(319, 20);
            this.host.TabIndex = 3;
            this.host.Text = "hosting2095618.online.pro";
            this.host.TextChanged += new System.EventHandler(this.host_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hostname/IP";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(254, 128);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(319, 20);
            this.name.TabIndex = 5;
            this.name.Text = "00324868_habittracker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DB name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(158, 251);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(198, 20);
            this.username.TabIndex = 7;
            this.username.Text = "00324868_habittracker";
            this.username.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(158, 287);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(198, 20);
            this.password.TabIndex = 9;
            this.password.Text = "00324868_habittracker";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(388, 398);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 11;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Authentication";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 270);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "OR";
            // 
            // WAuth
            // 
            this.WAuth.AutoSize = true;
            this.WAuth.Location = new System.Drawing.Point(473, 266);
            this.WAuth.Margin = new System.Windows.Forms.Padding(2);
            this.WAuth.Name = "WAuth";
            this.WAuth.Size = new System.Drawing.Size(141, 17);
            this.WAuth.TabIndex = 14;
            this.WAuth.Text = "Windows Authentication";
            this.WAuth.UseVisualStyleBackColor = true;
            this.WAuth.CheckedChanged += new System.EventHandler(this.IntegratedSecurity_CheckedChanged);
            // 
            // DBConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WAuth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.host);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DBType);
            this.Controls.Add(this.label1);
            this.Name = "DBConnectForm";
            this.Text = "Mikypedia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DBConnectForm_FormClosed);
            this.Load += new System.EventHandler(this.DBConnectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DBType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox WAuth;
    }
}