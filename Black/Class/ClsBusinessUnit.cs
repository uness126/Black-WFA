using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black
{
    public class ClsBusinessUnit
    {
        private SqlConnection sqlConnection = new SqlConnection(ClsDataBase.ConnectionString);

        public void Insert(string Name)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                #region Query
                var cmdText = @"INSERT INTO [dbo].[BusinessUnit]
                                       ([Name],[UserId])
                                 VALUES
                                       (@Name,@UserId)";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.Transaction = sqlTransaction;
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
                SqlCom.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = ClsUtility.UserID;
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

        public void Update(Int32 businessUnitId, string Name)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                #region Query
                var cmdText = @"UPDATE [dbo].[BusinessUnit]
                                   SET [Name] = @Name
                                 WHERE BusinessUnitId = @BusinessUnitId";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.Transaction = sqlTransaction;
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@BusinessUnitId", SqlDbType.Int).Value = businessUnitId;
                SqlCom.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
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

        public void Delete(Int32 businessUnitId)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                #region Query
                var cmdText = @"DELETE FROM [dbo].[BusinessUnit] WHERE BusinessUnitId = @BusinessUnitId";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.Transaction = sqlTransaction;
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@BusinessUnitId", SqlDbType.Int).Value = businessUnitId;
                SqlCom.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                if (sqlTransaction != null)
                    sqlTransaction.Rollback();
                if (ex.Message.StartsWith("The DELETE statement conflicted with the REFERENCE constraint"))
                    throw new Exception("شرکت دارای گردش است امکان حذف وجود ندارد.");
                else
                    throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public DataTable SelectAllBusinessUnit()
        {
            SqlDataReader SqlDataReader;
            try
            {
                var cmdText = @"SELECT [BusinessUnitId]
                                        ,ROW_NUMBER() OVER(ORDER BY BusinessUnitId ASC) AS ROW_NUMBER
                                        ,[Name]
                                FROM [dbo].[BusinessUnit]";
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

        public DataTable SelectAllBusinessUnit(Int32 BusinessUnitId)
        {
            SqlDataReader SqlDataReader;
            try
            {
                var cmdText = @"SELECT [BusinessUnitId]
                                  ,[Name]
                              FROM [dbo].[BusinessUnit]
                              WHERE BusinessUnitId = @BusinessUnitId";
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCom.Parameters.Add("@BusinessUnitId", SqlDbType.Int).Value = BusinessUnitId;
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

        public DataTable SelectBusinessUnitList()
        {
            SqlDataReader SqlDataReader;
            try
            {
                var cmdText = @"SELECT 0 AS BusinessUnitId,N'--انتخاب کنید--' AS Name
                                UNION
                                SELECT [BusinessUnitId]
                                        ,[Name]
                                FROM [dbo].[BusinessUnit]";
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
    }
}
