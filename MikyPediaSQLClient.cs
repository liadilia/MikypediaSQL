using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
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
        
        public MikyPediaSQLClient(DbConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.DBUrl.Text = conn.DataSource;
            this.DBName.Text = conn.Database;
            
           
           tables.Columns.Add("table","Table");
            DataTable schema = conn.GetSchema("Tables");
            foreach (DataRow row in schema.Rows)
            {

                tables.Rows.Add( row[2].ToString());
            }


            //
            // switch (dbType)
            // {
            //     case "MySQL":  query = "show tables";
            //         break;
            //     case "MSSQL": query = "SELECT * FROM " + conn.Database+".INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            //         break;
            // }
            //
            //
            // setResults(tables, query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String query = Query.Text;

            setResults(resultGrid, query);
        }

        private void button2_Click(object sender, EventArgs e)

        {

            this.conn.Close();
            this.Hide();
            DBConnectForm connectionForm = new DBConnectForm();
            connectionForm.Show();

        }

        private DataTable table;
        private DbDataAdapter adapter;
        private void setResults(DataGridView view, string query)
        {

            query = query.Trim();
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            logText.AppendText("> " + query);
            logText.AppendText(Environment.NewLine);
            try
            {

                int affectedRows = 0;
                if (query.ToLower().StartsWith("select"))
                {
                    // https://stackoverflow.com/questions/3488962/how-to-create-a-dbdataadapter-given-a-dbcommand-or-dbconnection
                     adapter = DbProviderFactories.GetFactory(conn).CreateDataAdapter();
      
                    adapter.SelectCommand = cmd; 
                    table = new DataTable();
                    adapter.Fill(table);

                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = table;
                    resultGrid.DataSource = bSource;
                    affectedRows = table.Rows.Count;

                }
                else
                {
                    affectedRows = cmd.ExecuteNonQuery();
                }
                
                logText.AppendText("  affected rows " + affectedRows);
                logText.AppendText(Environment.NewLine);

            }
            catch (Exception exception)
            {
                MessageBox.Show("Query invalid " + exception);
            }
            
        }

        /*private void _setResults(DataGridView view, String query)
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

        }*/

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

      
    

        private void MikyPediaSQLClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private string editedValue;

        private void tables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            setResults(resultGrid, "SELECT * FROM " + ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value); 
            
        }
    }
}
