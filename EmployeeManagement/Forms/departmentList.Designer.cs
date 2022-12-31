
namespace EmployeeManagement
{
    partial class departmentList
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgDepartmentList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntAddEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClassification = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartmentList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department Maintenance";
            // 
            // dgDepartmentList
            // 
            this.dgDepartmentList.AllowUserToAddRows = false;
            this.dgDepartmentList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgDepartmentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDepartmentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDepartmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDepartmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.departmentName,
            this.classificationName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDepartmentList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgDepartmentList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgDepartmentList.Location = new System.Drawing.Point(69, 75);
            this.dgDepartmentList.Name = "dgDepartmentList";
            this.dgDepartmentList.ReadOnly = true;
            this.dgDepartmentList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgDepartmentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDepartmentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgDepartmentList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgDepartmentList.RowTemplate.Height = 25;
            this.dgDepartmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDepartmentList.Size = new System.Drawing.Size(573, 267);
            this.dgDepartmentList.TabIndex = 33;
            this.dgDepartmentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDepartmentList_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // departmentName
            // 
            this.departmentName.DataPropertyName = "departmentName";
            this.departmentName.HeaderText = "Department Name";
            this.departmentName.Name = "departmentName";
            this.departmentName.ReadOnly = true;
            this.departmentName.Width = 220;
            // 
            // classificationName
            // 
            this.classificationName.DataPropertyName = "classificationName";
            this.classificationName.HeaderText = "Classification Name";
            this.classificationName.Name = "classificationName";
            this.classificationName.ReadOnly = true;
            this.classificationName.Width = 210;
            // 
            // bntAddEdit
            // 
            this.bntAddEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bntAddEdit.FlatAppearance.BorderSize = 0;
            this.bntAddEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntAddEdit.ForeColor = System.Drawing.Color.White;
            this.bntAddEdit.Location = new System.Drawing.Point(457, 59);
            this.bntAddEdit.Name = "bntAddEdit";
            this.bntAddEdit.Size = new System.Drawing.Size(126, 45);
            this.bntAddEdit.TabIndex = 32;
            this.bntAddEdit.Text = "Add/Edit";
            this.bntAddEdit.UseVisualStyleBackColor = false;
            this.bntAddEdit.Click += new System.EventHandler(this.bntAddEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Classification:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntAddEdit);
            this.panel1.Controls.Add(this.txtDepartment);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboClassification);
            this.panel1.Location = new System.Drawing.Point(34, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 174);
            this.panel1.TabIndex = 34;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDepartment.Location = new System.Drawing.Point(175, 106);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(222, 26);
            this.txtDepartment.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Department:";
            // 
            // cboClassification
            // 
            this.cboClassification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboClassification.FormattingEnabled = true;
            this.cboClassification.Items.AddRange(new object[] {
            "----",
            "Teaching",
            "Non-Teaching"});
            this.cboClassification.Location = new System.Drawing.Point(175, 32);
            this.cboClassification.Name = "cboClassification";
            this.cboClassification.Size = new System.Drawing.Size(222, 28);
            this.cboClassification.TabIndex = 9;
            // 
            // departmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(735, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgDepartmentList);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "departmentList";
            this.Text = "DepartmentMaintenance";
            this.Load += new System.EventHandler(this.DepartmentMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartmentList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgDepartmentList;
        private System.Windows.Forms.Button bntAddEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificationName;
    }
}