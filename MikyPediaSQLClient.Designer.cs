
namespace Mikypedia
{
    partial class MikyPediaSQLClient
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
            this.Result = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DBUrl = new System.Windows.Forms.TextBox();
            this.Query = new System.Windows.Forms.RichTextBox();
            this.Execute = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.DBName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tables = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tables)).BeginInit();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result.Location = new System.Drawing.Point(526, 355);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(922, 275);
            this.Result.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hostname/IP";
            // 
            // DBUrl
            // 
            this.DBUrl.Location = new System.Drawing.Point(25, 47);
            this.DBUrl.Name = "DBUrl";
            this.DBUrl.Size = new System.Drawing.Size(341, 20);
            this.DBUrl.TabIndex = 2;
            this.DBUrl.Text = "hosting2095618.online.pro";
            this.DBUrl.TextChanged += new System.EventHandler(this.DBUrl_TextChanged);
            // 
            // Query
            // 
            this.Query.Location = new System.Drawing.Point(526, 33);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(922, 282);
            this.Query.TabIndex = 3;
            this.Query.Text = "";
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(925, 321);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(103, 23);
            this.Execute.TabIndex = 4;
            this.Execute.Text = "Execute query";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.button1_Click);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(25, 94);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(200, 20);
            this.User.TabIndex = 5;
            this.User.Text = "00324868_habittracker";
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(231, 94);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(200, 20);
            this.Password.TabIndex = 7;
            this.Password.Text = "00324868_habittracker";
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(25, 271);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(103, 23);
            this.Connect.TabIndex = 9;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.button2_Click);
            // 
            // DBName
            // 
            this.DBName.Location = new System.Drawing.Point(25, 225);
            this.DBName.Name = "DBName";
            this.DBName.Size = new System.Drawing.Size(341, 20);
            this.DBName.TabIndex = 10;
            this.DBName.Text = "00324868_habittracker";
            this.DBName.TextChanged += new System.EventHandler(this.DBName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "DB";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(25, 153);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 20);
            this.Port.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Port";
            // 
            // tables
            // 
            this.tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tables.Location = new System.Drawing.Point(25, 321);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(471, 309);
            this.tables.TabIndex = 14;
            // 
            // MikyPediaSQLClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 642);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DBName);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Query);
            this.Controls.Add(this.DBUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Name = "MikyPediaSQLClient";
            this.Text = "Mikypedia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Query;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox DBUrl;
        public System.Windows.Forms.TextBox User;
        public System.Windows.Forms.TextBox Password;
        public System.Windows.Forms.TextBox DBName;
        public System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.DataGridView tables;
    }
}

