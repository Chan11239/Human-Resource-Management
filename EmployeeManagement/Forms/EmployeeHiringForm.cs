using System;
using EmployeeManagement.Services;
using EmployeeManagement.Model;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class EmployeeHiringForm : Form
    {
        AutoNumberServices autoNumberService = new AutoNumberServices();
        EmployeeDetailsService employeeDetailService = new EmployeeDetailsService();
        ControllerServices controller = new ControllerServices();
        public string connectionString = @"Data Source=DESKTOP-FU9BPC1;Initial Catalog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=true;";
        public EmployeeHiringForm()
        {
            InitializeComponent();
        }
        
        private void EmployeeHiringForm_Load(object sender, EventArgs e)
        {
            cboType.Text = "- Select Type -";
            cboClassification.Text = "- Select Classification -";
            cboStatus.Text = "- Select Status -";
            populateDepartment();
        }
        private void populateDepartment()
        {
            cboDepartment.Text = "- Select Department -";
            string query = "SELECT departmentName " +
                           "FROM departmentList WHERE isActive = 1";
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
        private void populatePosition(string department)
        {
            cboPosition.Text = "- Select Position -";
            string query = "SELECT * " +
                           "FROM positionList WHERE departmentName = '" + department + "' ";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        cboPosition.Items.Add(dataReader["positionName"].ToString());
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (employeeDetailService.isExists(txtEmployeeID.Text) == false)
            {
                EmployeeDetails employeeDetail = new EmployeeDetails()
                {
                    employeeNo = txtEmployeeID.Text,
                    firstName = txtFirstName.Text,
                    lastName = txtLastName.Text,
                    middleName = txtMiddleName.Text,
                    fullName = (txtLastName.Text + ", " + txtFirstName.Text + " " + txtMiddleName.Text).Trim(),
                    department = cboDepartment.SelectedItem.ToString(),
                    employmentType = cboType.SelectedItem.ToString(),
                    position = cboPosition.SelectedItem.ToString(),
                    rankEmployee = txtRank.Text,
                    salaryRate = double.Parse(txtSalaryRate.Text),
                    dateAppointment = DateTime.Parse(txtDateofAppointment.Text),
                    statusOfEmployement = cboStatus.SelectedItem.ToString(),
                    classification = cboClassification.SelectedItem.ToString(),
                    point = int.Parse(txtPoints.Text)
                };
                bool isSave = employeeDetailService.save(employeeDetail);
                if (isSave)
                {
                    autoNumberService.updateNewEmployeeNo(txtEmployeeID.Text);
                    //userService.createEmployeeUser(lblEmployeeNo.Text, lblPassword.Text, txtFirstName.Text, txtLastName.Text);
                }
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string firstLetter = cboType.SelectedItem.ToString();
            txtEmployeeID.Text = autoNumberService.getEmployeeNo(firstLetter.Substring(0, 1));
            txtPassword.Text = autoNumberService.generatePassword(true, 8);
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            populatePosition(cboDepartment.SelectedItem.ToString());
        }
        private void getRank(int point)
        {
            string query = "SELECT rankName, salaryRate FROM rankList WHERE '" + point + "' " +
                           "BETWEEN startPoint AND endPoint " +
                           "AND type = '" + cboType.SelectedItem.ToString() + "' ";
            DataRow drRank = controller.getByDataRow(query);
            if (drRank != null)
            {

                txtSalaryRate.Text = Convert.ToDouble(drRank["salaryRate"]).ToString();
                txtRank.Text = drRank["rankName"].ToString();
            }
        }

        private void txtPoints_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getRank(int.Parse(txtPoints.Text));
            }
        }
    }
}
