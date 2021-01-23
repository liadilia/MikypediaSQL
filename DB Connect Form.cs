using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string s = host.Text + " " + name.Text + " " + username.Text + " " + password.Text;
       //  connection = new DBConnection( host.Text, name.Text, username.Text, password.Text);
          
            if (s != null)
            {
                MessageBox.Show(s);
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

      
    }
}
