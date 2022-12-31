
namespace EmployeeManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAudit = new System.Windows.Forms.Button();
            this.pnlSubMenuMaintenance = new System.Windows.Forms.Panel();
            this.btnLeaveMaintenance = new System.Windows.Forms.Button();
            this.btnRankMaintenance = new System.Windows.Forms.Button();
            this.btnPositionMaintenance = new System.Windows.Forms.Button();
            this.btnDepartmentMaintenance = new System.Windows.Forms.Button();
            this.btnEmployeeMaintenance = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.pnlSubMenuLeave = new System.Windows.Forms.Panel();
            this.btnEmployeeCredits = new System.Windows.Forms.Button();
            this.btnLeaveApprove = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.pnlSubMenuEmployee = new System.Windows.Forms.Panel();
            this.btnEmployeeList = new System.Windows.Forms.Button();
            this.btnEmployeeRecords = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.pnlSide.SuspendLayout();
            this.pnlSubMenuMaintenance.SuspendLayout();
            this.pnlSubMenuLeave.SuspendLayout();
            this.pnlSubMenuEmployee.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.AutoScroll = true;
            this.pnlSide.BackColor = System.Drawing.Color.Gray;
            this.pnlSide.Controls.Add(this.btnLogOut);
            this.pnlSide.Controls.Add(this.btnAudit);
            this.pnlSide.Controls.Add(this.pnlSubMenuMaintenance);
            this.pnlSide.Controls.Add(this.btnMaintenance);
            this.pnlSide.Controls.Add(this.pnlSubMenuLeave);
            this.pnlSide.Controls.Add(this.btnLeave);
            this.pnlSide.Controls.Add(this.pnlSubMenuEmployee);
            this.pnlSide.Controls.Add(this.btnEmployeeRecords);
            this.pnlSide.Controls.Add(this.btnDashboard);
            this.pnlSide.Controls.Add(this.pnlLogo);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(230, 640);
            this.pnlSide.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(0, 671);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(213, 45);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAudit
            // 
            this.btnAudit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAudit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAudit.FlatAppearance.BorderSize = 0;
            this.btnAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAudit.ForeColor = System.Drawing.Color.White;
            this.btnAudit.Location = new System.Drawing.Point(0, 626);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(213, 45);
            this.btnAudit.TabIndex = 8;
            this.btnAudit.Text = "Audit Trail";
            this.btnAudit.UseVisualStyleBackColor = false;
            // 
            // pnlSubMenuMaintenance
            // 
            this.pnlSubMenuMaintenance.AutoScroll = true;
            this.pnlSubMenuMaintenance.Controls.Add(this.btnLeaveMaintenance);
            this.pnlSubMenuMaintenance.Controls.Add(this.btnRankMaintenance);
            this.pnlSubMenuMaintenance.Controls.Add(this.btnPositionMaintenance);
            this.pnlSubMenuMaintenance.Controls.Add(this.btnDepartmentMaintenance);
            this.pnlSubMenuMaintenance.Controls.Add(this.btnEmployeeMaintenance);
            this.pnlSubMenuMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuMaintenance.Location = new System.Drawing.Point(0, 455);
            this.pnlSubMenuMaintenance.Name = "pnlSubMenuMaintenance";
            this.pnlSubMenuMaintenance.Size = new System.Drawing.Size(213, 171);
            this.pnlSubMenuMaintenance.TabIndex = 7;
            // 
            // btnLeaveMaintenance
            // 
            this.btnLeaveMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLeaveMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeaveMaintenance.FlatAppearance.BorderSize = 0;
            this.btnLeaveMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeaveMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnLeaveMaintenance.Location = new System.Drawing.Point(0, 180);
            this.btnLeaveMaintenance.Name = "btnLeaveMaintenance";
            this.btnLeaveMaintenance.Size = new System.Drawing.Size(196, 45);
            this.btnLeaveMaintenance.TabIndex = 11;
            this.btnLeaveMaintenance.Text = "Leave Maintenance";
            this.btnLeaveMaintenance.UseVisualStyleBackColor = false;
            this.btnLeaveMaintenance.Click += new System.EventHandler(this.btnLeaveMaintenance_Click);
            // 
            // btnRankMaintenance
            // 
            this.btnRankMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRankMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRankMaintenance.FlatAppearance.BorderSize = 0;
            this.btnRankMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRankMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRankMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnRankMaintenance.Location = new System.Drawing.Point(0, 135);
            this.btnRankMaintenance.Name = "btnRankMaintenance";
            this.btnRankMaintenance.Size = new System.Drawing.Size(196, 45);
            this.btnRankMaintenance.TabIndex = 10;
            this.btnRankMaintenance.Text = "Rank Maintenance";
            this.btnRankMaintenance.UseVisualStyleBackColor = false;
            this.btnRankMaintenance.Click += new System.EventHandler(this.btnRankMaintenance_Click);
            // 
            // btnPositionMaintenance
            // 
            this.btnPositionMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPositionMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPositionMaintenance.FlatAppearance.BorderSize = 0;
            this.btnPositionMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositionMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPositionMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnPositionMaintenance.Location = new System.Drawing.Point(0, 90);
            this.btnPositionMaintenance.Name = "btnPositionMaintenance";
            this.btnPositionMaintenance.Size = new System.Drawing.Size(196, 45);
            this.btnPositionMaintenance.TabIndex = 9;
            this.btnPositionMaintenance.Text = "Position Maintenance";
            this.btnPositionMaintenance.UseVisualStyleBackColor = false;
            this.btnPositionMaintenance.Click += new System.EventHandler(this.btnPositionMaintenance_Click);
            // 
            // btnDepartmentMaintenance
            // 
            this.btnDepartmentMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDepartmentMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartmentMaintenance.FlatAppearance.BorderSize = 0;
            this.btnDepartmentMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDepartmentMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnDepartmentMaintenance.Location = new System.Drawing.Point(0, 45);
            this.btnDepartmentMaintenance.Name = "btnDepartmentMaintenance";
            this.btnDepartmentMaintenance.Size = new System.Drawing.Size(196, 45);
            this.btnDepartmentMaintenance.TabIndex = 8;
            this.btnDepartmentMaintenance.Text = "Department Maintenance";
            this.btnDepartmentMaintenance.UseVisualStyleBackColor = false;
            this.btnDepartmentMaintenance.Click += new System.EventHandler(this.btnDepartmentMaintenance_Click);
            // 
            // btnEmployeeMaintenance
            // 
            this.btnEmployeeMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEmployeeMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeMaintenance.FlatAppearance.BorderSize = 0;
            this.btnEmployeeMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeMaintenance.Location = new System.Drawing.Point(0, 0);
            this.btnEmployeeMaintenance.Name = "btnEmployeeMaintenance";
            this.btnEmployeeMaintenance.Size = new System.Drawing.Size(196, 45);
            this.btnEmployeeMaintenance.TabIndex = 7;
            this.btnEmployeeMaintenance.Text = "Employee Maintenance";
            this.btnEmployeeMaintenance.UseVisualStyleBackColor = false;
            this.btnEmployeeMaintenance.Click += new System.EventHandler(this.btnEmployeeMaintenance_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 410);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(213, 45);
            this.btnMaintenance.TabIndex = 6;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // pnlSubMenuLeave
            // 
            this.pnlSubMenuLeave.Controls.Add(this.btnEmployeeCredits);
            this.pnlSubMenuLeave.Controls.Add(this.btnLeaveApprove);
            this.pnlSubMenuLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuLeave.Location = new System.Drawing.Point(0, 320);
            this.pnlSubMenuLeave.Name = "pnlSubMenuLeave";
            this.pnlSubMenuLeave.Size = new System.Drawing.Size(213, 90);
            this.pnlSubMenuLeave.TabIndex = 5;
            // 
            // btnEmployeeCredits
            // 
            this.btnEmployeeCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEmployeeCredits.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeCredits.FlatAppearance.BorderSize = 0;
            this.btnEmployeeCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeCredits.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeCredits.Location = new System.Drawing.Point(0, 45);
            this.btnEmployeeCredits.Name = "btnEmployeeCredits";
            this.btnEmployeeCredits.Size = new System.Drawing.Size(213, 45);
            this.btnEmployeeCredits.TabIndex = 6;
            this.btnEmployeeCredits.Text = "Employee Leave Credits";
            this.btnEmployeeCredits.UseVisualStyleBackColor = false;
            this.btnEmployeeCredits.Click += new System.EventHandler(this.btnEmployeeCredits_Click);
            // 
            // btnLeaveApprove
            // 
            this.btnLeaveApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLeaveApprove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeaveApprove.FlatAppearance.BorderSize = 0;
            this.btnLeaveApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeaveApprove.ForeColor = System.Drawing.Color.White;
            this.btnLeaveApprove.Location = new System.Drawing.Point(0, 0);
            this.btnLeaveApprove.Name = "btnLeaveApprove";
            this.btnLeaveApprove.Size = new System.Drawing.Size(213, 45);
            this.btnLeaveApprove.TabIndex = 5;
            this.btnLeaveApprove.Text = "Leave Approve";
            this.btnLeaveApprove.UseVisualStyleBackColor = false;
            this.btnLeaveApprove.Click += new System.EventHandler(this.btnLeaveApprove_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeave.FlatAppearance.BorderSize = 0;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeave.ForeColor = System.Drawing.Color.White;
            this.btnLeave.Location = new System.Drawing.Point(0, 275);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(213, 45);
            this.btnLeave.TabIndex = 4;
            this.btnLeave.Text = "Leaves";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // pnlSubMenuEmployee
            // 
            this.pnlSubMenuEmployee.Controls.Add(this.btnEmployeeList);
            this.pnlSubMenuEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuEmployee.Location = new System.Drawing.Point(0, 230);
            this.pnlSubMenuEmployee.Name = "pnlSubMenuEmployee";
            this.pnlSubMenuEmployee.Size = new System.Drawing.Size(213, 45);
            this.pnlSubMenuEmployee.TabIndex = 3;
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEmployeeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeList.FlatAppearance.BorderSize = 0;
            this.btnEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeList.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.Size = new System.Drawing.Size(213, 45);
            this.btnEmployeeList.TabIndex = 3;
            this.btnEmployeeList.Text = "Employee List";
            this.btnEmployeeList.UseVisualStyleBackColor = false;
            this.btnEmployeeList.Click += new System.EventHandler(this.btnEmployeeList_Click);
            // 
            // btnEmployeeRecords
            // 
            this.btnEmployeeRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEmployeeRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeRecords.FlatAppearance.BorderSize = 0;
            this.btnEmployeeRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeRecords.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeRecords.Location = new System.Drawing.Point(0, 185);
            this.btnEmployeeRecords.Name = "btnEmployeeRecords";
            this.btnEmployeeRecords.Size = new System.Drawing.Size(213, 45);
            this.btnEmployeeRecords.TabIndex = 2;
            this.btnEmployeeRecords.Text = "Employee Records";
            this.btnEmployeeRecords.UseVisualStyleBackColor = false;
            this.btnEmployeeRecords.Click += new System.EventHandler(this.btnEmployeeRecords_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 140);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(213, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(213, 140);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPanel.Location = new System.Drawing.Point(230, 0);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(958, 640);
            this.pnlMainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1188, 640);
            this.Controls.Add(this.pnlMainPanel);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSubMenuMaintenance.ResumeLayout(false);
            this.pnlSubMenuLeave.ResumeLayout(false);
            this.pnlSubMenuEmployee.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlSubMenuMaintenance;
        private System.Windows.Forms.Button btnLeaveMaintenance;
        private System.Windows.Forms.Button btnRankMaintenance;
        private System.Windows.Forms.Button btnPositionMaintenance;
        private System.Windows.Forms.Button btnDepartmentMaintenance;
        private System.Windows.Forms.Button btnEmployeeMaintenance;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Panel pnlSubMenuLeave;
        private System.Windows.Forms.Button btnEmployeeCredits;
        private System.Windows.Forms.Button btnLeaveApprove;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Panel pnlSubMenuEmployee;
        private System.Windows.Forms.Button btnEmployeeList;
        private System.Windows.Forms.Button btnEmployeeRecords;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAudit;
        private System.Windows.Forms.Panel pnlMainPanel;
        private System.Windows.Forms.Button btnLogOut;
        public System.Windows.Forms.Panel pnlSide;
    }
}

