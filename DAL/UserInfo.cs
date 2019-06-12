using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserInfo
    {
        /// <summary>
        /// 增加一条语句
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(Model.UserInfo userInfo)
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@UserName",SqlDbType.NVarChar,50),
                                          new SqlParameter("@UserPassword",SqlDbType.NVarChar,50),
                                          new SqlParameter("@UserType",SqlDbType.NVarChar,50)
                                      };
            parameters[0].Value = userInfo.UserName;
            parameters[1].Value = userInfo.UserPassword;
            parameters[2].Value = userInfo.UserType;
            int result = 0;
            bool re = false;
            result = DAL.DBHelper.ExecuteSql("Pro_UserInsert", CommandType.StoredProcedure, parameters);
            if (result > 0)
                re = true;
            return re;
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.UserInfo userInfo)
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@UserName",SqlDbType.NVarChar,50),
                                          new SqlParameter("@UserPassword",SqlDbType.NVarChar,50),
                                          new SqlParameter("@UserType",SqlDbType.NVarChar,50)
                                      };
            parameters[0].Value = userInfo.UserName;
            parameters[1].Value = userInfo.UserPassword;
            parameters[2].Value = userInfo.UserType;
            int result = 0;
            bool re = false;
            result = DAL.DBHelper.ExecuteSql("Pro_UserUpdate", CommandType.StoredProcedure, parameters);
            if (result > 0)
                re = true;
            return re;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.UserInfo userInfo)
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@UserName",SqlDbType.NVarChar,50)
                                      };
            parameters[0].Value = userInfo.UserName;
            int result = 0;
            bool re = false;
            result = DAL.DBHelper.ExecuteSql("Pro_UserDelete", CommandType.StoredProcedure, parameters);
            if (result > 0)
                re = true;
            return re;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(Model.UserInfo userInfo)
        {
            SqlParameter[] parameters ={
                                            new SqlParameter("@UserName",SqlDbType.NVarChar,50),
                                            new SqlParameter("@UserPassword",SqlDbType.NVarChar,50)
                                        };
            parameters[0].Value=userInfo.UserName;
            parameters[1].Value=userInfo.UserPassword;
            return DAL.DBHelper.SelectToDS("Pro_UserSelectByUserName", CommandType.StoredProcedure, parameters);
        }

        /// <summary>
        /// 获得数据列表，无参数
        /// </summary>
        public DataSet GetList()
        {
            return DAL.DBHelper.SelectToDS("Pro_UserSelectAll", CommandType.StoredProcedure);
        }
    }
}
