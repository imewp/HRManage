using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class Salary
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Salary model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Salary(");
            strSql.Append("EmployeeID,BasicSalary,PostSalary,Allowance,Bouns,OtherAdd,OtherSubtract,FinalPay,TotalPay,SalayMonth,Remarks)");
            strSql.Append(" values (");
            strSql.Append("@EmployeeID,@BasicSalary,@PostSalary,@Allowance,@Bouns,@OtherAdd,@OtherSubtract,@FinalPay,@TotalPay,@SalayMonth,@Remarks)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@BasicSalary", SqlDbType.Decimal,9),
					new SqlParameter("@PostSalary", SqlDbType.Decimal,9),
					new SqlParameter("@Allowance", SqlDbType.Decimal,9),
					new SqlParameter("@Bouns", SqlDbType.Decimal,9),
					new SqlParameter("@OtherAdd", SqlDbType.Decimal,9),
					new SqlParameter("@OtherSubtract", SqlDbType.Decimal,9),
					new SqlParameter("@FinalPay", SqlDbType.Decimal,9),
					new SqlParameter("@TotalPay", SqlDbType.Decimal,9),
					new SqlParameter("@SalayMonth", SqlDbType.NVarChar,50),
					new SqlParameter("@Remarks", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.EmployeeID;
            parameters[1].Value = model.BasicSalary;
            parameters[2].Value = model.PostSalary;
            parameters[3].Value = model.Allowance;
            parameters[4].Value = model.Bouns;
            parameters[5].Value = model.OtherAdd;
            parameters[6].Value = model.OtherSubtract;
            parameters[7].Value = model.FinalPay;
            parameters[8].Value = model.TotalPay;
            parameters[9].Value = model.SalayMonth;
            parameters[10].Value = model.Remarks;

            int rows = 0;
            rows = DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
                return rows;
            return rows;
   
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Salary model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Salary set ");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("BasicSalary=@BasicSalary,");
            strSql.Append("PostSalary=@PostSalary,");
            strSql.Append("Allowance=@Allowance,");
            strSql.Append("Bouns=@Bouns,");
            strSql.Append("OtherAdd=@OtherAdd,");
            strSql.Append("OtherSubtract=@OtherSubtract,");
            strSql.Append("FinalPay=@FinalPay,");
            strSql.Append("TotalPay=@TotalPay,");
            strSql.Append("SalayMonth=@SalayMonth,");
            strSql.Append("Remarks=@Remarks");
            strSql.Append(" where SalaryID=@SalaryID");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@BasicSalary", SqlDbType.Decimal,9),
					new SqlParameter("@PostSalary", SqlDbType.Decimal,9),
					new SqlParameter("@Allowance", SqlDbType.Decimal,9),
					new SqlParameter("@Bouns", SqlDbType.Decimal,9),
					new SqlParameter("@OtherAdd", SqlDbType.Decimal,9),
					new SqlParameter("@OtherSubtract", SqlDbType.Decimal,9),
					new SqlParameter("@FinalPay", SqlDbType.Decimal,9),
					new SqlParameter("@TotalPay", SqlDbType.Decimal,9),
					new SqlParameter("@SalayMonth", SqlDbType.NVarChar,50),
					new SqlParameter("@Remarks", SqlDbType.NVarChar,-1),
					new SqlParameter("@SalaryID", SqlDbType.Int,4)};
            parameters[0].Value = model.EmployeeID;
            parameters[1].Value = model.BasicSalary;
            parameters[2].Value = model.PostSalary;
            parameters[3].Value = model.Allowance;
            parameters[4].Value = model.Bouns;
            parameters[5].Value = model.OtherAdd;
            parameters[6].Value = model.OtherSubtract;
            parameters[7].Value = model.FinalPay;
            parameters[8].Value = model.TotalPay;
            parameters[9].Value = model.SalayMonth;
            parameters[10].Value = model.Remarks;
            parameters[11].Value = model.SalaryID;

            int rows = DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.Salary model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Salary ");
            strSql.Append(" where SalaryID=@SalaryID");
            SqlParameter[] parameters = {
					new SqlParameter("@SalaryID", SqlDbType.Int,4)
			};
            parameters[0].Value = model.SalaryID;

            int rows = DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SalaryID,EmployeeID,BasicSalary,PostSalary,Allowance,Bouns,OtherAdd,OtherSubtract,FinalPay,TotalPay,SalayMonth,Remarks ");
            strSql.Append(" FROM Salary ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }

        /// <summary>
        /// 获得数据列表，无参数
        /// </summary>
        public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SalaryID,EmployeeID,BasicSalary,PostSalary,Allowance,Bouns,OtherAdd,OtherSubtract,FinalPay,TotalPay,SalayMonth,Remarks ");
            strSql.Append(" FROM Salary ");
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
    }
}
