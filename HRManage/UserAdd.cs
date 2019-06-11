using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRManage
{
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (this.txtUserName.Text.Trim().Length == 0)
            {
                strErr += "用户名不能为空！\\n";
            }
            if (this.txtUserPassword.Text.Trim().Length == 0)
            {
                strErr += "密码不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string userName = txtUserName.Text.Trim();
            string userPassword = txtUserPassword.Text.Trim();
            string userType = cboUserType.Text;

            Model.UserInfo model = new Model.UserInfo();//实例化Model层
            model.UserName = userName;
            model.UserPassword = userPassword;
            model.UserType = userType;

            BLL.UserInfo bll = new BLL.UserInfo();//实例化BLL层
            if (bll.Add(model) == true)//将用户信息添加到数据库中，根据返回值判断是否添加成功
            {
                MessageBox.Show("数据添加成功");
            }
            else
            {
                MessageBox.Show("数据添加失败");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            txtUserName.Focus();
        }
    }
}
