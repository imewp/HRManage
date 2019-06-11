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
    public partial class EmployeeManage : Form
    {
        public EmployeeManage()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            string employeeID = txtEmployeeID.Text;
            string emplyeeName = txtEmployeeName.Text;
            string sex = cboSex.Text;
            DateTime birthday = DateTime.Parse(dtpBirthday.Text);
            string phone = txtPhone.Text;
            DateTime hireDate = DateTime.Parse(dtpHireDate.Text);
            string education = cboEducation.Text;
            int departmentID = int.Parse(txtDepartmentID.Text);
            string position = txtPosition.Text;
            string remarks = txtRemarks.Text;

            Model.Employee model = new Model.Employee();//实例化Model层
            model.EmployeeID = employeeID;
            model.EmployeeName = emplyeeName;
            model.Sex = sex;
            model.Birthday = birthday;
            model.Phone = phone;
            model.HireDate = hireDate;
            model.Education = education;
            model.DepartmentID = departmentID;
            model.Position = position;
            model.Remarks = remarks;

            BLL.Employee bll = new BLL.Employee();//实例化BLL层

            if (bll.Update(model) == true)//根据返回布尔值判断是否修改数据成功
            {
                MessageBox.Show("员工信息修改成功");
                DataBind();//刷新DataGridView数据
            }
            else
            {
                MessageBox.Show("员工信息修改失败");
            }
        }
        public void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.Employee bll = new BLL.Employee();//实例化BLL层
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            dgvEmployeeInfo.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源   
        }

        private void EmployeeManage_Load(object sender, EventArgs e)
        {
            DataBind();//窗体登录时绑定数据到DataGridView
        }

        private void dgvEmployeeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[0].Value.ToString();
            txtEmployeeName.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[1].Value.ToString();
            cboSex.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[2].Value.ToString();
            dtpBirthday.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[3].Value.ToString();
            txtPhone.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[4].Value.ToString();
            dtpHireDate.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[5].Value.ToString();
            cboEducation.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[6].Value.ToString();
            txtDepartmentID.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[7].Value.ToString();
            txtPosition.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[8].Value.ToString();
            txtRemarks.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[9].Value.ToString();   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string employeeID = txtEmployeeID.Text;
            BLL.Employee bll = new BLL.Employee();//实例化BLL层
            if (bll.Delete(employeeID) == true)//根据返回布尔值判断是否删除数据成功
            {
                MessageBox.Show("员工信息删除成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBind();//刷新DataGridView数据
            }
            else
            {
                MessageBox.Show("员工信息删除失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
