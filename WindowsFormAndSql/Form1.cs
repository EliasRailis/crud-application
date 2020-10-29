using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormAndSql
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// This is the main form class in which i will be 
        /// creating all the methods for the button events
        /// </summary>

        // The ConfigurationManager class provides access to configuration files for client applications.
        static string myCon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        static SqlConnection con = new SqlConnection(myCon);

        #region Main form 
        public MainForm()
        {
            InitializeComponent();
            DisplayData(); // Calling the DisplayData method
        } 
        #endregion

        #region Create button
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating a new student object
                Student student = new Student
                {
                    StudentID = int.Parse(txtStudentId.Text),
                    Firstname = txtFirstname.Text,
                    Lastname = txtLastname.Text,
                    MI = txtMiddleInitial.Text,
                    Gender = txtGender.Text,
                    Address = txtAddress.Text,
                    Birthday = DateTime.Parse(txtBirthday.Text)
                };
                DataAccessLayer.CreateRecord(student); // Calling the CreateRecord method
                ClearData(); // Calling the ClearData method
                DisplayData(); // Calling the DisplayData method
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearData(); // Calling the ClearData method
            }
        }
        #endregion

        #region Read button
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                // Calling the ReadRecord method
                DataAccessLayer.ReadRecord(this.dataGridViewStudentRecords, this.txtEnterStudentId);
                ClearData(); // Calling the ClearData method
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearData(); // Calling the ClearData method
            }
        }
        #endregion

        #region Update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Updating the setudent object
                Student student = new Student
                {
                    StudentID = int.Parse(txtEnterStudentId.Text),
                    Firstname = txtFirstname.Text,
                    Lastname = txtLastname.Text,
                    MI = txtMiddleInitial.Text,
                    Gender = txtGender.Text,
                    Address = txtAddress.Text,
                    Birthday = DateTime.Parse(txtBirthday.Text)
                };
                DataAccessLayer.UpdateRecord(student); // Calling the UpdateRecord method
                ClearData(); // Calling the ClearData method
                DisplayData(); // Calling the DisplayData method
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearData(); // Calling the ClearData method
            }
        }
        #endregion

        #region Delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Deleting the student object
                Student student = new Student
                {
                    StudentID = int.Parse(txtEnterStudentId.Text),
                };
                DataAccessLayer.DeleteRecord(student); // Calling the DeleteRecord method
                ClearData(); // Calling the ClearData method
                DisplayData(); // Calling the DisplayData method
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearData(); // Calling the ClearData method
            }
        }
        #endregion

        #region Search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // SqlConnection class represents a connection to a SQL Server database.
            using (SqlConnection con = new SqlConnection(myCon))
            {
                con.Open(); // Opening the connection

                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    // SqlCommand to represents a Transact-SQL statement.
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM Student", con);
                    var dataset = new DataSet(); // Represents an in-memory cache of data.
                    adapter.Fill(dataset);
                    var dt = dataset.Tables[0];
                    var dv = dt.DefaultView;

                    if (!string.IsNullOrEmpty(txtFirstname.Text.Trim()))
                    {
                        dv.RowFilter = string.Concat("[Firstname] LIKE '%", txtFirstname.Text.Trim(), "%'");
                        dataGridViewStudentRecords.DataSource = dv;
                    }
                    else if (!string.IsNullOrEmpty(txtLastname.Text.Trim()))
                    {
                        dv.RowFilter = string.Concat("[Lastname] LIKE '%", txtLastname.Text.Trim(), "%'");
                        dataGridViewStudentRecords.DataSource = dv;
                    }
                    else if (!string.IsNullOrEmpty(txtMiddleInitial.Text.Trim()))
                    {
                        dv.RowFilter = string.Concat("[MI] LIKE '%", txtMiddleInitial.Text.Trim(), "%'");
                        dataGridViewStudentRecords.DataSource = dv;
                    }
                    else if (!string.IsNullOrEmpty(txtGender.Text.Trim()))
                    {
                        dv.RowFilter = string.Concat("[Gender] LIKE '%", txtGender.Text.Trim(), "%'");
                        dataGridViewStudentRecords.DataSource = dv;
                    }
                    else if (!string.IsNullOrEmpty(txtAddress.Text.Trim()))
                    {
                        dv.RowFilter = string.Concat("[Address] LIKE '%", txtAddress.Text.Trim(), "%'");
                        dataGridViewStudentRecords.DataSource = dv;
                    }
                    else
                    {
                        string date = txtBirthday.Text.Trim();
                        dv.RowFilter = string.Concat("Convert(Birthday,'System.String') LIKE '%", date, "%'");
                        dataGridViewStudentRecords.DataSource = dv;
                    }
                }
            }
        }
        #endregion

        #region Displaying and clearing of data 
        public void DisplayData()
        {
            // Displaying the data from the database
            SqlDataAdapter adapt;
            con.Open();
            DataTable dataTable = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Student", con);
            adapt.Fill(dataTable);
            dataGridViewStudentRecords.DataSource = dataTable;
            con.Close();
        }

        public void ClearData()
        {
            // Clearing the text from the text boxes
            txtStudentId.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtMiddleInitial.Text = "";
            txtGender.Text = "";
            txtAddress.Text = "";
            txtBirthday.Text = "";
            txtEnterStudentId.Text = "";
        }
        #endregion
    }
}
