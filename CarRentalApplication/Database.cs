using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm
{
    public class Database
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public SqlDataAdapter myDataAdapter;
        
        public Database()
        {
            String connectionString = "Server = DESKTOP-PL0JUL4; Database = 291_FinalProject; Trusted_Connection = yes;";
            this.myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                this.myConnection.Open(); // Open connection
                this.myCommand = new SqlCommand();
                this.myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }
        //
        public void insert(String insert_statement)
        {
            this.myCommand.CommandText = insert_statement;
            this.myCommand.ExecuteNonQuery();
        }
        //
        public void query(String query_string)
        {
            this.myCommand.CommandText = query_string;
            this.myReader = this.myCommand.ExecuteReader();
        }

        public void query_2(String query_string)
        {
            this.myCommand.CommandText = query_string;
            this.myDataAdapter = new SqlDataAdapter(myCommand);

        }

    }
}
