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
    public partial class HRManage : Form
    {
        public HRManage()
        {
            InitializeComponent();
        }

        private void 添加员工AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAdd frmEmployeeAdd = new EmployeeAdd();
            frmEmployeeAdd.MdiParent = this;
            frmEmployeeAdd.Show();
        }

        private void 管理员工MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeManage frmEmployeeManage = new EmployeeManage();
            frmEmployeeManage.MdiParent = this;
            frmEmployeeManage.Show();
        }

        private void 退出系统XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 添加工资AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryAdd frmSalaryAdd = new SalaryAdd();
            frmSalaryAdd.MdiParent = this;
            frmSalaryAdd.Show();
        }

        private void 管理工资MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryManage frmSalaryManage = new SalaryManage();
            frmSalaryManage.MdiParent = this;
            frmSalaryManage.Show();
        }

        private void 添加考核AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAdd frmCheckAdd = new CheckAdd();
            frmCheckAdd.MdiParent = this;
            frmCheckAdd.Show();
        }

        private void 管理考核MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckManage frmCheckManage = new CheckManage();
            frmCheckManage.MdiParent = this;
            frmCheckManage.Show();
        }

        private void 员工查询EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmploySearch frmEmploySearch = new EmploySearch();
            frmEmploySearch.MdiParent = this;
            frmEmploySearch.Show();
        }

        private void 考核查询CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckSearch frmCheckSearch = new CheckSearch();
            frmCheckSearch.MdiParent = this;
            frmCheckSearch.Show();
        }

        private void 添加部门AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentAdd frmDepartmentAdd = new DepartmentAdd();
            frmDepartmentAdd.MdiParent = this;
            frmDepartmentAdd.Show();
        }

        private void 管理部门MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentManage frmDepartmentManage = new DepartmentManage();
            frmDepartmentManage.MdiParent = this;
            frmDepartmentManage.Show();
        }

        private void 添加用户AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAdd frmUserAdd = new UserAdd();
            frmUserAdd.MdiParent = this;
            frmUserAdd.Show();
        }

        private void 管理用户MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManage frmUserManage = new UserManage();
            frmUserManage.MdiParent = this;
            frmUserManage.Show();
        }


    }
}
