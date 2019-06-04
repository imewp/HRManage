using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Salary
    {
        #region Model
        private int _salaryid;
        private string _employeeid;
        private decimal _basicsalary;
        private decimal _postsalary;
        private decimal _allowance;
        private decimal _bouns;
        private decimal _otheradd;
        private decimal _othersubtract;
        private decimal _finalpay;
        private decimal _totalpay;
        private string _salaymonth;
        private string _remarks;
        /// <summary>
        /// 工资编号
        /// </summary>
        public int SalaryID
        {
            set { _salaryid = value; }
            get { return _salaryid; }
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
        /// 基本工资
        /// </summary>
        public decimal BasicSalary
        {
            set { _basicsalary = value; }
            get { return _basicsalary; }
        }
        /// <summary>
        /// 岗位工资
        /// </summary>
        public decimal PostSalary
        {
            set { _postsalary = value; }
            get { return _postsalary; }
        }
        /// <summary>
        /// 补贴
        /// </summary>
        public decimal Allowance
        {
            set { _allowance = value; }
            get { return _allowance; }
        }
        /// <summary>
        /// 奖金
        /// </summary>
        public decimal Bouns
        {
            set { _bouns = value; }
            get { return _bouns; }
        }
        /// <summary>
        /// 其他加
        /// </summary>
        public decimal OtherAdd
        {
            set { _otheradd = value; }
            get { return _otheradd; }
        }
        /// <summary>
        /// 其他扣
        /// </summary>
        public decimal OtherSubtract
        {
            set { _othersubtract = value; }
            get { return _othersubtract; }
        }
        /// <summary>
        /// 实发工资
        /// </summary>
        public decimal FinalPay
        {
            set { _finalpay = value; }
            get { return _finalpay; }
        }
        /// <summary>
        /// 应得工资
        /// </summary>
        public decimal TotalPay
        {
            set { _totalpay = value; }
            get { return _totalpay; }
        }
        /// <summary>
        /// 发放日期
        /// </summary>
        public string SalayMonth
        {
            set { _salaymonth = value; }
            get { return _salaymonth; }
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
