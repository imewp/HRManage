namespace HRManage
{
    partial class DepartmentAdd
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
            this.txtDepartmentPhone = new System.Windows.Forms.TextBox();
            this.lblDepartmentPhone = new System.Windows.Forms.Label();
            this.txtHeadOfDepartment = new System.Windows.Forms.TextBox();
            this.lblHeadOfDepartment = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(72, 68);
            this.lblDepartmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(98, 18);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "部门名称：";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(194, 63);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(148, 28);
            this.txtDepartmentName.TabIndex = 1;
            // 
            // txtDepartmentPhone
            // 
            this.txtDepartmentPhone.Location = new System.Drawing.Point(194, 196);
            this.txtDepartmentPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmentPhone.Name = "txtDepartmentPhone";
            this.txtDepartmentPhone.Size = new System.Drawing.Size(148, 28);
            this.txtDepartmentPhone.TabIndex = 3;
            // 
            // lblDepartmentPhone
            // 
            this.lblDepartmentPhone.AutoSize = true;
            this.lblDepartmentPhone.Location = new System.Drawing.Point(72, 201);
            this.lblDepartmentPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartmentPhone.Name = "lblDepartmentPhone";
            this.lblDepartmentPhone.Size = new System.Drawing.Size(98, 18);
            this.lblDepartmentPhone.TabIndex = 2;
            this.lblDepartmentPhone.Text = "部门电话：";
            // 
            // txtHeadOfDepartment
            // 
            this.txtHeadOfDepartment.Location = new System.Drawing.Point(194, 128);
            this.txtHeadOfDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeadOfDepartment.Name = "txtHeadOfDepartment";
            this.txtHeadOfDepartment.Size = new System.Drawing.Size(148, 28);
            this.txtHeadOfDepartment.TabIndex = 5;
            // 
            // lblHeadOfDepartment
            // 
            this.lblHeadOfDepartment.AutoSize = true;
            this.lblHeadOfDepartment.Location = new System.Drawing.Point(72, 132);
            this.lblHeadOfDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadOfDepartment.Name = "lblHeadOfDepartment";
            this.lblHeadOfDepartment.Size = new System.Drawing.Size(116, 18);
            this.lblHeadOfDepartment.TabIndex = 4;
            this.lblHeadOfDepartment.Text = "部门负责人：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(75, 273);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(255, 272);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 34);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // DepartmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 393);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtHeadOfDepartment);
            this.Controls.Add(this.lblHeadOfDepartment);
            this.Controls.Add(this.txtDepartmentPhone);
            this.Controls.Add(this.lblDepartmentPhone);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.lblDepartmentName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加部门";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentPhone;
        private System.Windows.Forms.Label lblDepartmentPhone;
        private System.Windows.Forms.TextBox txtHeadOfDepartment;
        private System.Windows.Forms.Label lblHeadOfDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
    }
}