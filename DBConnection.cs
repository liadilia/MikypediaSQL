using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.Common;

namespace Mikypedia
{


    class DatabaseConnectionBuilder {
        private string type;
        private string host = "localhost";
        private string username = "root";
        private string password= "";
        private string dbName;
        public DatabaseConnectionBuilder withType(DbTypes type)
        {

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

            if (type == "MySQL") {
                return buildMySQLConnection();
            }

            if (type == "MSSQL")
            {
                return buildMSSQLConnection();
            }


            return null;
        }

        private DbConnection buildMySQLConnection() {

            if (host == null)
            {
                throw new Exception("missing hostname");
            }

            try
            {
               
              /*  conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
*/
                MessageBox.Show("Connection Open  !");
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;//  
        }


        private DbConnection buildMSSQLConnection()
        {

            if (host == null)
            {
                throw new Exception("missing hostname");
            }

            return null;//  
        }

    }


    enum DbTypes { 
    
        MySQL, MSSQL, PostgreSQL
    }

    class DBConnection
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
    }

       
    }

