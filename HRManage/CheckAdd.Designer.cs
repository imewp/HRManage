namespace HRManage
{
    partial class CheckAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmplyeeName = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpCheckDate = new System.Windows.Forms.DateTimePicker();
            this.txtCheckContent = new System.Windows.Forms.TextBox();
            this.lblCheckContent = new System.Windows.Forms.Label();
            this.lblCheckDate = new System.Windows.Forms.Label();
            this.txtCheckPeople = new System.Windows.Forms.TextBox();
            this.lblCheckPeople = new System.Windows.Forms.Label();
            this.txtCheckResult = new System.Windows.Forms.TextBox();
            this.lblCheckResult = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.lblRemarks);
            this.groupBox1.Controls.Add(this.txtDepartmentName);
            this.groupBox1.Controls.Add(this.lblDepartmentName);
            this.groupBox1.Controls.Add(this.txtEmployeeName);
            this.groupBox1.Controls.Add(this.lblEmplyeeName);
            this.groupBox1.Controls.Add(this.txtEmployeeID);
            this.groupBox1.Controls.Add(this.lblEmployeeID);
            this.groupBox1.Location = new System.Drawing.Point(28, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 373);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(127, 209);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(206, 142);
            this.txtRemarks.TabIndex = 7;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(38, 212);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(98, 18);
            this.lblRemarks.TabIndex = 6;
            this.lblRemarks.Text = "备    注：";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(127, 153);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(206, 28);
            this.txtDepartmentName.TabIndex = 5;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(38, 156);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(98, 18);
            this.lblDepartmentName.TabIndex = 4;
            this.lblDepartmentName.Text = "部门名称：";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(127, 97);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(206, 28);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // lblEmplyeeName
            // 
            this.lblEmplyeeName.AutoSize = true;
            this.lblEmplyeeName.Location = new System.Drawing.Point(38, 100);
            this.lblEmplyeeName.Name = "lblEmplyeeName";
            this.lblEmplyeeName.Size = new System.Drawing.Size(98, 18);
            this.lblEmplyeeName.TabIndex = 2;
            this.lblEmplyeeName.Text = "员工姓名：";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(127, 43);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(206, 28);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(38, 46);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(98, 18);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "员工编号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpCheckDate);
            this.groupBox2.Controls.Add(this.txtCheckContent);
            this.groupBox2.Controls.Add(this.lblCheckContent);
            this.groupBox2.Controls.Add(this.lblCheckDate);
            this.groupBox2.Controls.Add(this.txtCheckPeople);
            this.groupBox2.Controls.Add(this.lblCheckPeople);
            this.groupBox2.Controls.Add(this.txtCheckResult);
            this.groupBox2.Controls.Add(this.lblCheckResult);
            this.groupBox2.Location = new System.Drawing.Point(455, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 373);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "考核信息";
            // 
            // dtpCheckDate
            // 
            this.dtpCheckDate.Location = new System.Drawing.Point(127, 149);
            this.dtpCheckDate.Name = "dtpCheckDate";
            this.dtpCheckDate.Size = new System.Drawing.Size(206, 28);
            this.dtpCheckDate.TabIndex = 15;
            // 
            // txtCheckContent
            // 
            this.txtCheckContent.Location = new System.Drawing.Point(127, 202);
            this.txtCheckContent.Multiline = true;
            this.txtCheckContent.Name = "txtCheckContent";
            this.txtCheckContent.Size = new System.Drawing.Size(206, 149);
            this.txtCheckContent.TabIndex = 14;
            // 
            // lblCheckContent
            // 
            this.lblCheckContent.AutoSize = true;
            this.lblCheckContent.Location = new System.Drawing.Point(38, 205);
            this.lblCheckContent.Name = "lblCheckContent";
            this.lblCheckContent.Size = new System.Drawing.Size(98, 18);
            this.lblCheckContent.TabIndex = 13;
            this.lblCheckContent.Text = "考核内容：";
            // 
            // lblCheckDate
            // 
            this.lblCheckDate.AutoSize = true;
            this.lblCheckDate.Location = new System.Drawing.Point(38, 156);
            this.lblCheckDate.Name = "lblCheckDate";
            this.lblCheckDate.Size = new System.Drawing.Size(98, 18);
            this.lblCheckDate.TabIndex = 11;
            this.lblCheckDate.Text = "考核日期：";
            // 
            // txtCheckPeople
            // 
            this.txtCheckPeople.Location = new System.Drawing.Point(127, 97);
            this.txtCheckPeople.Name = "txtCheckPeople";
            this.txtCheckPeople.Size = new System.Drawing.Size(206, 28);
            this.txtCheckPeople.TabIndex = 10;
            // 
            // lblCheckPeople
            // 
            this.lblCheckPeople.AutoSize = true;
            this.lblCheckPeople.Location = new System.Drawing.Point(38, 100);
            this.lblCheckPeople.Name = "lblCheckPeople";
            this.lblCheckPeople.Size = new System.Drawing.Size(98, 18);
            this.lblCheckPeople.TabIndex = 2;
            this.lblCheckPeople.Text = "考 核 人：";
            // 
            // txtCheckResult
            // 
            this.txtCheckResult.Location = new System.Drawing.Point(127, 43);
            this.txtCheckResult.Name = "txtCheckResult";
            this.txtCheckResult.Size = new System.Drawing.Size(206, 28);
            this.txtCheckResult.TabIndex = 1;
            // 
            // lblCheckResult
            // 
            this.lblCheckResult.AutoSize = true;
            this.lblCheckResult.Location = new System.Drawing.Point(38, 46);
            this.lblCheckResult.Name = "lblCheckResult";
            this.lblCheckResult.Size = new System.Drawing.Size(98, 18);
            this.lblCheckResult.TabIndex = 0;
            this.lblCheckResult.Text = "考核结果：";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(464, 446);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 49);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(301, 446);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 49);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvEmployeeInfo
            // 
            this.dgvEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeInfo.Location = new System.Drawing.Point(28, 519);
            this.dgvEmployeeInfo.Name = "dgvEmployeeInfo";
            this.dgvEmployeeInfo.RowTemplate.Height = 30;
            this.dgvEmployeeInfo.Size = new System.Drawing.Size(830, 214);
            this.dgvEmployeeInfo.TabIndex = 6;
            this.dgvEmployeeInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeInfo_CellClick);
            // 
            // CheckAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 758);
            this.Controls.Add(this.dgvEmployeeInfo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加考核";
            this.Load += new System.EventHandler(this.CheckAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCheckPeople;
        private System.Windows.Forms.TextBox txtCheckResult;
        private System.Windows.Forms.Label lblCheckResult;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmplyeeName;
        private System.Windows.Forms.TextBox txtCheckContent;
        private System.Windows.Forms.Label lblCheckContent;
        private System.Windows.Forms.Label lblCheckDate;
        private System.Windows.Forms.TextBox txtCheckPeople;
        private System.Windows.Forms.DateTimePicker dtpCheckDate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvEmployeeInfo;
    }
}