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
    public partial class EmploySearch : Form
    {
        public EmploySearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strWhere = "1=1";
            string employeeID = txtEmployeeID.Text.Trim();
            string employeeName = txtEmployeeName.Text.Trim();
            if (employeeID != "")//判断员工编号是否为空
            {
                strWhere = strWhere + " and EmployeeID like '" + employeeID + "'";
            }
            if (employeeName != "")//判断员工姓名是否为空
            {
                strWhere = strWhere + " and EmployeeName like '" + employeeName + "'";
            }
            BLL.Employee bll = new BLL.Employee(); //实例化BLL层          
            DataSet ds = new DataSet();
            ds = bll.GetList(strWhere);//执行带参数SQL语句，将结果存在ds中
            dgvEmployeeInfo.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源
        }
    }
}
