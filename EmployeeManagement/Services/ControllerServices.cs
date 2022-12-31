using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EmployeeManagement.Services
{
    class ControllerServices : AbstractServices
    {
        public DataTable getByDataTable(string query)
        {
            DataTable result = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        result = new DataTable();
                        result.Load(dataReader);
                    }
                    connection.Close();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Service error: " + ex.Message);
                return null;
            }
        }
        public DataRow getByDataRow(string query)
        {
            DataRow result = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dataReader);
                        foreach (DataRow dataRow in dataTable.Rows)
                        {
                            result = dataRow;
                        }
                    }
                    connection.Close();
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Service Error: " + ex.Message);
                return null;
            }
        }
       public bool populateByGridViewByQuery(DataGridView gridViewObjectName, string sqlStatement)
        {
            try
            {
                bool result = false;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = sqlStatement;

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                        gridViewObjectName.DataSource = dt;
                    }
                    connection.Close();
                    result = true;
                }
                return result;
            }
            catch(Exception ex)
            {
                return this.handlingErrorResult(gridViewObjectName, ex);
            }
        }

        public bool popukateByGridViewByQueryWithColumn(DataGridView gridViewObjectName, string sqlStatement)
        {
            bool result =  false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = sqlStatement;

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    gridViewObjectName.AutoGenerateColumns = false;
                    gridViewObjectName.DataSource = dataTable;
                    connection.Close();
                    result = true;
                }
                return result;
            } 
            catch (Exception ex)
            {
                return this.handlingErrorResult(gridViewObjectName, ex);
            }
        }
        private bool handlingErrorResult(DataGridView gridView, Exception ex)
        {
            Console.Error.WriteLine("Service Error: " + ex.Message);
            gridView.DataSource = null;
            return false;
        }
    }
}
