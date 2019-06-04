using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Check
    {
        #region Model
        private int _checkid;
        private string _employeeid;
        private string _employeename;
        private string _departmentname;
        private string _checkcontent;
        private string _checkresult;
        private string _checkpeople;
        private DateTime _checkdate;
        private string _remarks;
        /// <summary>
        /// 考核编号
        /// </summary>
        public int CheckID
        {
            set { _checkid = value; }
            get { return _checkid; }
        }
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
        /// 员工部门
        /// </summary>
        public string DepartmentName
        {
            set { _departmentname = value; }
            get { return _departmentname; }
        }
        /// <summary>
        /// 考核内容
        /// </summary>
        public string CheckContent
        {
            set { _checkcontent = value; }
            get { return _checkcontent; }
        }
        /// <summary>
        /// 考核结果
        /// </summary>
        public string CheckResult
        {
            set { _checkresult = value; }
            get { return _checkresult; }
        }
        /// <summary>
        /// 考核人
        /// </summary>
        public string CheckPeople
        {
            set { _checkpeople = value; }
            get { return _checkpeople; }
        }
        /// <summary>
        /// 考核日期
        /// </summary>
        public DateTime CheckDate
        {
            set { _checkdate = value; }
            get { return _checkdate; }
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
