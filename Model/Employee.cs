using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Employee
    {
        #region Model
        private string _employeeid;
        private string _employeename;
        private string _sex;
        private DateTime _birthday;
        private string _phone;
        private DateTime _hiredate;
        private string _education;
        private int _departmentid;
        private string _position;
        private string _remarks;
        /// <summary>
        /// 员工编号
        /// </summary>
        public string EmployeeID
        {
            set { _employeeid = value; }
            get { return _employeeid; }
        }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EmployeeName
        {
            set { _employeename = value; }
            get { return _employeename; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 入职日期
        /// </summary>
        public DateTime HireDate
        {
            set { _hiredate = value; }
            get { return _hiredate; }
        }
        /// <summary>
        /// 学历
        /// </summary>
        public string Education
        {
            set { _education = value; }
            get { return _education; }
        }
        /// <summary>
        /// 部门编号
        /// </summary>
        public int DepartmentID
        {
            set { _departmentid = value; }
            get { return _departmentid; }
        }
        /// <summary>
        /// 职务
        /// </summary>
        public string Position
        {
            set { _position = value; }
            get { return _position; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks
        {
            set { _remarks = value; }
            get { return _remarks; }
        }
        #endregion Model
    }
}
