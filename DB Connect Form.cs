using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mikypedia
{
    public partial class Form1 : Form
    {
        private DBConnection connection;
      
        private MikyPediaSQLClient Editor;

        private void connect_Click_1(object sender, EventArgs e)

        {

            Enum.TryParse(DBType.Text, out DbTypes type);

            DbConnection dbConn = new DatabaseConnectionBuilder()
                .withType(type)
                .setHost(host.Text)
                .setdbName(name.Text)
                .setUsername(username.Text)
                .setPassword(password.Text)
                .build();

       

            if (dbConn != null)
            {
                MessageBox.Show("Connection Open  !");
                this.Hide();
                Editor = new MikyPediaSQLClient();
                Editor.Show();
            }


         
        }





        public Form1()
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

        }

        private void host_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
