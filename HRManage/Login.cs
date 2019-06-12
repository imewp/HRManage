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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Model.UserInfo model = new Model.UserInfo();//实例化Model层
            model.UserName = txtUserName.Text.Trim();
            model.UserPassword = txtUserPassword.Text.Trim();
            BLL.UserInfo bll = new BLL.UserInfo(); //实例化BLL层  
            model = bll.ToMD5(model);
            DataSet ds = new DataSet();//定义DataSet对象
            ds = bll.GetList(model);//调用BLL层中的GetList方法，返还DataSet对象
            if(ds.Tables[0].Rows.Count>0)
            {
                HRManage frmHRManage = new HRManage();
                frmHRManage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或者密码输入错误！");
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
