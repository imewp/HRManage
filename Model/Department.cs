using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Department
    {
        #region Model
        private int _departmentid;
        private string _departmentname;
        private string _headofdepartment;
        private string _departmentphone;
        /// <summary>
        /// 部门编号
        /// </summary>
        public int DepartmentID
        {
            set { _departmentid = value; }
            get { return _departmentid; }
        }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName
        {
            set { _departmentname = value; }
            get { return _departmentname; }
        }
        /// <summary>
        /// 部门负责人
        /// </summary>
        public string HeadOfDepartment
        {
            set { _headofdepartment = value; }
            get { return _headofdepartment; }
        }
        /// <summary>
        /// 部门电话
        /// </summary>
        public string DepartmentPhone
        {
            set { _departmentphone = value; }
            get { return _departmentphone; }
        }
        #endregion Model
    }
}
