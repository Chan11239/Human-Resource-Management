
namespace EmployeeManagement
{
    partial class EmployeeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgEmployeeRecords = new System.Windows.Forms.DataGridView();
            this.employeeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAppointment = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSalryRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClassification = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRequestLeave = new System.Windows.Forms.Button();
            this.dgLeaveApplications = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRequestLeaveForm = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dtPickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.dtPickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.cmboxLeave = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.reasons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeRecords)).BeginInit();
            this.pnlInformation.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLeaveApplications)).BeginInit();
            this.pnlRequestLeaveForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgEmployeeRecords
            // 
            this.dgEmployeeRecords.AllowUserToAddRows = false;
            this.dgEmployeeRecords.AllowUserToDeleteRows = false;
            this.dgEmployeeRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmployeeRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEmployeeRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployeeRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNo,
            this.fullName,
            this.department,
            this.position});
            this.dgEmployeeRecords.Location = new System.Drawing.Point(12, 88);
            this.dgEmployeeRecords.Name = "dgEmployeeRecords";
            this.dgEmployeeRecords.ReadOnly = true;
            this.dgEmployeeRecords.RowTemplate.Height = 25;
            this.dgEmployeeRecords.Size = new System.Drawing.Size(922, 405);
            this.dgEmployeeRecords.TabIndex = 0;
            this.dgEmployeeRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployeeRecords_CellClick);
            // 
            // employeeNo
            // 
            this.employeeNo.DataPropertyName = "employeeNo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.employeeNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.employeeNo.HeaderText = "Employee No";
            this.employeeNo.Name = "employeeNo";
            this.employeeNo.ReadOnly = true;
            this.employeeNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeNo.Width = 150;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullName.DefaultCellStyle = dataGridViewCellStyle3;
            this.fullName.HeaderText = "Full Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 350;
            // 
            // department
            // 
            this.department.DataPropertyName = "department";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.department.DefaultCellStyle = dataGridViewCellStyle4;
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Width = 200;
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position.DefaultCellStyle = dataGridViewCellStyle5;
            this.position.HeaderText = "Position";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Width = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Employee Records";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(602, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(670, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 26);
            this.txtSearch.TabIndex = 3;
            // 
            // pnlInformation
            // 
            this.pnlInformation.AutoScroll = true;
            this.pnlInformation.Controls.Add(this.pnlRequestLeaveForm);
            this.pnlInformation.Controls.Add(this.button1);
            this.pnlInformation.Controls.Add(this.txtEmployeeID);
            this.pnlInformation.Controls.Add(this.tabControl1);
            this.pnlInformation.Controls.Add(this.txtEmail);
            this.pnlInformation.Controls.Add(this.txtContactNo);
            this.pnlInformation.Controls.Add(this.txtFullName);
            this.pnlInformation.Controls.Add(this.label7);
            this.pnlInformation.Controls.Add(this.label6);
            this.pnlInformation.Controls.Add(this.label5);
            this.pnlInformation.Controls.Add(this.label3);
            this.pnlInformation.Controls.Add(this.label2);
            this.pnlInformation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlInformation.Location = new System.Drawing.Point(9, 8);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(934, 620);
            this.pnlInformation.TabIndex = 4;
            this.pnlInformation.Visible = false;
            this.pnlInformation.VisibleChanged += new System.EventHandler(this.pnlInformation_VisibleChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(838, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeID.Location = new System.Drawing.Point(163, 55);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(349, 26);
            this.txtEmployeeID.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 217);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 388);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.txtType);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtAppointment);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtStatus);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtPoints);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtSalryRate);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtClassification);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtRank);
            this.tabPage1.Controls.Add(this.txtDepartment);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtPosition);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(903, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Work";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.SystemColors.Control;
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtType.Enabled = false;
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtType.Location = new System.Drawing.Point(747, 35);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(144, 24);
            this.txtType.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(697, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 18);
            this.label16.TabIndex = 23;
            this.label16.Text = "Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(358, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 36);
            this.label15.TabIndex = 22;
            this.label15.Text = "Date of \r\nAppointment:";
            // 
            // txtAppointment
            // 
            this.txtAppointment.BackColor = System.Drawing.SystemColors.Control;
            this.txtAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppointment.Enabled = false;
            this.txtAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAppointment.Location = new System.Drawing.Point(468, 204);
            this.txtAppointment.Name = "txtAppointment";
            this.txtAppointment.Size = new System.Drawing.Size(204, 24);
            this.txtAppointment.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(5, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 54);
            this.label14.TabIndex = 20;
            this.label14.Text = "Status and \r\nTenure of \r\nEmployement";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.Location = new System.Drawing.Point(110, 206);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(204, 24);
            this.txtStatus.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(358, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Points:";
            // 
            // txtPoints
            // 
            this.txtPoints.BackColor = System.Drawing.SystemColors.Control;
            this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPoints.Enabled = false;
            this.txtPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPoints.Location = new System.Drawing.Point(468, 145);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(204, 24);
            this.txtPoints.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(16, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "Salary Rate:";
            // 
            // txtSalryRate
            // 
            this.txtSalryRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtSalryRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalryRate.Enabled = false;
            this.txtSalryRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalryRate.Location = new System.Drawing.Point(110, 147);
            this.txtSalryRate.Name = "txtSalryRate";
            this.txtSalryRate.Size = new System.Drawing.Size(204, 24);
            this.txtSalryRate.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(358, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Classification: ";
            // 
            // txtClassification
            // 
            this.txtClassification.BackColor = System.Drawing.SystemColors.Control;
            this.txtClassification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassification.Enabled = false;
            this.txtClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClassification.Location = new System.Drawing.Point(468, 88);
            this.txtClassification.Name = "txtClassification";
            this.txtClassification.Size = new System.Drawing.Size(204, 24);
            this.txtClassification.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(16, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Rank:";
            // 
            // txtRank
            // 
            this.txtRank.BackColor = System.Drawing.SystemColors.Control;
            this.txtRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRank.Enabled = false;
            this.txtRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRank.Location = new System.Drawing.Point(110, 90);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(204, 24);
            this.txtRank.TabIndex = 11;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.SystemColors.Control;
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Enabled = false;
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDepartment.Location = new System.Drawing.Point(468, 32);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(204, 24);
            this.txtDepartment.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(358, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(16, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Position:";
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.SystemColors.Control;
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosition.Enabled = false;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPosition.Location = new System.Drawing.Point(110, 35);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(204, 24);
            this.txtPosition.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(903, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRequestLeave);
            this.tabPage3.Controls.Add(this.dgLeaveApplications);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(903, 355);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Leave";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRequestLeave
            // 
            this.btnRequestLeave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRequestLeave.FlatAppearance.BorderSize = 0;
            this.btnRequestLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestLeave.ForeColor = System.Drawing.Color.White;
            this.btnRequestLeave.Location = new System.Drawing.Point(759, 20);
            this.btnRequestLeave.Name = "btnRequestLeave";
            this.btnRequestLeave.Size = new System.Drawing.Size(118, 38);
            this.btnRequestLeave.TabIndex = 16;
            this.btnRequestLeave.Text = "Request Leave";
            this.btnRequestLeave.UseVisualStyleBackColor = false;
            this.btnRequestLeave.Click += new System.EventHandler(this.btnRequestLeave_Click);
            // 
            // dgLeaveApplications
            // 
            this.dgLeaveApplications.AllowUserToAddRows = false;
            this.dgLeaveApplications.AllowUserToDeleteRows = false;
            this.dgLeaveApplications.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgLeaveApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLeaveApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reasons,
            this.startDate,
            this.endDate,
            this.status});
            this.dgLeaveApplications.Location = new System.Drawing.Point(68, 75);
            this.dgLeaveApplications.Name = "dgLeaveApplications";
            this.dgLeaveApplications.ReadOnly = true;
            this.dgLeaveApplications.RowTemplate.Height = 25;
            this.dgLeaveApplications.Size = new System.Drawing.Size(744, 232);
            this.dgLeaveApplications.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(17, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "Leave Applications";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(163, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(349, 26);
            this.txtEmail.TabIndex = 12;
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNo.Enabled = false;
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContactNo.Location = new System.Drawing.Point(163, 127);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(349, 26);
            this.txtContactNo.TabIndex = 11;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Enabled = false;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFullName.Location = new System.Drawing.Point(163, 90);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(349, 26);
            this.txtFullName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(44, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contact No.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Information";
            // 
            // pnlRequestLeaveForm
            // 
            this.pnlRequestLeaveForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlRequestLeaveForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRequestLeaveForm.Controls.Add(this.btnSubmit);
            this.pnlRequestLeaveForm.Controls.Add(this.txtReason);
            this.pnlRequestLeaveForm.Controls.Add(this.label22);
            this.pnlRequestLeaveForm.Controls.Add(this.dtPickerEndDate);
            this.pnlRequestLeaveForm.Controls.Add(this.label21);
            this.pnlRequestLeaveForm.Controls.Add(this.dtPickerStartDate);
            this.pnlRequestLeaveForm.Controls.Add(this.label20);
            this.pnlRequestLeaveForm.Controls.Add(this.cmboxLeave);
            this.pnlRequestLeaveForm.Controls.Add(this.label19);
            this.pnlRequestLeaveForm.Controls.Add(this.label18);
            this.pnlRequestLeaveForm.ForeColor = System.Drawing.Color.White;
            this.pnlRequestLeaveForm.Location = new System.Drawing.Point(232, 102);
            this.pnlRequestLeaveForm.Name = "pnlRequestLeaveForm";
            this.pnlRequestLeaveForm.Size = new System.Drawing.Size(457, 410);
            this.pnlRequestLeaveForm.TabIndex = 16;
            this.pnlRequestLeaveForm.Visible = false;
            this.pnlRequestLeaveForm.VisibleChanged += new System.EventHandler(this.pnlRequestLeaveForm_VisibleChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(287, 337);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 38);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.White;
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReason.Location = new System.Drawing.Point(149, 242);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(256, 66);
            this.txtReason.TabIndex = 17;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(30, 270);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 20);
            this.label22.TabIndex = 23;
            this.label22.Text = "Reason";
            // 
            // dtPickerEndDate
            // 
            this.dtPickerEndDate.Location = new System.Drawing.Point(149, 178);
            this.dtPickerEndDate.Name = "dtPickerEndDate";
            this.dtPickerEndDate.Size = new System.Drawing.Size(256, 27);
            this.dtPickerEndDate.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(30, 183);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 20);
            this.label21.TabIndex = 21;
            this.label21.Text = "End Date";
            // 
            // dtPickerStartDate
            // 
            this.dtPickerStartDate.Location = new System.Drawing.Point(149, 123);
            this.dtPickerStartDate.Name = "dtPickerStartDate";
            this.dtPickerStartDate.Size = new System.Drawing.Size(256, 27);
            this.dtPickerStartDate.TabIndex = 20;
            this.dtPickerStartDate.Value = new System.DateTime(2022, 5, 25, 0, 0, 0, 0);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(30, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 20);
            this.label20.TabIndex = 19;
            this.label20.Text = "Type of Leave";
            // 
            // cmboxLeave
            // 
            this.cmboxLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmboxLeave.FormattingEnabled = true;
            this.cmboxLeave.Location = new System.Drawing.Point(149, 70);
            this.cmboxLeave.Name = "cmboxLeave";
            this.cmboxLeave.Size = new System.Drawing.Size(256, 28);
            this.cmboxLeave.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(122, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(204, 24);
            this.label19.TabIndex = 17;
            this.label19.Text = "Leave Request From";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(30, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 20);
            this.label18.TabIndex = 15;
            this.label18.Text = "Start Date";
            // 
            // reasons
            // 
            this.reasons.DataPropertyName = "reasons";
            this.reasons.HeaderText = "Reasons";
            this.reasons.Name = "reasons";
            this.reasons.ReadOnly = true;
            this.reasons.Width = 250;
            // 
            // startDate
            // 
            this.startDate.DataPropertyName = "startDate";
            this.startDate.HeaderText = "From";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 150;
            // 
            // endDate
            // 
            this.endDate.DataPropertyName = "endDate";
            this.endDate.HeaderText = "To";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 150;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 150;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 640);
            this.Controls.Add(this.pnlInformation);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgEmployeeRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeRecords)).EndInit();
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLeaveApplications)).EndInit();
            this.pnlRequestLeaveForm.ResumeLayout(false);
            this.pnlRequestLeaveForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployeeRecords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAppointment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSalryRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtClassification;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgLeaveApplications;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnlRequestLeaveForm;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtPickerEndDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtPickerStartDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmboxLeave;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnRequestLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasons;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}