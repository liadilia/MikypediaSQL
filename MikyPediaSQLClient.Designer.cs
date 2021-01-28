
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
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.DBUrl = new System.Windows.Forms.TextBox();
            this.Query = new System.Windows.Forms.RichTextBox();
            this.Execute = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.DBName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tables = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tables)).BeginInit();
            this.SuspendLayout();
            // 
            // resultGrid
            // 
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Location = new System.Drawing.Point(480, 250);
            this.resultGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            this.resultGrid.RowHeadersWidth = 51;
            this.resultGrid.Size = new System.Drawing.Size(1064, 416);
            this.resultGrid.TabIndex = 0;
            // 
            // DBUrl
            // 
            this.DBUrl.Enabled = false;
            this.DBUrl.Location = new System.Drawing.Point(139, 21);
            this.DBUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBUrl.Name = "DBUrl";
            this.DBUrl.Size = new System.Drawing.Size(305, 22);
            this.DBUrl.TabIndex = 2;
            this.DBUrl.TextChanged += new System.EventHandler(this.DBUrl_TextChanged);
            // 
            // Query
            // 
            this.Query.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Query.Location = new System.Drawing.Point(480, 41);
            this.Query.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(1065, 125);
            this.Query.TabIndex = 3;
            this.Query.Text = "select * from habits";
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(943, 201);
            this.Execute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(137, 28);
            this.Execute.TabIndex = 4;
            this.Execute.Text = "Execute query";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(32, 119);
            this.Connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(411, 28);
            this.Connect.TabIndex = 9;
            this.Connect.Text = "Connect to another DB";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.button2_Click);
            // 
            // DBName
            // 
            this.DBName.Enabled = false;
            this.DBName.Location = new System.Drawing.Point(139, 63);
            this.DBName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBName.Name = "DBName";
            this.DBName.Size = new System.Drawing.Size(305, 22);
            this.DBName.TabIndex = 10;
            this.DBName.TextChanged += new System.EventHandler(this.DBName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "DB";
            // 
            // tables
            // 
            this.tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tables.Location = new System.Drawing.Point(33, 180);
            this.tables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tables.Name = "tables";
            this.tables.ReadOnly = true;
            this.tables.RowHeadersWidth = 51;
            this.tables.Size = new System.Drawing.Size(412, 594);
            this.tables.TabIndex = 14;
            this.tables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tables_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hostname/IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Your query here:";
            // 
            // logText
            // 
            this.logText.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logText.Location = new System.Drawing.Point(480, 684);
            this.logText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logText.Size = new System.Drawing.Size(1063, 89);
            this.logText.TabIndex = 17;
            // 
            // MikyPediaSQLClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 798);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DBName);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Query);
            this.Controls.Add(this.DBUrl);
            this.Controls.Add(this.resultGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MikyPediaSQLClient";
            this.Text = "Mikypedia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MikyPediaSQLClient_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox logText;

        #endregion

        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.RichTextBox Query;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox DBUrl;
        public System.Windows.Forms.TextBox DBName;
        private System.Windows.Forms.DataGridView tables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

