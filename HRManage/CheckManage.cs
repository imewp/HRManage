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
    public partial class CheckManage : Form
    {
        public CheckManage()
        {
            InitializeComponent();
        }
        int checkID;
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
            model.CheckID = checkID;//checkID值从dgvCheckInfo的CellClick事件取得
            model.EmployeeID = txtEmployeeID.Text;
            model.EmployeeName = txtEmployeeName.Text;
            model.DepartmentName = txtDepartmentName.Text;
            model.CheckContent = txtCheckContent.Text;
            model.CheckResult = txtCheckResult.Text;
            model.CheckPeople = txtCheckPeople.Text;
            model.CheckDate = DateTime.Parse(dtpCheckDate.Text);
            model.Remarks = txtRemarks.Text;

            BLL.Check bll = new BLL.Check();//实例化BLL层
            if (bll.Update(model))//根据返回布尔值判断是否修改数据成功
            {
                MessageBox.Show("考核信息修改成功");
                DataBind();//刷新DataGridView数据
            }
            else
            {
                MessageBox.Show("考核信息修改失败");
            }  

        }
        public void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.Check bll = new BLL.Check();//实例化BLL层
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            dgvCheckInfo.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源   
        }

        private void CheckManage_Load(object sender, EventArgs e)
        {
            DataBind();//窗体登录时绑定数据到DataGridView
        }

        private void dgvCheckInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkID = int.Parse(dgvCheckInfo.CurrentCell.OwningRow.Cells[0].Value.ToString());//获取考核编号
            txtEmployeeID.Text = dgvCheckInfo.CurrentCell.OwningRow.Cells[1].Value.ToString();
            txtEmployeeName.Text = dgvCheckInfo.CurrentCell.OwningRow.Cells[2].Value.ToString();
            txtDepartmentName.Text = dgvCheckInfo.CurrentCell.OwningRow.Cells[3].Value.ToString();
            txtCheckContent.Text = dgvCheckInfo.CurrentCell.OwningRow.Cells[4].Value.ToString();
            txtCheckResult.Text = dgvCheckInfo.CurrentCell.OwningRow.Cells[5].Value.ToString();
            txtCheckPeople.Text = dgvCheckInfo.CurrentCell.OwningRow.Cells[6].Value.ToString();
            dtpCheckDate.Text = dgvCheckInfo.CurrentCell.OwningRow.Cells[7].Value.ToString();
            txtRemarks.Text = dgvCheckInfo.CurrentCell.OwningRow.Cells[8].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Model.Check model = new Model.Check();//实例化Model层
            model.CheckID = checkID;//checkID值从dgvCheckInfo的CellClick事件取得
            BLL.Check bll = new BLL.Check();//实例化BLL层
            if (bll.Delete(model))//根据返回布尔值判断是否删除数据成功
            {
                MessageBox.Show("考核信息删除成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBind();//刷新DataGridView数据
            }
            else
            {
                MessageBox.Show("考核信息删除失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
