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
    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (txtEmployeeID.Text.Trim().Length == 0)
            {
                strErr += "员工编号不能为空！\\n";
            }
            if (txtEmployeeName.Text.Trim().Length == 0)
            {
                strErr += "员工姓名不能为空！\\n";
            }
            if (txtPhone.Text.Trim().Length == 0)
            {
                strErr += "Phone不能为空！\\n";
            }
            if (txtDepartmentID.Text.Trim().Length == 0)
            {
                strErr += "DepartmentID格式错误！\\n";
            }
            if (this.txtPosition.Text.Trim().Length == 0)
            {
                strErr += "职务不能为空！\\n";
            }
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            Model.Employee model = new Model.Employee();//实例化Model层
            model.EmployeeID = txtEmployeeID.Text;
            model.EmployeeName = txtEmployeeName.Text;
            model.Sex = cboSex.Text;
            model.Birthday = DateTime.Parse(dtpBirthday.Text);
            model.Phone = txtPhone.Text;
            model.HireDate = DateTime.Parse(dtpHireDate.Text);
            model.Education = cboEducation.Text;
            model.DepartmentID = int.Parse(txtDepartmentID.Text);
            model.Position = txtPosition.Text;
            model.Remarks = txtRemarks.Text;
            BLL.Employee bll = new BLL.Employee();//实例化BLL层
            if (bll.Add(model))//将员工信息添加到数据库中，根据返回值判断是否添加成功
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
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
            txtPhone.Text = "";
            txtDepartmentID.Text = "";
            txtPosition.Text = "";
            txtRemarks.Text = "";
            txtEmployeeName.Focus();
        }
    }
}
