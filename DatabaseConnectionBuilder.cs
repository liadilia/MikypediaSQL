using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.Common;
using System.Data.SqlClient;

namespace Mikypedia
{


    class DatabaseConnectionBuilder {
        private DbTypes type = DbTypes.Undefined;
        private string host = "localhost";
        private string username = "root";
        private string password= "";
        private string dbName;
        public DatabaseConnectionBuilder withType(DbTypes type)
        {
            this.type = type;
            return this;
        }


        public DatabaseConnectionBuilder setHost(string hostname)
        {

            this.host = hostname;
            return this;
        }

        public DatabaseConnectionBuilder setUsername(string username)
        {

            this.username = username;
            return this;
        }

        public DatabaseConnectionBuilder setPassword(string password)
        {

            this.password = password;
            return this;
        }

        public DatabaseConnectionBuilder setdbName(string dbName)
        {

            this.dbName = dbName;
            return this;
        }

        public DbConnection build()
        {
            if (type == DbTypes.Undefined)
            {
                throw new Exception("Missing database type");
            }

            if (type == DbTypes.MySQL) {
                return buildMySQLConnection();
            } else if (type == DbTypes.MSSQL) {
                return buildMSSQLConnection();
            } else      {
                throw new Exception("Unsupported database type " + type);
            }
        }

        private DbConnection buildMySQLConnection() {

            MySqlConnection conn = new MySqlConnection();
            
            if (host == null)
            {
                throw new Exception("missing hostname");
            }
            try
            {
              string  connectionString = "server=" + this.host + "; database=" + this.dbName + " ;userid=" + this.username + " ;password=" + this.password;
                conn.ConnectionString = connectionString;
                conn.Open();            
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conn;
        }

        private DbConnection buildMSSQLConnection()
        {
            SqlConnection cnn = null;
            if (host == null)
            {
                throw new Exception("missing hostname");
            }
            try
            {
                string connectionString;                
                connectionString = @"Data Source=" + this.host + "; Initial Catalog=" + this.dbName + "; Integrated Security = True";          
                cnn = new SqlConnection(connectionString);
                cnn.Open();            
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return cnn;  
        }

    }


    enum DbTypes { 
    
        Undefined = -1, MySQL = 1, MSSQL = 2
    }

       
    }

