
namespace EmployeeManagement.Forms
{
    partial class rankList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRankList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRankName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtSalaryRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassification = new System.Windows.Forms.TextBox();
            this.bntAdd = new System.Windows.Forms.Button();
            this.txtStartPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRankList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Rank Maintenance";
            // 
            // Classification
            // 
            this.Classification.HeaderText = "Column1";
            this.Classification.Name = "Classification";
            // 
            // dgRankList
            // 
            this.dgRankList.AllowUserToAddRows = false;
            this.dgRankList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgRankList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRankList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRankList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRankList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.classificationName,
            this.startPoint,
            this.endPoint,
            this.type,
            this.rankName,
            this.salaryRate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRankList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgRankList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgRankList.Location = new System.Drawing.Point(55, 79);
            this.dgRankList.Name = "dgRankList";
            this.dgRankList.ReadOnly = true;
            this.dgRankList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgRankList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRankList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgRankList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgRankList.RowTemplate.Height = 25;
            this.dgRankList.Size = new System.Drawing.Size(565, 294);
            this.dgRankList.TabIndex = 37;
            this.dgRankList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRankList_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // classificationName
            // 
            this.classificationName.DataPropertyName = "classificationName";
            this.classificationName.HeaderText = "Classification";
            this.classificationName.Name = "classificationName";
            this.classificationName.ReadOnly = true;
            this.classificationName.Width = 150;
            // 
            // startPoint
            // 
            this.startPoint.DataPropertyName = "startPoint";
            this.startPoint.HeaderText = "Start Point";
            this.startPoint.Name = "startPoint";
            this.startPoint.ReadOnly = true;
            // 
            // endPoint
            // 
            this.endPoint.DataPropertyName = "endPoint";
            this.endPoint.HeaderText = "End Point";
            this.endPoint.Name = "endPoint";
            this.endPoint.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // rankName
            // 
            this.rankName.DataPropertyName = "rankName";
            this.rankName.HeaderText = "Rank Name";
            this.rankName.Name = "rankName";
            this.rankName.ReadOnly = true;
            // 
            // salaryRate
            // 
            this.salaryRate.DataPropertyName = "salaryRate";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.salaryRate.DefaultCellStyle = dataGridViewCellStyle2;
            this.salaryRate.HeaderText = "Salary Rate";
            this.salaryRate.Name = "salaryRate";
            this.salaryRate.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtRankName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboType);
            this.panel1.Controls.Add(this.txtSalaryRate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEndPoint);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtClassification);
            this.panel1.Controls.Add(this.bntAdd);
            this.panel1.Controls.Add(this.txtStartPoint);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 316);
            this.panel1.TabIndex = 38;
            // 
            // txtRankName
            // 
            this.txtRankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRankName.Location = new System.Drawing.Point(206, 208);
            this.txtRankName.Name = "txtRankName";
            this.txtRankName.Size = new System.Drawing.Size(222, 26);
            this.txtRankName.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(44, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Rank Name:";
            // 
            // cboType
            // 
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Full Time",
            "Part Time"});
            this.cboType.Location = new System.Drawing.Point(206, 164);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(222, 28);
            this.cboType.TabIndex = 40;
            // 
            // txtSalaryRate
            // 
            this.txtSalaryRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalaryRate.Location = new System.Drawing.Point(206, 253);
            this.txtSalaryRate.Name = "txtSalaryRate";
            this.txtSalaryRate.Size = new System.Drawing.Size(222, 26);
            this.txtSalaryRate.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Salary Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Type:";
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndPoint.Location = new System.Drawing.Point(206, 122);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(222, 26);
            this.txtEndPoint.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "End Point:";
            // 
            // txtClassification
            // 
            this.txtClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClassification.Location = new System.Drawing.Point(206, 33);
            this.txtClassification.Name = "txtClassification";
            this.txtClassification.Size = new System.Drawing.Size(222, 26);
            this.txtClassification.TabIndex = 34;
            // 
            // bntAdd
            // 
            this.bntAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bntAdd.FlatAppearance.BorderSize = 0;
            this.bntAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntAdd.ForeColor = System.Drawing.Color.White;
            this.bntAdd.Location = new System.Drawing.Point(495, 113);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(126, 45);
            this.bntAdd.TabIndex = 32;
            this.bntAdd.Text = "Add/Edit";
            this.bntAdd.UseVisualStyleBackColor = false;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // txtStartPoint
            // 
            this.txtStartPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartPoint.Location = new System.Drawing.Point(206, 80);
            this.txtStartPoint.Name = "txtStartPoint";
            this.txtStartPoint.Size = new System.Drawing.Size(222, 26);
            this.txtStartPoint.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Start Point:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Classification:";
            // 
            // rankList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(719, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgRankList);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rankList";
            this.Text = "rankList";
            this.Load += new System.EventHandler(this.rankList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRankList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classification;
        private System.Windows.Forms.DataGridView dgRankList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRankName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtSalaryRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassification;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.TextBox txtStartPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn endPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryRate;
    }
}