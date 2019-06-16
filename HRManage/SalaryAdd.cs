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
    public partial class SalaryAdd : Form
    {
        public SalaryAdd()
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

            if (bll.Add(model) > 0)//将工资信息添加到数据库中，根据影响的行数判断是否添加成功
            {
                MessageBox.Show("数据添加成功");
            }
            else
            {
                MessageBox.Show("数据添加失败");
            }  
        }
        public void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.Employee bll = new BLL.Employee();//实例化BLL层
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            dgvEmployeeInfo.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源   
        }

        private void SalaryAdd_Load(object sender, EventArgs e)
        {
            DataBind();//窗体登录时绑定数据到DataGridView
        }

        private void dgvEmployeeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[0].Value.ToString();
            txtEmployeeName.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[1].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Text = "";
            txtBasicSalary.Text = "";
            txtPostSalary.Text = "";
            txtAllowance.Text = "";
            txtBouns.Text = "";
            txtOtherAdd.Text = "";
            txtOtherSubtract.Text = "";
            txtFinalPay.Text = "";
            txtTotalPay.Text = "";
            txtRemarks.Text = "";
        }
    }
}
