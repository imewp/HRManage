namespace HRManage
{
    partial class SalaryManage
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
            this.dgvSalaryInfo = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.txtFinalPay = new System.Windows.Forms.TextBox();
            this.lblFinalPay = new System.Windows.Forms.Label();
            this.txtOtherSubtract = new System.Windows.Forms.TextBox();
            this.lblOtherSubtract = new System.Windows.Forms.Label();
            this.txtOtherAdd = new System.Windows.Forms.TextBox();
            this.lblOtherAdd = new System.Windows.Forms.Label();
            this.txtBouns = new System.Windows.Forms.TextBox();
            this.lblBouns = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.txtPostSalary = new System.Windows.Forms.TextBox();
            this.lblPostSalary = new System.Windows.Forms.Label();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSalayMonth = new System.Windows.Forms.DateTimePicker();
            this.lblSalayMonth = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSalaryInfo
            // 
            this.dgvSalaryInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryInfo.Location = new System.Drawing.Point(49, 551);
            this.dgvSalaryInfo.Name = "dgvSalaryInfo";
            this.dgvSalaryInfo.RowTemplate.Height = 30;
            this.dgvSalaryInfo.Size = new System.Drawing.Size(791, 210);
            this.dgvSalaryInfo.TabIndex = 13;
            this.dgvSalaryInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryInfo_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(506, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 49);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(127, 380);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(206, 28);
            this.txtTotalPay.TabIndex = 27;
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Location = new System.Drawing.Point(38, 383);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(98, 18);
            this.lblTotalPay.TabIndex = 26;
            this.lblTotalPay.Text = "应得工资：";
            // 
            // txtFinalPay
            // 
            this.txtFinalPay.Location = new System.Drawing.Point(127, 334);
            this.txtFinalPay.Name = "txtFinalPay";
            this.txtFinalPay.Size = new System.Drawing.Size(206, 28);
            this.txtFinalPay.TabIndex = 25;
            // 
            // lblFinalPay
            // 
            this.lblFinalPay.AutoSize = true;
            this.lblFinalPay.Location = new System.Drawing.Point(38, 337);
            this.lblFinalPay.Name = "lblFinalPay";
            this.lblFinalPay.Size = new System.Drawing.Size(98, 18);
            this.lblFinalPay.TabIndex = 24;
            this.lblFinalPay.Text = "实发工资：";
            // 
            // txtOtherSubtract
            // 
            this.txtOtherSubtract.Location = new System.Drawing.Point(127, 282);
            this.txtOtherSubtract.Name = "txtOtherSubtract";
            this.txtOtherSubtract.Size = new System.Drawing.Size(206, 28);
            this.txtOtherSubtract.TabIndex = 23;
            // 
            // lblOtherSubtract
            // 
            this.lblOtherSubtract.AutoSize = true;
            this.lblOtherSubtract.Location = new System.Drawing.Point(38, 285);
            this.lblOtherSubtract.Name = "lblOtherSubtract";
            this.lblOtherSubtract.Size = new System.Drawing.Size(98, 18);
            this.lblOtherSubtract.TabIndex = 22;
            this.lblOtherSubtract.Text = "其 他 扣：";
            // 
            // txtOtherAdd
            // 
            this.txtOtherAdd.Location = new System.Drawing.Point(127, 236);
            this.txtOtherAdd.Name = "txtOtherAdd";
            this.txtOtherAdd.Size = new System.Drawing.Size(206, 28);
            this.txtOtherAdd.TabIndex = 21;
            // 
            // lblOtherAdd
            // 
            this.lblOtherAdd.AutoSize = true;
            this.lblOtherAdd.Location = new System.Drawing.Point(38, 239);
            this.lblOtherAdd.Name = "lblOtherAdd";
            this.lblOtherAdd.Size = new System.Drawing.Size(98, 18);
            this.lblOtherAdd.TabIndex = 20;
            this.lblOtherAdd.Text = "其 他 加：";
            // 
            // txtBouns
            // 
            this.txtBouns.Location = new System.Drawing.Point(127, 184);
            this.txtBouns.Name = "txtBouns";
            this.txtBouns.Size = new System.Drawing.Size(206, 28);
            this.txtBouns.TabIndex = 19;
            // 
            // lblBouns
            // 
            this.lblBouns.AutoSize = true;
            this.lblBouns.Location = new System.Drawing.Point(38, 187);
            this.lblBouns.Name = "lblBouns";
            this.lblBouns.Size = new System.Drawing.Size(98, 18);
            this.lblBouns.TabIndex = 18;
            this.lblBouns.Text = "奖    金：";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(290, 492);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 49);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAllowance
            // 
            this.txtAllowance.Location = new System.Drawing.Point(127, 138);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(206, 28);
            this.txtAllowance.TabIndex = 17;
            // 
            // lblAllowance
            // 
            this.lblAllowance.AutoSize = true;
            this.lblAllowance.Location = new System.Drawing.Point(38, 141);
            this.lblAllowance.Name = "lblAllowance";
            this.lblAllowance.Size = new System.Drawing.Size(98, 18);
            this.lblAllowance.TabIndex = 16;
            this.lblAllowance.Text = "补    贴：";
            // 
            // txtPostSalary
            // 
            this.txtPostSalary.Location = new System.Drawing.Point(127, 90);
            this.txtPostSalary.Name = "txtPostSalary";
            this.txtPostSalary.Size = new System.Drawing.Size(206, 28);
            this.txtPostSalary.TabIndex = 15;
            // 
            // lblPostSalary
            // 
            this.lblPostSalary.AutoSize = true;
            this.lblPostSalary.Location = new System.Drawing.Point(38, 93);
            this.lblPostSalary.Name = "lblPostSalary";
            this.lblPostSalary.Size = new System.Drawing.Size(98, 18);
            this.lblPostSalary.TabIndex = 14;
            this.lblPostSalary.Text = "岗位工资：";
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(127, 42);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(206, 28);
            this.txtBasicSalary.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalPay);
            this.groupBox2.Controls.Add(this.lblTotalPay);
            this.groupBox2.Controls.Add(this.txtFinalPay);
            this.groupBox2.Controls.Add(this.lblFinalPay);
            this.groupBox2.Controls.Add(this.txtOtherSubtract);
            this.groupBox2.Controls.Add(this.lblOtherSubtract);
            this.groupBox2.Controls.Add(this.txtOtherAdd);
            this.groupBox2.Controls.Add(this.lblOtherAdd);
            this.groupBox2.Controls.Add(this.txtBouns);
            this.groupBox2.Controls.Add(this.lblBouns);
            this.groupBox2.Controls.Add(this.txtAllowance);
            this.groupBox2.Controls.Add(this.lblAllowance);
            this.groupBox2.Controls.Add(this.txtPostSalary);
            this.groupBox2.Controls.Add(this.lblPostSalary);
            this.groupBox2.Controls.Add(this.txtBasicSalary);
            this.groupBox2.Controls.Add(this.lblBasicSalary);
            this.groupBox2.Location = new System.Drawing.Point(465, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 432);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "工资信息";
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Location = new System.Drawing.Point(38, 45);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(98, 18);
            this.lblBasicSalary.TabIndex = 12;
            this.lblBasicSalary.Text = "基本工资：";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(127, 186);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(206, 222);
            this.txtRemarks.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "备    注：";
            // 
            // dtpSalayMonth
            // 
            this.dtpSalayMonth.Location = new System.Drawing.Point(127, 141);
            this.dtpSalayMonth.Name = "dtpSalayMonth";
            this.dtpSalayMonth.Size = new System.Drawing.Size(206, 28);
            this.dtpSalayMonth.TabIndex = 17;
            // 
            // lblSalayMonth
            // 
            this.lblSalayMonth.AutoSize = true;
            this.lblSalayMonth.Location = new System.Drawing.Point(38, 148);
            this.lblSalayMonth.Name = "lblSalayMonth";
            this.lblSalayMonth.Size = new System.Drawing.Size(98, 18);
            this.lblSalayMonth.TabIndex = 16;
            this.lblSalayMonth.Text = "发放日期：";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(127, 90);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(206, 28);
            this.txtEmployeeName.TabIndex = 15;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(38, 93);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(98, 18);
            this.lblEmployeeName.TabIndex = 14;
            this.lblEmployeeName.Text = "员工姓名：";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(127, 42);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(206, 28);
            this.txtEmployeeID.TabIndex = 13;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(38, 45);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(98, 18);
            this.lblEmployeeID.TabIndex = 12;
            this.lblEmployeeID.Text = "员工编号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpSalayMonth);
            this.groupBox1.Controls.Add(this.lblSalayMonth);
            this.groupBox1.Controls.Add(this.txtEmployeeName);
            this.groupBox1.Controls.Add(this.lblEmployeeName);
            this.groupBox1.Controls.Add(this.txtEmployeeID);
            this.groupBox1.Controls.Add(this.lblEmployeeID);
            this.groupBox1.Location = new System.Drawing.Point(49, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 432);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // SalaryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 784);
            this.Controls.Add(this.dgvSalaryInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalaryManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理工资";
            this.Load += new System.EventHandler(this.SalaryManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalaryInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.TextBox txtFinalPay;
        private System.Windows.Forms.Label lblFinalPay;
        private System.Windows.Forms.TextBox txtOtherSubtract;
        private System.Windows.Forms.Label lblOtherSubtract;
        private System.Windows.Forms.TextBox txtOtherAdd;
        private System.Windows.Forms.Label lblOtherAdd;
        private System.Windows.Forms.TextBox txtBouns;
        private System.Windows.Forms.Label lblBouns;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.Label lblAllowance;
        private System.Windows.Forms.TextBox txtPostSalary;
        private System.Windows.Forms.Label lblPostSalary;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSalayMonth;
        private System.Windows.Forms.Label lblSalayMonth;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}