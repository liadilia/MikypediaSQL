using System;

using System.Data.Common;

using System.Windows.Forms;

namespace Mikypedia
{
    public partial class DBConnectForm : Form
    {
    
        private MikyPediaSQLClient Editor;
        

        private void connect_Click_1(object sender, EventArgs e)

        {
          
            Enum.TryParse(DBType.Text, out DbTypes type);

            try
            {

                DbConnection dbConn = new DatabaseConnectionBuilder()
                    .withType(type)
                    .setHost(host.Text)
                    .setdbName(name.Text)
                    .setUsername(username.Text)
                    .setPassword(password.Text)
                    .build();

                
                this.Hide();
                Editor = new MikyPediaSQLClient(dbConn, DBType.Text);
                Editor.Show();
            } catch (Exception exception)
            {
                MessageBox.Show("Error when attempting to open the connection " + exception);
            }



        }


        public DBConnectForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DBType.Text== "MSSQL")
            {
                host.Text = "localhost";
                name.Text = "AdventureWorks";
                WAuth.Checked = true;
            }
        }

        private void host_TextChanged(object sender, EventArgs e)
        {

        }

        private void DBConnectForm_Load(object sender, EventArgs e)
        {

        }

        private void IntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (WAuth.Checked)
            {
                DBType.Text = "MSSQL";
                username.Enabled = false;
                password.Enabled = false;
            }
            else
            {
                username.Enabled = true;
                password.Enabled = true;
            }
        }
    }
}
