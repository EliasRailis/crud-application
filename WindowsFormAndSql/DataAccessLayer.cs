using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormAndSql
{
    class DataAccessLayer
    {
        /// <summary>
        /// In class DataAccessLayer i will be creating all
        /// the CRUD methods that are needed
        /// </summary>

        // The ConfigurationManager class provides access to configuration files for client applications.
        // SqlConnection class represents a connection to a SQL Server database.
        static string myCon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        static SqlConnection con = new SqlConnection(myCon);

        #region Create store procedure
        // The Create procedure performs the INSERT statement which will create a new record.
        public static void CreateRecord(Student obj)
        {
            try 
            {
                // SqlCommand to represents a Transact-SQL statement.
                using (SqlCommand cmd = new SqlCommand("usp_CreateStudentRecord", con))
                {
                    con.Open(); // Opening the connection to the database
                    // CommandType specifies how a command string is interpreted.
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", obj.StudentID);
                    cmd.Parameters.AddWithValue("@Firstname", obj.Firstname);
                    cmd.Parameters.AddWithValue("@Lastname", obj.Lastname);
                    cmd.Parameters.AddWithValue("@MI", obj.MI);
                    cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                    cmd.Parameters.AddWithValue("@Address", obj.Address);
                    cmd.Parameters.AddWithValue("@Birthday", obj.Birthday);
                    cmd.ExecuteNonQuery(); //Executes a Transact-SQL statement against the connection
                }
            }
            finally
            {
                con.Close(); // Closing the connection
            }
        }
        #endregion

        #region Read store procedure
        // The Read procedure reads the table records based on the primary key 
        // specified in the input parameter
        public static void ReadRecord(DataGridView grid, TextBox txtInput)
        {
            int StudentID = int.Parse(txtInput.Text);
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_ReadStudentRecords", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    con.Open(); // Opening the connection to the database
                    DataTable dataTable = new DataTable(); // Represents one table of in-memory data.
                    // SqlDataAdapter represents a set of data commands and a database connection 
                    // that are used to fill the DataSet and update a SQL Server database.
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                    grid.DataSource = dataTable;
                }
            }
            finally
            {
                con.Close(); // Closing the connection
            }
        }
        #endregion

        #region Update store procedure
        // The Update procedure performs an UPDATE statement on the table based on 
        // the primary key for a record specified in the WHERE clause of the statement.
        public static void UpdateRecord(Student obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_UpdateStudentRecords", con))
                {
                    con.Open(); // Opening the connection to the database
                    // CommandType specifies how a command string is interpreted.
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", obj.StudentID);
                    cmd.Parameters.AddWithValue("@Firstname", obj.Firstname);
                    cmd.Parameters.AddWithValue("@Lastname", obj.Lastname);
                    cmd.Parameters.AddWithValue("@MI", obj.MI);
                    cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                    cmd.Parameters.AddWithValue("@Address", obj.Address);
                    cmd.Parameters.AddWithValue("@Birthday", obj.Birthday);
                    cmd.ExecuteNonQuery(); //Executes a Transact-SQL statement against the connection
                }
            }
            finally
            {
                con.Close(); // Closing the connection
            } 
        }
        #endregion

        #region Delete store procedure
        // The Delete procedure deletes a row specified in the WHERE clause
        public static void DeleteRecord(Student obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_DeleteStudentRecord", con))
                {
                    con.Open(); // Opening the connection to the database
                    // CommandType specifies how a command string is interpreted.
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", obj.StudentID);
                    cmd.ExecuteNonQuery(); //Executes a Transact-SQL statement against the connection
                }
            }
            finally
            {
                con.Close(); // Closing the connection
            }
        }
        #endregion
    }
}
