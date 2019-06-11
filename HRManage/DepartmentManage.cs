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
    public partial class DepartmentManage : Form
    {
        public DepartmentManage()
        {
            InitializeComponent();
        }
        int departmentID;//定义部门编号
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string departmentName = txtDepartmentName.Text.Trim();
            string headOfDepartment = txtHeadOfDepartment.Text.Trim();
            string departmentPhone = txtDepartmentPhone.Text.Trim();
            BLL.Department bll = new BLL.Department();//实例化BLL层
            Model.Department model = new Model.Department();//实例化Model层
            model.DepartmentID = departmentID;//departmentID值从dgvDepartmentInfo的CellClick事件取得
            model.DepartmentName = departmentName;
            model.HeadOfDepartment = headOfDepartment;
            model.DepartmentPhone = departmentPhone;

            if (departmentName != "" && headOfDepartment != "" && departmentPhone != "")
            {
                if (bll.Update(model) == true)//根据返回布尔值判断是否修改数据成功
                {
                    MessageBox.Show("部门信息修改成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();//刷新DataGridView数据
                }
                else
                {
                    MessageBox.Show("部门信息修改失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请检查数据输入的正确性！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            BLL.Department bll = new BLL.Department();//实例化BLL层
            if (bll.Delete(departmentID) == true)//根据返回布尔值判断是否删除数据成功
            {
                MessageBox.Show("部门信息删除成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBind();//刷新DataGridView数据
            }
            else
            {
                MessageBox.Show("部门信息删除失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.Department bll = new BLL.Department();//实例化BLL层
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            dgvDepartmentInfo.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源   
        }

        private void DepartmentManage_Load(object sender, EventArgs e)
        {
            DataBind();//窗体登录时绑定数据到DataGridView
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            departmentID = int.Parse(dgvDepartmentInfo.CurrentCell.OwningRow.Cells[0].Value.ToString());//获取部门编号
            txtDepartmentName.Text = dgvDepartmentInfo.CurrentCell.OwningRow.Cells[1].Value.ToString();
            txtHeadOfDepartment.Text = dgvDepartmentInfo.CurrentCell.OwningRow.Cells[2].Value.ToString();
            txtDepartmentPhone.Text = dgvDepartmentInfo.CurrentCell.OwningRow.Cells[3].Value.ToString();
        }
    }
}
