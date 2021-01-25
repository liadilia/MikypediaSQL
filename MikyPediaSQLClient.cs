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


        DbConnection conn = null;
        string dbType = null;
        
        public MikyPediaSQLClient(DbConnection conn, string dbType)
        {
            InitializeComponent();
            this.conn = conn;
            this.dbType = dbType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String query = Query.Text;

            setResults(Result, query);
        }

        private void button2_Click(object sender, EventArgs e)

        {
    
            String query = "show tables";
            setResults(tables, query);

        }


        private void setResults(DataGridView view, String query)
        {
            DataTable table = new DataTable();
            if (this.conn != null)
            {

                switch (dbType)
                {
                    case "MySQL":
                        MySqlDataAdapter dataAdapterMySQL = new MySqlDataAdapter();
                        dataAdapterMySQL.SelectCommand = new MySqlCommand(query, (MySqlConnection)conn);
                        dataAdapterMySQL.Fill(table);
                        break;

                    case "MSSQL":
                        SqlDataAdapter dataAdapterMSSQL = new SqlDataAdapter();
                        dataAdapterMSSQL.SelectCommand = new SqlCommand(query, (SqlConnection)conn);
                        dataAdapterMSSQL.Fill(table);
                        break;

                }


                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                view.DataSource = bSource;
            }
            else
            {
                MessageBox.Show("Connection with DB is not yet established");
            }

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
