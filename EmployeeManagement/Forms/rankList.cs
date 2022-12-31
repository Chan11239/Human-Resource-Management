using EmployeeManagement.Services;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement.Forms
{
    public partial class rankList : Form
    {
        public string connectionString = @"Data Source=DESKTOP-FU9BPC1;Initial Catalog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=true;";
        ControllerServices controller = new ControllerServices();
        string selectedId = "";
        public rankList()
        {
            InitializeComponent();
        }
        private void populateDepartmentList()
        {
            string query = "SELECT id,  classificationName, startPoint, endPoint, type, rankName, salaryRate " +
                           "FROM rankList";
            controller.popukateByGridViewByQueryWithColumn(dgRankList, query);
        }

        private void rankList_Load(object sender, EventArgs e)
        {
            populateDepartmentList();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            string salaryperhour = txtSalaryRate.Text;
            double convertToDouble = double.Parse(salaryperhour);
            double salaryperMonth = convertToDouble * 160;
            if (selectedId != "")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE rankMaintenance " +
                                       "SET " +
                                       "startPoint=@startPoint, endPoint=@endPoint, rankName=@rankName, salaryRate=@salaryRate " +
                                       "WHERE id=@id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@classification", txtClassification.Text);
                        command.Parameters.AddWithValue("@startPoint", txtStartPoint.Text);
                        command.Parameters.AddWithValue("@endPoint", txtEndPoint.Text);
                        command.Parameters.AddWithValue("@rankName", txtRankName.Text);
                        command.Parameters.AddWithValue("@salaryRate", txtSalaryRate.Text);

                        command.ExecuteNonQuery();
                        connection.Close();
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
                        if (cboType.SelectedItem.ToString() == "Full Time")
                        {
                            connection.Open();
                            string query = "INSERT INTO rankList " +
                                           "(classificationName, startPoint, endPoint, type, rankName, salaryRate) " +
                                           "VALUES " +
                                           "(@classification, @startPoints, @endPoint, @type, @rankName, @salaryRate) ";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@classification", txtClassification.Text);
                            command.Parameters.AddWithValue("@startPoints", txtStartPoint.Text);
                            command.Parameters.AddWithValue("@endPoint", txtEndPoint.Text);
                            command.Parameters.AddWithValue("@type", cboType.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@rankName", txtRankName.Text);
                            command.Parameters.AddWithValue("@salaryRate", salaryperMonth);

                            command.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("Rank Added!");
                        }
                        else
                        {
                            connection.Open();
                            string query = "INSERT INTO rankList " +
                                           "(classificationName, startPoint, endPoint, type, rankName, salaryRate) " +
                                           "VALUES " +
                                           "(@classification, @startPoints, @endPoint, @type, @rankName, @salaryRate) ";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@classification", txtClassification.Text);
                            command.Parameters.AddWithValue("@startPoints", txtStartPoint.Text);
                            command.Parameters.AddWithValue("@endPoint", txtEndPoint.Text);
                            command.Parameters.AddWithValue("@type", cboType.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@rankName", txtRankName.Text);
                            command.Parameters.AddWithValue("@salaryRate", txtSalaryRate.Text);

                            command.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("Rank Added!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void dgRankList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgRankList.SelectedRows.Count >= 0)
            {
                selectedId = dgRankList.SelectedRows[0].Cells[0].Value.ToString();
                string classification = dgRankList.SelectedRows[0].Cells[1].Value.ToString();
                string startPoint = dgRankList.SelectedRows[0].Cells[2].Value.ToString();
                string endPoint = dgRankList.SelectedRows[0].Cells[3].Value.ToString();
                string type = dgRankList.SelectedRows[0].Cells[4].Value.ToString();
                string rankName = dgRankList.SelectedRows[0].Cells[5].Value.ToString();
                string salaryRate = dgRankList.SelectedRows[0].Cells[6].Value.ToString();

                txtClassification.Text = classification;
                txtStartPoint.Text = startPoint;
                txtEndPoint.Text = endPoint;
                cboType.SelectedItem = type;
                txtRankName.Text = rankName;
                txtSalaryRate.Text = salaryRate;
            }
        }
    }
}
