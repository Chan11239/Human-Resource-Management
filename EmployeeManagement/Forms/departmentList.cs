using EmployeeManagement.Services;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class departmentList : Form
    {
        ControllerServices controller = new ControllerServices();
        public string connectionString = @"Data Source=DESKTOP-FU9BPC1;Initial Catalog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=true;";
        string selectedId = "";
        public departmentList()
        {
            InitializeComponent();
        }
        
        private void DepartmentMaintenance_Load(object sender, EventArgs e)
        {
            cboClassification.Text = "---";
            populateDepartmentList();
        }
        private void populateDepartmentList()
        {
            string query = "SELECT id, departmentName, classificationName " +
                           "FROM departmentList ORDER BY lastModifiedDate ASC";
            controller.popukateByGridViewByQueryWithColumn(dgDepartmentList, query);
        }

        private void bntAddEdit_Click(object sender, EventArgs e)
        {
            if (selectedId != "")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE departmentList " +
                                       "SET " +
                                       "departmentName=@department, classificationName=@classification where id = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@department", txtDepartment.Text);
                        command.Parameters.AddWithValue("@classification", cboClassification.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@id", selectedId);

                        command.ExecuteNonQuery();
                        connection.Close();
                        clearFields();
                        MessageBox.Show("Department Updated!");
                        populateDepartmentList();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO departmentList " +
                                       "(departmentName, classificationName, isActive) " +
                                       "VALUES " +
                                       "(@department, @classification, @isActive) ";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@department", txtDepartment.Text);
                        command.Parameters.AddWithValue("@classification", cboClassification.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@isActive", 1);

                        command.ExecuteNonQuery();
                        connection.Close();
                        clearFields();
                        MessageBox.Show("Department Added!");
                        populateDepartmentList();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }

        private void dgDepartmentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                selectedId = dgDepartmentList.SelectedRows[0].Cells[0].Value.ToString();
                string department = dgDepartmentList.SelectedRows[0].Cells[1].Value.ToString();
                string classification = dgDepartmentList.SelectedRows[0].Cells[2].Value.ToString();

                txtDepartment.Text = department;
                cboClassification.SelectedItem = classification;
            }
        }
        private void clearFields()
        {
            txtDepartment.Text = "";
            cboClassification.Text = "---";
        }
    }
}
