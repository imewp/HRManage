namespace HRManage
{
    partial class DepartmentManage
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
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtHeadOfDepartment = new System.Windows.Forms.TextBox();
            this.lblHeadOfDepartment = new System.Windows.Forms.Label();
            this.txtDepartmentPhone = new System.Windows.Forms.TextBox();
            this.lblDepartmentPhone = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDepartmentInfo = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(33, 46);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(98, 18);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "部门名称：";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(123, 43);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(168, 28);
            this.txtDepartmentName.TabIndex = 1;
            // 
            // txtHeadOfDepartment
            // 
            this.txtHeadOfDepartment.Location = new System.Drawing.Point(123, 88);
            this.txtHeadOfDepartment.Name = "txtHeadOfDepartment";
            this.txtHeadOfDepartment.Size = new System.Drawing.Size(168, 28);
            this.txtHeadOfDepartment.TabIndex = 3;
            // 
            // lblHeadOfDepartment
            // 
            this.lblHeadOfDepartment.AutoSize = true;
            this.lblHeadOfDepartment.Location = new System.Drawing.Point(15, 91);
            this.lblHeadOfDepartment.Name = "lblHeadOfDepartment";
            this.lblHeadOfDepartment.Size = new System.Drawing.Size(116, 18);
            this.lblHeadOfDepartment.TabIndex = 2;
            this.lblHeadOfDepartment.Text = "部门负责人：";
            // 
            // txtDepartmentPhone
            // 
            this.txtDepartmentPhone.Location = new System.Drawing.Point(123, 137);
            this.txtDepartmentPhone.Name = "txtDepartmentPhone";
            this.txtDepartmentPhone.Size = new System.Drawing.Size(168, 28);
            this.txtDepartmentPhone.TabIndex = 5;
            // 
            // lblDepartmentPhone
            // 
            this.lblDepartmentPhone.AutoSize = true;
            this.lblDepartmentPhone.Location = new System.Drawing.Point(33, 140);
            this.lblDepartmentPhone.Name = "lblDepartmentPhone";
            this.lblDepartmentPhone.Size = new System.Drawing.Size(98, 18);
            this.lblDepartmentPhone.TabIndex = 4;
            this.lblDepartmentPhone.Text = "部门电话：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDepartmentName);
            this.groupBox1.Controls.Add(this.txtDepartmentPhone);
            this.groupBox1.Controls.Add(this.txtDepartmentName);
            this.groupBox1.Controls.Add(this.lblDepartmentPhone);
            this.groupBox1.Controls.Add(this.lblHeadOfDepartment);
            this.groupBox1.Controls.Add(this.txtHeadOfDepartment);
            this.groupBox1.Location = new System.Drawing.Point(64, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 185);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "部门信息";
            // 
            // dgvDepartmentInfo
            // 
            this.dgvDepartmentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentInfo.Location = new System.Drawing.Point(447, 61);
            this.dgvDepartmentInfo.Name = "dgvDepartmentInfo";
            this.dgvDepartmentInfo.RowTemplate.Height = 30;
            this.dgvDepartmentInfo.Size = new System.Drawing.Size(493, 238);
            this.dgvDepartmentInfo.TabIndex = 7;
            this.dgvDepartmentInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(100, 261);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 38);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(260, 261);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(81, 38);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // DepartmentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 371);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvDepartmentInfo);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理部门";
            this.Load += new System.EventHandler(this.DepartmentManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtHeadOfDepartment;
        private System.Windows.Forms.Label lblHeadOfDepartment;
        private System.Windows.Forms.TextBox txtDepartmentPhone;
        private System.Windows.Forms.Label lblDepartmentPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDepartmentInfo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;

    }
}