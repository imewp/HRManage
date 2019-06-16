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
    public partial class CheckAdd : Form
    {
        public CheckAdd()
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
            if (txtDepartmentName.Text.Trim().Length == 0)
            {
                strErr += "部门名称不能为空！\\n";
            }
            if (txtCheckContent.Text.Trim().Length == 0)
            {
                strErr += "考核内容不能为空！\\n";
            }
            if (txtCheckResult.Text.Trim().Length == 0)
            {
                strErr += "考核结果不能为空！\\n";
            }
            if (txtCheckPeople.Text.Trim().Length == 0)
            {
                strErr += "考核人不能为空！\\n";
            }
            if (dtpCheckDate.Text.Trim().Length == 0)
            {
                strErr += "考核日期不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            Model.Check model = new Model.Check();//实例化Model层
            model.EmployeeID = txtEmployeeID.Text;
            model.EmployeeName = txtEmployeeName.Text;
            model.DepartmentName = txtDepartmentName.Text;
            model.CheckContent = txtCheckContent.Text;
            model.CheckResult = txtCheckResult.Text;
            model.CheckPeople = txtCheckPeople.Text;
            model.CheckDate = DateTime.Parse(dtpCheckDate.Text);
            model.Remarks = txtRemarks.Text;

            BLL.Check bll = new BLL.Check();//实例化BLL层
            if (bll.Add(model) > 0)//将考核信息添加到数据库中，根据影响的行数判断是否添加成功
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
            BLL.Employee bll = new BLL.Employee();
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            dgvEmployeeInfo.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源   
        }

        private void CheckAdd_Load(object sender, EventArgs e)
        {
            DataBind();//窗体登录时绑定数据到DataGridView
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
            txtDepartmentName.Text = "";
            txtCheckContent.Text = "";
            txtCheckResult.Text = "";
            txtCheckPeople.Text = "";
            txtRemarks.Text = "";
        }

        private void dgvEmployeeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strWhere;
            txtEmployeeID.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[0].Value.ToString();
            txtEmployeeName.Text = dgvEmployeeInfo.CurrentCell.OwningRow.Cells[1].Value.ToString();
            int departmentID = int.Parse(dgvEmployeeInfo.CurrentCell.OwningRow.Cells[7].Value.ToString());
            BLL.Department bll = new BLL.Department();//实例化BLL层
            DataSet ds = new DataSet();
            strWhere = "DepartmentID=" + departmentID;//将部门ID作为条件
            ds = bll.GetList(strWhere);//根据条件获取部门信息
            txtDepartmentName.Text = ds.Tables[0].Rows[0][1].ToString();//根据部门ID查找部门名称
        }
    }
}
