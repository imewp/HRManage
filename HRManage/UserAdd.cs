using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            Model.UserInfo model = new Model.UserInfo();//实例化Model层
            model.UserName = txtUserName.Text.Trim();
            model.UserPassword = txtUserPassword.Text.Trim();
            model.UserType = cboUserType.Text;

            BLL.UserInfo bll = new BLL.UserInfo();//实例化BLL层
            model = bll.ToMD5(model);
            if(bll.Add(model))
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
