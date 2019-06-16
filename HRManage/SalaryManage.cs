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
    public partial class SalaryManage : Form
    {
        public SalaryManage()
        {
            InitializeComponent();
        }
        int salaryID;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (txtEmployeeID.Text.Trim().Length == 0)
            {
                strErr += "员工编号不能为空！\\n";
            }
            if (txtBasicSalary.Text.Trim().Length == 0)
            {
                strErr += "基本工资不能为空！\\n";
            }
            if (txtPostSalary.Text.Trim().Length == 0)
            {
                strErr += "岗位工资不能为空！\\n";
            }
            if (txtFinalPay.Text.Trim().Length == 0)
            {
                strErr += "实发工资不能为空！\\n";
            }
            if (txtTotalPay.Text.Trim().Length == 0)
            {
                strErr += "应得工资不能为空！\\n";
            }
            if (dtpSalayMonth.Text.Trim().Length == 0)
            {
                strErr += "发放日期不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            Model.Salary model = new Model.Salary();//实例化Model层
            model.SalaryID = salaryID;//salaryID值从dgvSalaryInfo的CellClick事件取得
            model.EmployeeID = txtEmployeeID.Text;
            model.BasicSalary = decimal.Parse(txtBasicSalary.Text);
            model.PostSalary = decimal.Parse(txtPostSalary.Text);
            model.Allowance = decimal.Parse(txtAllowance.Text);
            model.Bouns = decimal.Parse(txtBouns.Text);
            model.OtherAdd = decimal.Parse(txtOtherAdd.Text);
            model.OtherSubtract = decimal.Parse(txtOtherSubtract.Text);
            model.FinalPay = decimal.Parse(txtFinalPay.Text);
            model.TotalPay = decimal.Parse(txtTotalPay.Text);
            model.SalayMonth = dtpSalayMonth.Text;
            model.Remarks = txtRemarks.Text;

            BLL.Salary bll = new BLL.Salary();//实例化BLL层
            if (bll.Update(model))//根据返回布尔值判断是否修改数据成功
            {
                MessageBox.Show("工资信息修改成功");
                DataBind();//刷新DataGridView数据
            }
            else
            {
                MessageBox.Show("工资信息修改失败");
            }  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Model.Salary model = new Model.Salary();//实例化Model层
            model.SalaryID = salaryID;//salaryID值从dgvSalaryInfo的CellClick事件取得
            BLL.Salary bll = new BLL.Salary();//实例化BLL层
            if (bll.Delete(model))//根据返回布尔值判断是否删除数据成功
            {
                MessageBox.Show("工资信息删除成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBind();//刷新DataGridView数据
            }
            else
            {
                MessageBox.Show("工资信息删除失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.Salary bll = new BLL.Salary();//实例化BLL层
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            dgvSalaryInfo.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源   
        }

        private void SalaryManage_Load(object sender, EventArgs e)
        {
            DataBind();//窗体登录时绑定数据到DataGridView
        }

        private void dgvSalaryInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            salaryID = int.Parse(dgvSalaryInfo.CurrentCell.OwningRow.Cells[0].Value.ToString());//获取工资编号
            txtEmployeeID.Text = dgvSalaryInfo.CurrentCell.OwningRow.Cells[1].Value.ToString();
            txtBasicSalary.Text = dgvSalaryInfo.CurrentCell.OwningRow.Cells[2].Value.ToString();
            txtPostSalary.Text = dgvSalaryInfo.CurrentCell.OwningRow.Cells[3].Value.ToString();
            txtAllowance.Text = dgvSalaryInfo.CurrentCell.OwningRow.Cells[4].Value.ToString();
            txtBouns.Text = dgvSalaryInfo.CurrentCell.OwningRow.Cells[5].Value.ToString();
            txtOtherAdd.Text = dgvSalaryInfo.CurrentCell.OwningRow.Cells[6].Value.ToString();
            txtOtherSubtract.Text = dgvSalaryInfo.CurrentCell.OwningRow.Cells[7].Value.ToString();
            txtFinalPay.Text = dgvSalaryInfo.CurrentCell.OwningRow.Cells[8].Value.ToString();
            txtTotalPay.Text = dgvSalaryInfo.CurrentCell.OwningRow.Cells[9].Value.ToString();
            dtpSalayMonth.Text = dgvSalaryInfo.CurrentCell.OwningRow.Cells[10].Value.ToString();
            txtRemarks.Text = dgvSalaryInfo.CurrentCell.OwningRow.Cells[11].Value.ToString();
        }
    }
}
