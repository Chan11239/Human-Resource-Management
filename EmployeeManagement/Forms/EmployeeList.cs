using EmployeeManagement.Forms;
using EmployeeManagement.Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class EmployeeList : Form
    {
        ControllerServices controller = new ControllerServices();
        public string connectionString = @"Data Source=DESKTOP-FU9BPC1;Initial Catalog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=true;";
        string selectedId = "";
        public EmployeeList()
        {
            InitializeComponent();
        }
        public void populateEmployee(string search)
        {
            string query = "SELECT employeeNo, fullName, department, position " +
                           "FROM details "+
                           "WHERE statusOfEmployement IN ('Probationary', 'Regular') ";

            if (search != string.Empty)
            {
                query += "AND (a.employeeNo LIKE '%" + search + "%' OR a.fullName LIKE '%" + search + "%' OR a.department LIKE '%" + search + "%' OR a.position LIKE '%" + search + "%') ";
            }

            controller.popukateByGridViewByQueryWithColumn(dgEmployeeRecords, query);
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            populateEmployee(string.Empty);
        }

        private void dgEmployeeRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgEmployeeRecords.SelectedRows.Count >= 0)
            {
                selectedId = dgEmployeeRecords.SelectedRows[0].Cells[0].Value.ToString();
                pnlInformation.Visible = true;
            }
        }

        private void pnlInformation_VisibleChanged(object sender, EventArgs e)
        {
            populateEmployeeInformation();
            populateLeaveApplications();
        }

        private void populateEmployeeInformation()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT employeeNo, fullName, department, position, classification, rankEmployee, points, salaryRate, " +
                                   "dateAppointment, statusOfEmployement " +
                                   "FROM details WHERE employeeNo='" + selectedId + "' ";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtEmployeeID.Text = reader["employeeNo"].ToString();
                        txtFullName.Text = reader["fullName"].ToString();
                        txtDepartment.Text = reader["department"].ToString();
                        txtPosition.Text = reader["position"].ToString();
                        txtClassification.Text = reader["classification"].ToString();
                        txtRank.Text = reader["rankEmployee"].ToString();
                        txtPoints.Text = reader["points"].ToString();
                        txtSalryRate.Text = reader["salaryRate"].ToString();
                        txtAppointment.Text = reader["dateAppointment"].ToString();
                        txtStatus.Text = reader["statusOfEmployement"].ToString();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlInformation.Visible = false;
        }
        
        private void populateLeaveApplications()
        {
            string query = "SELECT reasons, startDate, endDate, status " +
                           "FROM leaveApplications " +
                           "WHERE employeeNo = '" + txtEmployeeID.Text + "' ";
            controller.popukateByGridViewByQueryWithColumn(dgLeaveApplications, query);
        }

        private void btnRequestLeave_Click(object sender, EventArgs e)
        {
            pnlRequestLeaveForm.Visible = true;
        }

        private void pnlRequestLeaveForm_VisibleChanged(object sender, EventArgs e)
        {
            populateTypeOfLeaves();
            DateTime dt = DateTime.Now;
            dtPickerStartDate.Value = dt.AddDays(7);
            dtPickerEndDate.Value = dtPickerStartDate.Value.AddDays(2);

            
        }
        private void populateTypeOfLeaves()
        {
            string query = "SELECT name " +
                           "FROM leaveList " +
                           "WHERE isActive = 1";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        cmboxLeave.Items.Add(dataReader["name"].ToString());
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO leaveApplications " +
                                   "(employeeNo, employeeName, reasons, department, startDate, endDate, status, typeOfLeave) " +
                                   "VALUES " +
                                   "(@employeeNo, @employeeName, @reasons, @department, @startDate, @endDate, @status, @typeOfLeave)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@employeeNo", txtEmployeeID.Text);
                    command.Parameters.AddWithValue("@employeeName", txtFullName.Text);
                    command.Parameters.AddWithValue("@reasons", txtReason.Text);
                    command.Parameters.AddWithValue("@department", txtDepartment.Text);
                    command.Parameters.AddWithValue("@startDate", dtPickerStartDate.Value.ToString("yyyy-MMM-dd"));
                    command.Parameters.AddWithValue("@endDate", dtPickerEndDate.Value.ToString("yyyy-MMM-dd"));
                    command.Parameters.AddWithValue("@typeOfLeave", cmboxLeave.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@status", "PENDING");
                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Leave Application On Process!");
                    populateLeaveApplications();
                    this.Visible = false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
