using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Black
{
    public class ClsSetting
    {
        private SqlConnection sqlConnection = new SqlConnection(ClsDataBase.ConnectionString);

        /// <summary>
        /// دریافت گروهی تنظیمات
        /// </summary>
        /// <param name="SET_KEY">آرایه ای از پارامتر های تنظیمات به صورت رشته</param>
        /// <returns>خروجی به صورت جدول با مقدار پارامترها</returns>
        public DataTable SelectKeys(params string[] SET_KEY)
        {
            DataTable dataTable = new DataTable();
            try
            {
                string key = string.Empty;
                foreach (var item in SET_KEY)
                {
                    key += item;
                    key += ",";
                }
                key = key.TrimEnd(',');
                var cmdText = @"SELECT PivotTable.*
                                FROM
                                (SELECT [Key],Value
                                FROM Setting
                                ) AS TBL
                                PIVOT
                                 (
                                 MAX(TBL.Value)
                                 FOR TBL.[Key] in ({0})
                                 ) AS PivotTable ";
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCommand SqlCom = new SqlCommand(string.Format(cmdText, key), sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                var SqlDataReader = SqlCom.ExecuteReader();
                dataTable.Load(SqlDataReader);
                SqlDataReader.Close();
                return dataTable;
            }
            catch (SqlException e)
            {
                e.WriteLOG();
                throw new Exception("خطا در اتصال به دیتابیس.");
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// ویرایش تنظیمات تکی
        /// </summary>
        /// <param name="SET_KEY">نام پارامتر</param>
        /// <param name="SET_VALUE">مقدار پارامتر</param>
        public void Update(string SET_KEY, string SET_VALUE)
        {
            try
            {
                var cmdText = @"UPDATE [dbo].[Setting]
                                SET [VALUE] = @VALUE
                                WHERE [KEY] = @KEY";
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@VALUE", SqlDbType.NVarChar).Value = SET_VALUE;
                SqlCom.Parameters.Add("@KEY", SqlDbType.NVarChar).Value = SET_KEY;
                var res = SqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
