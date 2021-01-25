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
        private DbTypes type;
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
            if (type == null)
            {
                throw new Exception("Missing database type");
            }

            if (type ==DbTypes.MySQL) {
                return buildMySQLConnection();
            }

            if (type == DbTypes.MSSQL)
            {
                return buildMSSQLConnection();
            }


            return null;
        }

        private DbConnection buildMySQLConnection() {

            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();

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
                //  connetionString = @"Data Source="+ host.Text+"; Initial Catalog="+ name.Text+"; User ID="+ username.Text+"; Password="+ password.Text+"\"";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
             
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }





            return cnn;  
        }

    }


    enum DbTypes { 
    
        MySQL, MSSQL
    }

  /*  class DBConnection
    {
        
        public DbConnection conn;
        
        //Constructor
        public DBConnection(string server, string database, string uid, string password)
        {
            Initialize(server, database, uid, password);
        }

   


        //Initialize values
        private void Initialize(string server, string database, string uid, string password)
        {
            DbConnection dbcon = new DatabaseConnectionBuilder()
                .withType(DbTypes.MySQL)
                .setHost("asda")
                .build();

            string connectionString;
          
            connectionString = "server="+ server +"; database="+ database +" ;userid=" + uid+ " ;password=" + password;
            try
            {

                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();

                MessageBox.Show("Connection Open  !");
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }*/

       
    }

