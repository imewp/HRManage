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
    public partial class DepartmentAdd : Form
    {
        public DepartmentAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.Department model = new Model.Department();//实例化Model层
            model.DepartmentName = txtDepartmentName.Text.Trim();
            model.HeadOfDepartment = txtHeadOfDepartment.Text.Trim();
            model.DepartmentPhone = txtDepartmentPhone.Text.Trim();
            BLL.Department bll = new BLL.Department();//实例化BLL层
            if (bll.Add(model) > 0)
                MessageBox.Show("数据添加成功");
            else
                MessageBox.Show("数据添加失败");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDepartmentName.Text = "";
            txtHeadOfDepartment.Text = "";
            txtDepartmentPhone.Text = "";
            txtDepartmentName.Focus();
        }


    }
}
