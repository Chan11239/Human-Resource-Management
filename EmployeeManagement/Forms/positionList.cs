using EmployeeManagement.Services;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement.Forms
{
    public partial class positionList : Form
    {
        ControllerServices controller = new ControllerServices();
        public string connectionString = @"Data Source=DESKTOP-FU9BPC1;Initial Catalog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=true;";
        string selectedId = "";
        public positionList()
        {
            InitializeComponent();
        }

        private void positionList_Load(object sender, EventArgs e)
        {
            cboClassification.Text = "---";
            populatePositionList();
        }

        private void populatePositionList()
        {
            string query = "SELECT id, departmentName, classificationName, positionName " +
                           "FROM positionList";
            controller.popukateByGridViewByQueryWithColumn(dgPosition, query);
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
                        string query = "UPDATE positionList " +
                                       "SET " +
                                       "classificationName=@classificationName, departmentName=@departmentName, positionName=@positionName " +
                                       "where id = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@classificationName", cboClassification.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@departmentName", cboDepartment.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@positionName", txtPosition.Text);
                        command.Parameters.AddWithValue("@id", selectedId);

                        command.ExecuteNonQuery();
                        connection.Close();
                        populatePositionList();
                        MessageBox.Show("Position Updated!");
                        clearFields();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO positionList " +
                                       "(classificationName, departmentName, positionName, isActive) " +
                                       "VALUES " +
                                       "(@classificationName, @departmentName, @positionName, @isActive) ";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@classificationName", cboClassification.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@departmentName", cboDepartment.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@positionName", txtPosition.Text);
                        command.Parameters.AddWithValue("@isActive", 1);

                        command.ExecuteNonQuery();
                        connection.Close();
                        populatePositionList();
                        MessageBox.Show("Position Added!");
                        clearFields();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }

        private void dgPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgPosition.SelectedRows.Count >= 0)
            {
                selectedId = dgPosition.SelectedRows[0].Cells[0].Value.ToString();
                string department = dgPosition.SelectedRows[0].Cells[1].Value.ToString();
                string classification = dgPosition.SelectedRows[0].Cells[2].Value.ToString();
                string position = dgPosition.SelectedRows[0].Cells[3].Value.ToString();

                cboClassification.SelectedItem = classification;
                cboDepartment.SelectedItem = department;
                txtPosition.Text = position;
            }
        }
        private void populateDepartment(string classification)
        {
            cboDepartment.Text = "---";
            string query = "SELECT departmentName " +
                           "FROM departmentList WHERE classificationName = '" + classification + "'";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        cboDepartment.Items.Add(dataReader["departmentName"].ToString());
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearFields()
        {
            txtPosition.Text = "";
            cboDepartment.Text = "---";
            cboClassification.Text = "---";
        }

        private void cboClassification_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDepartment.Items.Clear();
            populateDepartment(cboClassification.SelectedItem.ToString());
        }
    }
}
