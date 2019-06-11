namespace HRManage
{
    partial class UserManage
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
            this.gbxUserInfo = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.cboUserType = new System.Windows.Forms.ComboBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvUserInfo = new System.Windows.Forms.DataGridView();
            this.gbxUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxUserInfo
            // 
            this.gbxUserInfo.Controls.Add(this.txtUserName);
            this.gbxUserInfo.Controls.Add(this.lblUserType);
            this.gbxUserInfo.Controls.Add(this.cboUserType);
            this.gbxUserInfo.Controls.Add(this.txtUserPassword);
            this.gbxUserInfo.Controls.Add(this.lblPassword);
            this.gbxUserInfo.Controls.Add(this.lblName);
            this.gbxUserInfo.Location = new System.Drawing.Point(70, 82);
            this.gbxUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxUserInfo.Name = "gbxUserInfo";
            this.gbxUserInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxUserInfo.Size = new System.Drawing.Size(410, 196);
            this.gbxUserInfo.TabIndex = 152;
            this.gbxUserInfo.TabStop = false;
            this.gbxUserInfo.Text = "用户信息";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(130, 38);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(202, 28);
            this.txtUserName.TabIndex = 151;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(33, 153);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(98, 18);
            this.lblUserType.TabIndex = 150;
            this.lblUserType.Text = "用户类型：";
            // 
            // cboUserType
            // 
            this.cboUserType.FormattingEnabled = true;
            this.cboUserType.Items.AddRange(new object[] {
            "管理员",
            "操作员",
            "经理"});
            this.cboUserType.Location = new System.Drawing.Point(130, 148);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(202, 26);
            this.cboUserType.TabIndex = 149;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(130, 92);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(202, 28);
            this.txtUserPassword.TabIndex = 148;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(33, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 18);
            this.lblPassword.TabIndex = 147;
            this.lblPassword.Text = "用户密码：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 18);
            this.lblName.TabIndex = 146;
            this.lblName.Text = "用户姓名：";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(310, 322);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(93, 40);
            this.btnDel.TabIndex = 151;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(161, 322);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 40);
            this.btnEdit.TabIndex = 150;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfo.Location = new System.Drawing.Point(539, 82);
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.RowTemplate.Height = 27;
            this.dgvUserInfo.Size = new System.Drawing.Size(580, 268);
            this.dgvUserInfo.TabIndex = 149;
            this.dgvUserInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserInfo_CellClick);
            // 
            // UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 444);
            this.Controls.Add(this.gbxUserInfo);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvUserInfo);
            this.Name = "UserManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理用户";
            this.Load += new System.EventHandler(this.UserManage_Load);
            this.gbxUserInfo.ResumeLayout(false);
            this.gbxUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUserInfo;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cboUserType;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvUserInfo;
    }
}