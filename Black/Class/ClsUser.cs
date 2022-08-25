using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Black
{
    public class ClsUser
    {
        private SqlConnection sqlConnection = new SqlConnection(ClsDataBase.ConnectionString);

        #region HASH_REFERENCES_CODE

        private string ComputeMD5Hash(string StrPlainText)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(StrPlainText);
            MD5CryptoServiceProvider MD5Hasher = new MD5CryptoServiceProvider();
            Byte[] hashedBytes = MD5Hasher.ComputeHash(inputBytes);
            String result = BitConverter.ToString(hashedBytes);
            return result.Replace("-", "");
        }

        #endregion

        public void Insert(string FirstName, string LastName, string UserName, string Password, Int32 RoleId)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                #region Query
                var cmdText = @"INSERT INTO [dbo].[User]
                                       ([FirstName]
                                       ,[LastName]
                                       ,[UserName]
                                       ,[Password]
		                               ,[RoleId]
		                               ,[Status])
                                 VALUES
                                       (@FirstName
                                       ,@LastName
                                       ,@UserName
                                       ,@Password
		                               ,@RoleId
		                               ,@Status)";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.Transaction = sqlTransaction;
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
                SqlCom.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
                SqlCom.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;
                SqlCom.Parameters.Add("@Password", SqlDbType.NVarChar).Value = ComputeMD5Hash(Password);
                SqlCom.Parameters.Add("@RoleId", SqlDbType.Int).Value = RoleId;
                SqlCom.Parameters.Add("@Status", SqlDbType.Bit).Value = true;
                SqlCom.ExecuteNonQuery();
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

        public void Update(Int32 UserId, string FirstName, string LastName, string UserName, string Password, Int32 RoleId, bool Status)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                #region Query
                var cmdText = @"UPDATE [dbo].[User]
                                SET [FirstName] = @FirstName
                                    ,[LastName] = @LastName
                                    ,[UserName] = @UserName
                                    ,[Password] = @Password
                                    ,[RoleId] = @RoleId
                                    ,[Status] = @Status
                                WHERE [UserId] = @UserId";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.Transaction = sqlTransaction;
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = UserId;
                SqlCom.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
                SqlCom.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
                SqlCom.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;
                SqlCom.Parameters.Add("@Password", SqlDbType.NVarChar).Value = ComputeMD5Hash(Password);
                SqlCom.Parameters.Add("@RoleId", SqlDbType.Int).Value = RoleId;
                SqlCom.Parameters.Add("@Status", SqlDbType.Bit).Value = Status;
                SqlCom.ExecuteNonQuery();
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

        public void Update(Int32 UserId, string FirstName, string LastName, string UserName, Int32 RoleId, bool Status)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                #region Query
                var cmdText = @"UPDATE [dbo].[User]
                                SET [FirstName] = @FirstName
                                    ,[LastName] = @LastName
                                    ,[UserName] = @UserName
                                    ,[RoleId] = @RoleId
                                    ,[Status] = @Status
                                WHERE [UserId] = @UserId";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.Transaction = sqlTransaction;
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = UserId;
                SqlCom.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
                SqlCom.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
                SqlCom.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;
                SqlCom.Parameters.Add("@RoleId", SqlDbType.Int).Value = RoleId;
                SqlCom.Parameters.Add("@Status", SqlDbType.Bit).Value = Status;
                SqlCom.ExecuteNonQuery();
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

        public void UpdatePassword(Guid rowguid, string Password)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                #region Query
                var cmdText = @"UPDATE [dbo].[User]
                                SET [Password] = @Password
                                WHERE [rowguid] = @rowguid AND [Password] IS NULL";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.Transaction = sqlTransaction;
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@rowguid", SqlDbType.UniqueIdentifier).Value = rowguid;
                SqlCom.Parameters.Add("@Password", SqlDbType.NVarChar).Value = ComputeMD5Hash(Password);
                SqlCom.ExecuteNonQuery();
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

        public void Delete(Int32 UserId)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                #region Query
                var cmdText = @"UPDATE [dbo].[User]
                                SET [Status] = @Status
                                WHERE [UserId] = @UserId";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.Transaction = sqlTransaction;
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;
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

        public Int32 CheckedUserName(string UserName)
        {
            try
            {
                #region Query
                var cmdText = @"SELECT [UserId]
                                FROM [dbo].[User]
                                WHERE LOWER(UserName) = @UserName";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName.ToLower();
                var obj = SqlCom.ExecuteScalar();
                if (obj != null)
                    return Convert.ToInt32(obj);
                else
                    return -1;
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

        public DataTable CheckedLoginUsers(string UserName, string Password)
        {
            SqlDataReader SqlDataReader;
            try
            {
                #region Query
                var cmdText = @"SELECT [UserId]
                                       ,[FirstName]
                                       ,[LastName]
                                       ,[UserName]
                                       ,ISNULL([User].[RoleId],-1) RoleId
									   ,RoleType
                                       ,[User].rowguid
                                FROM [dbo].[User]
								JOIN [dbo].[Roles] ON [User].RoleId = [Roles].RoleId
                                WHERE LOWER(RTRIM(LTRIM(UserName))) = @UserName AND LOWER(RTRIM(LTRIM([Password]))) = @Password";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName.Trim().ToLower();
                SqlCom.Parameters.Add("@Password", SqlDbType.NVarChar).Value = ComputeMD5Hash(Password.Trim()).ToLower();
                SqlDataReader = SqlCom.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(SqlDataReader);
                SqlDataReader.Close();
                return dataTable;
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

        public DataTable SelectAllUsers(bool Status)
        {
            SqlDataReader SqlDataReader;
            try
            {
                var cmdText = @"SELECT [UserId]
	                            ,ROW_NUMBER() OVER(ORDER BY UserId ASC) [ROW_NUMBER]
                                  ,[FirstName]
                                  ,[LastName]
                                  ,[UserName]
	                              ,[RoleId]
	                              ,[Status]
                              FROM [dbo].[User]
                              WHERE [Status] = @Status";
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCom.Parameters.Add("@Status", SqlDbType.Bit).Value = Status;
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
    }
}
