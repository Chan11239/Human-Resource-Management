using EmployeeManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.pnlMainPanel.Controls.Count > 0)
                this.pnlMainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlMainPanel.Controls.Add(f);
            this.pnlMainPanel.Tag = f;
            f.Show();
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            loadForm(new Dashboard());
            hideSubEmployee();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
        private void hideSubEmployee()
        {
            if (pnlSubMenuEmployee.Visible == true)
            {
                pnlSubMenuEmployee.Visible = false;
            }
        }
        private void showsubEmployee(Panel sub)
        {
            if (sub.Visible == false)
            {
                hideSubLeave();
                pnlSubMenuEmployee.Visible = true;
            }
            else
            {
                pnlSubMenuEmployee.Visible = false;
            }
        }
        private void hideSubLeave()
        {
            if (pnlSubMenuLeave.Visible == true)
            {
                pnlSubMenuLeave.Visible = false;
            }
        }
        private void showSubLeave(Panel sub)
        {
            if (sub.Visible == false)
            {
                hideSubLeave();
                pnlSubMenuLeave.Visible = true;
            }
            else
            {
                pnlSubMenuLeave.Visible = false;
            }
        }

        private void hideSubMaintenance()
        {
            if (pnlSubMenuMaintenance.Visible == true)
            {
                pnlSubMenuMaintenance.Visible = false;
            }
        }
        private void showSubMaintenance(Panel sub)
        {
            if (sub.Visible == false)
            {
                hideSubMaintenance();
                pnlSubMenuMaintenance.Visible = true;
            }
            else
            {
                pnlSubMenuMaintenance.Visible = false;
            }
        }

        private void btnEmployeeRecords_Click(object sender, EventArgs e)
        {
            showsubEmployee(pnlSubMenuEmployee);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadForm(new Dashboard());
            pnlSubMenuEmployee.Hide();
            pnlSubMenuLeave.Hide();
            pnlSubMenuMaintenance.Hide();
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            loadForm(new EmployeeList());
            hideSubEmployee();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            showSubLeave(pnlSubMenuLeave);
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            showSubMaintenance(pnlSubMenuMaintenance);
        }

        private void btnLeaveApprove_Click(object sender, EventArgs e)
        {
            loadForm(new LeaveApprove());
            hideSubLeave();
        }

        private void btnEmployeeCredits_Click(object sender, EventArgs e)
        {
            loadForm(new EmployeeCredits());
            hideSubLeave();
        }

        private void btnEmployeeMaintenance_Click(object sender, EventArgs e)
        {
            loadForm(new EmployeeHiringForm());
            hideSubMaintenance();
        }

        private void btnDepartmentMaintenance_Click(object sender, EventArgs e)
        {
            loadForm(new departmentList());
            hideSubMaintenance();
        }

        private void btnRankMaintenance_Click(object sender, EventArgs e)
        {
            loadForm(new rankList());
            hideSubMaintenance();
        }

        private void btnPositionMaintenance_Click(object sender, EventArgs e)
        {
            loadForm(new positionList());
            hideSubMaintenance();
        }

        private void btnLeaveMaintenance_Click(object sender, EventArgs e)
        {
            loadForm(new leaveList());
            hideSubMaintenance();
        }
    }
}
