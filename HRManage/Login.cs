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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BLL.UserInfo bll = new BLL.UserInfo(); //实例化BLL层          
            string userName = txtUserName.Text.Trim();
            string userPassword = txtUserPassword.Text.Trim();
            if (userName != "" && userPassword != "")
            {
                string strWhere = "UserName='" + userName + "' and UserPassword='" + userPassword + "'"; //给出查询语句条件
                Model.UserInfo model = new Model.UserInfo();//实例化Model层
                DataSet ds = new DataSet();//定义DataSet对象
                ds = bll.GetList(strWhere);//调用BLL层中的GetList方法，返还DataSet对象
                if (ds.Tables[0].Rows.Count == 1)//判断是否有查找到数据
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
            else
            {
                MessageBox.Show("用户名或者密码未输！");
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
