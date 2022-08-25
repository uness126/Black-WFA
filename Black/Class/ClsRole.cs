using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Black
{
    public class ClsRole
    {
        private SqlConnection sqlConnection = new SqlConnection(ClsDataBase.ConnectionString);

        public static bool ShowPassword { get; set; }
        public DataTable SelectRoles()
        {
            SqlDataReader SqlDataReader;
            try
            {
                var cmdText = @"SELECT [RoleId]
	                                    ,ROW_NUMBER() OVER(ORDER BY RoleId ASC) [ROW_NUMBER]
                                        ,[RoleName]
                                        ,[ShowPassword]
                                        ,[rowguid]
                              FROM [dbo].[Roles]";
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlDataReader = SqlCom.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(SqlDataReader);
                SqlDataReader.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                ClsCommon.WriteLOG(ex);
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public DataTable SelectRolesById(Int32 RoleId)
        {
            SqlDataReader SqlDataReader;
            try
            {
                var cmdText = @"SELECT [RoleId]
                                  ,[RoleName]
                                  ,[RoleType]
                                  ,[ShowPassword]
                                  ,[rowguid]
                              FROM [dbo].[Roles]
                            WHERE [RoleId] = @RoleId";
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCom.Parameters.Add("@RoleId", SqlDbType.Int).Value = RoleId;
                SqlDataReader = SqlCom.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(SqlDataReader);
                SqlDataReader.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                ClsCommon.WriteLOG(ex);
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void Update(Int32 RoleId, bool ShowPassword, Guid rowguid)
        {
            //if (rowguid == Guid.Parse("58E49343-BF5F-4455-888D-3231AD076A55")) return;
            SqlTransaction sqlTransaction = null;
            try
            {
                #region Query
                var cmdText = @"UPDATE [dbo].[Roles]
                                   SET [ShowPassword] = @ShowPassword
                                 WHERE RoleId = @RoleId";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.Transaction = sqlTransaction;
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@RoleId", SqlDbType.Int).Value = RoleId;
                SqlCom.Parameters.Add("@ShowPassword", SqlDbType.Bit).Value = ShowPassword;
                SqlCom.ExecuteNonQuery();
                var ID = SqlCom.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                if (sqlTransaction != null)
                    sqlTransaction.Rollback();
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
