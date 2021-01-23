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
using MySql.Data.MySqlClient;


namespace Mikypedia
{

    
    public partial class MikyPediaSQLClient : Form
    {


        DBConnection connection = null;
        public MikyPediaSQLClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String query = Query.Text;



            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            if (connection.conn != null)
            {
       //         MyDA.SelectCommand = new MySqlCommand(query, connection.conn);

                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                Result.DataSource = bSource;
            }
            else
            {
                MessageBox.Show("Connection with DB is not yet established");
            }
        }

        private void button2_Click(object sender, EventArgs e)

        {

            connection = new DBConnection(DBUrl.Text, DBName.Text, User.Text, Password.Text);
            String query = "show tables";
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
       //     MyDA.SelectCommand = new MySqlCommand(query, connection.conn);
            if (connection.conn== null)
            {
                MessageBox.Show("Conn is null");
            }
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            tables.DataSource = bSource;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DBUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void DBName_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
