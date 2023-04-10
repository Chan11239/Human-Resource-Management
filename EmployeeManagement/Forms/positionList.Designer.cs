
namespace EmployeeManagement.Forms
{
    partial class positionList
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
            this.dgPosition = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntAddEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClassification = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPosition)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPosition
            // 
            this.dgPosition.AllowUserToAddRows = false;
            this.dgPosition.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgPosition.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.departmentName,
            this.classificationName,
            this.positionName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPosition.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPosition.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgPosition.Location = new System.Drawing.Point(42, 75);
            this.dgPosition.Name = "dgPosition";
            this.dgPosition.ReadOnly = true;
            this.dgPosition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgPosition.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPosition.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgPosition.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPosition.RowTemplate.Height = 25;
            this.dgPosition.Size = new System.Drawing.Size(644, 294);
            this.dgPosition.TabIndex = 36;
            this.dgPosition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPosition_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // departmentName
            // 
            this.departmentName.DataPropertyName = "departmentName";
            this.departmentName.HeaderText = "Department";
            this.departmentName.Name = "departmentName";
            this.departmentName.ReadOnly = true;
            this.departmentName.Width = 200;
            // 
            // classificationName
            // 
            this.classificationName.DataPropertyName = "classificationName";
            this.classificationName.HeaderText = "Classification";
            this.classificationName.Name = "classificationName";
            this.classificationName.ReadOnly = true;
            this.classificationName.Width = 150;
            // 
            // positionName
            // 
            this.positionName.DataPropertyName = "positionName";
            this.positionName.HeaderText = "Position";
            this.positionName.Name = "positionName";
            this.positionName.ReadOnly = true;
            this.positionName.Width = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Position Maintenance";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboDepartment);
            this.panel1.Controls.Add(this.txtPosition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bntAddEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboClassification);
            this.panel1.Location = new System.Drawing.Point(42, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 182);
            this.panel1.TabIndex = 37;
            // 
            // cboDepartment
            // 
            this.cboDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(169, 83);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(222, 28);
            this.cboDepartment.TabIndex = 36;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPosition.Location = new System.Drawing.Point(169, 136);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(222, 26);
            this.txtPosition.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Position:";
            // 
            // bntAddEdit
            // 
            this.bntAddEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bntAddEdit.FlatAppearance.BorderSize = 0;
            this.bntAddEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntAddEdit.ForeColor = System.Drawing.Color.White;
            this.bntAddEdit.Location = new System.Drawing.Point(428, 74);
            this.bntAddEdit.Name = "bntAddEdit";
            this.bntAddEdit.Size = new System.Drawing.Size(126, 45);
            this.bntAddEdit.TabIndex = 32;
            this.bntAddEdit.Text = "Add/Edit";
            this.bntAddEdit.UseVisualStyleBackColor = false;
            this.bntAddEdit.Click += new System.EventHandler(this.bntAddEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Department:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Classification:";
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
            this.cboClassification.Location = new System.Drawing.Point(169, 29);
            this.cboClassification.Name = "cboClassification";
            this.cboClassification.Size = new System.Drawing.Size(222, 28);
            this.cboClassification.TabIndex = 9;
            this.cboClassification.SelectedIndexChanged += new System.EventHandler(this.cboClassification_SelectedIndexChanged);
            // 
            // positionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgPosition);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "positionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "positionList";
            this.Load += new System.EventHandler(this.positionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPosition)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntAddEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionName;
    }
}