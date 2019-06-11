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
    public partial class UserManage : Form
    {
        public UserManage()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
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

            string userName = txtUserName.Text;
            string userPassword = txtUserPassword.Text;
            string userType = cboUserType.Text;
            BLL.UserInfo bll = new BLL.UserInfo();//实例化BLL层
            Model.UserInfo model = new Model.UserInfo();//实例化Model层
            model.UserName = userName;
            model.UserPassword = userPassword;
            model.UserType = userType;

            if (txtUserName.Text != "" && txtUserPassword.Text != "" && cboUserType.Text != "")
            {
                if (bll.Update(model) == true)//根据返回布尔值判断是否修改数据成功
                {
                    MessageBox.Show("用户修改成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();//刷新DataGridView数据
                }
                else
                {
                    MessageBox.Show("用户修改失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请检查数据输入的正确性！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            BLL.UserInfo bll = new BLL.UserInfo();//实例化BLL层           
            if (bll.Delete(userName) == true)//根据返回布尔值判断是否删除数据成功
            {
                MessageBox.Show("用户删除成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBind();//刷新DataGridView数据
            }
            else
            {
                MessageBox.Show("用户删除失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.UserInfo bll = new BLL.UserInfo();//实例化BLL层
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            dgvUserInfo.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源   
        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            DataBind();//窗体登录时绑定数据到DataGridView
        }

        private void dgvUserInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = dgvUserInfo.CurrentCell.OwningRow.Cells[1].Value.ToString();
            txtUserPassword.Text = dgvUserInfo.CurrentCell.OwningRow.Cells[0].Value.ToString();
            cboUserType.Text = dgvUserInfo.CurrentCell.OwningRow.Cells[2].Value.ToString();
        }
    }
}
