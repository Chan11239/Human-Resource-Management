using EmployeeManagement.Services;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement.Forms
{
    public partial class leaveList : Form
    {
        ControllerServices controller = new ControllerServices();
        public string connectionString = @"Data Source=DESKTOP-FU9BPC1;Initial Catalog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=true;";
        string selectedId = "";
        public leaveList()
        {
            InitializeComponent();
        }

        private void leaveList_Load(object sender, EventArgs e)
        {
            populateLeave();
        }
        private void populateLeave()
        {
            string query = "SELECT id, code, name, description, allotedDays " +
                           "FROM leaveList " +
                           "WHERE isActive = 1";
            controller.popukateByGridViewByQueryWithColumn(dgLeaveList, query);
        }

        private void bntAddEdit_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Code is Required!");
                return;
            }
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Name is Required!");
                return;
            }
            if (txtAllotedDays.Text.Trim() == string.Empty || txtAllotedDays.Text == "0") 
            {
                MessageBox.Show("Maximum allotted days is Required!");
                return;
            }

            if(selectedId != "")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE departmentList " +
                                       "SET " +
                                       "code=@code, name=@name, description=@description, allotedDays=@allotedDays " +
                                       "WHERE id = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@code", txtCode.Text);
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@description", txtDescription.Text);
                        command.Parameters.AddWithValue("@allotedDays", txtAllotedDays.Text);
                        command.Parameters.AddWithValue("@id", selectedId);

                        command.ExecuteNonQuery();
                        connection.Close();
                        //clearFields();
                        MessageBox.Show("Leave List Updated!");
                        populateLeave();
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
                        string query = "INSERT INTO leaveList " +
                                       "(code, name, description, allotedDays, isActive) " +
                                       "VALUES " +
                                       "(@code, @name, @description, @allotedDays, @isActive) ";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@code", txtCode.Text);
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@description", txtDescription.Text);
                        command.Parameters.AddWithValue("@allotedDays", txtAllotedDays.Text);
                        command.Parameters.AddWithValue("@isActive", 1);

                        command.ExecuteNonQuery();
                        connection.Close();
                        //clearFields();
                        MessageBox.Show("Leave Added!");
                        populateLeave();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void dgLeaveList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = dgLeaveList.SelectedRows[0].Cells[0].Value.ToString();
                string code = dgLeaveList.SelectedRows[0].Cells[1].Value.ToString();
                string department = dgLeaveList.SelectedRows[0].Cells[2].Value.ToString();
                string description = dgLeaveList.SelectedRows[0].Cells[3].Value.ToString();
                string allotedDays = dgLeaveList.SelectedRows[0].Cells[4].Value.ToString();

                txtCode.Text = code;
                txtName.Text = department;
                txtDescription.Text = description;
                txtAllotedDays.Text = allotedDays;
            }
        }
    }
}
