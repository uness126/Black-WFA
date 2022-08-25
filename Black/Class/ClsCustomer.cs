using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Black
{
    public class ClsCustomer
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

        public Int32 Insert(Int32 BusinessUnitId, string FirstName, string LastName, string Mobile, string AccountCode, string NationalId, string Password, System.Drawing.Image Barcode)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                #region Query
                var cmdText = @"INSERT INTO [dbo].[Customer]
                                       ([BusinessUnitId]
                                       ,[FirstName]
                                       ,[LastName]
                                       ,[Mobile]
                                       ,[AccountCode]
                                       ,[NationalId]
                                       ,[Password]
                                       ,[Barcode]
                                       ,[UserId])
                                 VALUES
                                       (@BusinessUnitId
                                       ,@FirstName
                                       ,@LastName
                                       ,@Mobile
                                       ,@AccountCode
                                       ,@NationalId
                                       ,@Password
                                       ,@Barcode
                                       ,@UserId)";
                #endregion
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);                
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@BusinessUnitId", SqlDbType.Int).Value = BusinessUnitId;
                SqlCom.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
                SqlCom.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
                SqlCom.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = Mobile;
                SqlCom.Parameters.Add("@AccountCode", SqlDbType.NVarChar).Value = AccountCode;
                SqlCom.Parameters.Add("@NationalId", SqlDbType.NVarChar).Value = NationalId;
                SqlCom.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
                SqlCom.Parameters.Add("@Barcode", SqlDbType.NVarChar).Value = ClsCommon.ReadImage();
                SqlCom.Parameters.Add("@UserId", SqlDbType.Int).Value = ClsUtility.UserID;
                if (CheckNationalId(NationalId) > 0)
                    throw new Exception("کد ملی تکراری است.");
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                SqlCom.Transaction = sqlTransaction;
                SqlCom.ExecuteNonQuery();
                SqlCom.CommandText = "SELECT max(CustomerId) FROM Customer";
                SqlCom.Transaction = sqlTransaction;
                var ID = SqlCom.ExecuteScalar();
                sqlTransaction.Commit();
                if (ID != null)
                    return Convert.ToInt32(ID);
                else return -1;
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

        public void Update(Int32 CustomerId, Int32 BusinessUnitId, string FirstName, string LastName, string Mobile, string AccountCode, string NationalId, string Password, System.Drawing.Image Barcode)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                #region Query
                var cmdText = @"UPDATE [dbo].[Customer]
                                   SET [BusinessUnitId] = @BusinessUnitId
                                      ,[FirstName] = @FirstName
                                      ,[LastName] = @LastName
                                      ,[Mobile] = @Mobile
                                      ,[AccountCode] = @AccountCode
                                      ,[NationalId] = @NationalId
                                      ,[Password] = ISNULL(@Password, Password)
                                      ,[Barcode] = ISNULL(@Barcode, Barcode)
                                 WHERE CustomerId = @CustomerId";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.Transaction = sqlTransaction;
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId;
                SqlCom.Parameters.Add("@BusinessUnitId", SqlDbType.Int).Value = BusinessUnitId;
                SqlCom.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
                SqlCom.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
                SqlCom.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = Mobile;
                SqlCom.Parameters.Add("@AccountCode", SqlDbType.NVarChar).Value = AccountCode;
                SqlCom.Parameters.Add("@NationalId", SqlDbType.NVarChar).Value = NationalId;
                SqlCom.Parameters.Add("@Password", SqlDbType.NVarChar).Value = (object)Password ?? DBNull.Value;
                SqlCom.Parameters.Add("@Barcode", SqlDbType.NVarChar).Value = ClsCommon.ReadImage();
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

        public void Delete(Int32 CustomerId)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                #region Querys
                var Select = @"SELECT [Customer].CustomerId 
                                FROM [dbo].[Customer]
                                LEFT JOIN [dbo].[Transaction] ON [Customer].CustomerId = [Transaction].CustomerId
                                WHERE [Transaction].[State] IS NOT NULL AND [Transaction].[State] = 1 AND  [Customer].CustomerId = @CustomerId";

                var cmdDelete = @"DELETE FROM [dbo].[Transaction]
                                    WHERE CustomerId = @CustomerId
                                DELETE FROM [dbo].[Customer]
                                    WHERE CustomerId = @CustomerId";
                #endregion
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();

                SqlCommand SqlCom = new SqlCommand(Select, sqlConnection);
                SqlCom.Transaction = sqlTransaction;
                SqlCom.CommandType = CommandType.Text;
                SqlCom.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId;
                var obj = SqlCom.ExecuteScalar();
                if (obj != null && obj != DBNull.Value)
                {
                    throw new Exception("مشترک دارای تراکنش است امکان حذف وجود ندارد.");
                }
                SqlCom.Parameters.Clear();
                SqlCom.CommandText = cmdDelete;
                SqlCom.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId;
                SqlCom.Transaction = sqlTransaction;
                var ID = SqlCom.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                if (sqlTransaction != null)
                    sqlTransaction.Rollback();
                if (ex.Message.StartsWith("The DELETE statement conflicted with the REFERENCE constraint"))
                    throw new Exception("مشترک دارای تراکنش است امکان حذف وجود ندارد.");
                else
                    throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public DataTable SelectAllCustomer()
        {
            SqlDataReader SqlDataReader;
            try
            {
                var cmdText = @"SELECT TBL.CustomerId
                                ,ROW_NUMBER() OVER(ORDER BY TBL.CustomerId ASC) [ROW_NUMBER]
                                ,TBL.BusinessUnitId
                                ,TBL.BusinessUnitName
                                ,TBL.FirstName
                                ,TBL.LastName
                                ,TBL.Mobile
                                ,TBL.AccountCode
                                ,TBL.NationalId
                                ,CASE '" + ClsRole.ShowPassword.ToString().ToLower() + @"' WHEN 'true' THEN TBL.Password ELSE '*****' END Password
                                ,TBL.Password P
                                ,SUM(TBL.TotalCredit) TotalCredit
                                ,SUM(TBL.CreditUsed)*(-1) CreditUsed
                                ,SUM(TBL.TotalCredit)+SUM(TBL.CreditUsed) CreditRemain
                                FROM
                                (SELECT [Customer].[CustomerId]
                                      ,[Customer].[BusinessUnitId]
	                                  ,[BusinessUnit].Name BusinessUnitName
                                      ,[FirstName]
                                      ,[LastName]
                                      ,[Mobile]
                                      ,[AccountCode]
                                      ,[NationalId]
                                      ,[Customer].[Password]
                                      ,CASE ISNULL([Transaction].[State],1) WHEN 1 THEN 
									  CASE [Transaction].[Type] WHEN 'POS' THEN SUM([Transaction].[Amount]) ELSE 0 END
									  ELSE 0 END TotalCredit
                                      ,CASE ISNULL([Transaction].[State],1) WHEN 1 THEN
									  CASE [Transaction].[Type] WHEN 'NEG' THEN SUM([Transaction].[Amount]) ELSE 0 END
									  ELSE 0 END CreditUsed
	                                  ,0 CreditRemain
									  ,[Transaction].[State]
                                  FROM [dbo].[Customer]
                                  JOIN [dbo].[BusinessUnit] ON [Customer].BusinessUnitId = [BusinessUnit].BusinessUnitId
                                  LEFT JOIN [dbo].[Transaction] ON [Customer].CustomerId = [Transaction].CustomerId
                                  GROUP BY Customer.CustomerId,Customer.CreateOn,Customer.BusinessUnitId,BusinessUnit.Name,Customer.FirstName,Customer.LastName,
                                  Customer.Mobile,Customer.AccountCode,Customer.NationalId,Customer.Password,[Transaction].[Type]
								  ,[Transaction].[State]) AS TBL
                                  GROUP BY TBL.CustomerId,TBL.BusinessUnitId,TBL.BusinessUnitName,TBL.FirstName,TBL.LastName,TBL.Mobile,TBL.AccountCode,TBL.NationalId,TBL.Password";
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

        public DataTable SelectCustomerById(Int32 CustomerId)
        {
            SqlDataReader SqlDataReader;
            try
            {
                var cmdText = @"SELECT TBL.CustomerId
                                ,ROW_NUMBER() OVER(ORDER BY TBL.CustomerId ASC) [ROW_NUMBER]
                                ,TBL.BusinessUnitId
                                ,TBL.BusinessUnitName
                                ,TBL.FirstName
                                ,TBL.LastName
                                ,TBL.Mobile
                                ,TBL.AccountCode
                                ,TBL.NationalId
                                ,TBL.Password
                                ,SUM(TBL.TotalCredit) TotalCredit
                                ,SUM(TBL.CreditUsed)*(-1) CreditUsed
                                ,SUM(TBL.TotalCredit)+SUM(TBL.CreditUsed) CreditRemain
                                FROM
                                (SELECT [Customer].[CustomerId]
                                      ,[Customer].[BusinessUnitId]
	                                  ,[BusinessUnit].Name BusinessUnitName
                                      ,[FirstName]
                                      ,[LastName]
                                      ,[Mobile]
                                      ,[AccountCode]
                                      ,[NationalId]
                                      ,[Customer].[Password]
                                      ,CASE ISNULL([Transaction].[State],1) WHEN 1 THEN 
									  CASE [Transaction].[Type] WHEN 'POS' THEN SUM([Transaction].[Amount]) ELSE 0 END
									  ELSE 0 END TotalCredit
                                      ,CASE ISNULL([Transaction].[State],1) WHEN 1 THEN
									  CASE [Transaction].[Type] WHEN 'NEG' THEN SUM([Transaction].[Amount]) ELSE 0 END
									  ELSE 0 END CreditUsed
	                                  ,0 CreditRemain
									  ,[Transaction].[State]
                                  FROM [dbo].[Customer]
                                  JOIN [dbo].[BusinessUnit] ON [Customer].BusinessUnitId = [BusinessUnit].BusinessUnitId
                                  LEFT JOIN [dbo].[Transaction] ON [Customer].CustomerId = [Transaction].CustomerId
								  WHERE [Customer].CustomerId = @CustomerId
                                  GROUP BY Customer.CustomerId,Customer.CreateOn,Customer.BusinessUnitId,BusinessUnit.Name,Customer.FirstName,Customer.LastName,
                                  Customer.Mobile,Customer.AccountCode,Customer.NationalId,Customer.Password,[Transaction].[Type]
								  ,[Transaction].[State]) AS TBL
                                  GROUP BY TBL.CustomerId,TBL.BusinessUnitId,TBL.BusinessUnitName,TBL.FirstName,TBL.LastName,TBL.Mobile,TBL.AccountCode,TBL.NationalId,TBL.Password";
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCom.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId;
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

        public DataTable SelectBarcodeById(Int32 CustomerId)
        {
            SqlDataReader SqlDataReader;
            try
            {
                var cmdText = @"SELECT [Barcode]
                                        ,[FirstName]
                                        ,[LastName]
                                        ,[Mobile]
                                        ,[AccountCode]
                                        ,[NationalId]
                                  FROM [dbo].[Customer]
								  WHERE [Customer].CustomerId = @CustomerId";
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCom.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId;
                SqlDataReader = SqlCom.ExecuteReader();
                DataTable dataTable = new DataTable("Barcode");
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

        /// <summary>
        /// برای فرم انتخابی
        /// </summary>
        /// <returns></returns>
        public DataTable SelectCustomers()
        {
            SqlDataReader SqlDataReader;
            try
            {
                var cmdText = @"SELECT [Customer].[CustomerId]
	                                  ,[BusinessUnit].Name BusinessUnitName
                                      ,[FirstName]
                                      ,[LastName]
                                      ,[Mobile]
                                      ,[AccountCode]
                                      ,[NationalId]
                                FROM [dbo].[Customer]
                                JOIN [dbo].[BusinessUnit] ON [Customer].BusinessUnitId = [BusinessUnit].BusinessUnitId";
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

        public DataTable SelectAllCustomer(string NationalId)
        {
            SqlDataReader SqlDataReader;
            try
            {
                #region Query
                var cmdText = @"SELECT TBL.CustomerId
                                        ,ROW_NUMBER() OVER(ORDER BY TBL.CustomerId ASC) [ROW_NUMBER]
                                        ,TBL.BusinessUnitId
                                        ,TBL.BusinessUnitName
                                        ,TBL.FirstName
                                        ,TBL.LastName
                                        ,TBL.Mobile
                                        ,TBL.AccountCode
                                        ,TBL.NationalId
                                        ,SUM(TBL.TotalCredit) TotalCredit
                                        ,SUM(TBL.CreditUsed)*(-1) CreditUsed
                                        ,SUM(TBL.TotalCredit)+SUM(TBL.CreditUsed) CreditRemain
                                        FROM
                                        (SELECT [Customer].[CustomerId]
                                              ,[Customer].[BusinessUnitId]
	                                          ,[BusinessUnit].Name BusinessUnitName
                                              ,[FirstName]
                                              ,[LastName]
                                              ,[Mobile]
                                              ,[AccountCode]
                                              ,[NationalId]
                                              ,CASE [Transaction].[Type] WHEN 'POS' THEN SUM([Transaction].[Amount]) ELSE 0 END TotalCredit
                                              ,CASE [Transaction].[Type] WHEN 'NEG' THEN SUM([Transaction].[Amount]) ELSE 0 END CreditUsed
	                                          ,0 CreditRemain
                                          FROM [dbo].[Customer]
                                          JOIN [dbo].[BusinessUnit] ON [Customer].BusinessUnitId = [BusinessUnit].BusinessUnitId
                                          LEFT JOIN [dbo].[Transaction] ON [Customer].CustomerId = [Transaction].CustomerId
                                          WHERE ISNULL([Transaction].[State],1) = 1 AND NationalId = @NationalId
                                          GROUP BY Customer.CustomerId,Customer.CreateOn,Customer.BusinessUnitId,BusinessUnit.Name,Customer.FirstName,Customer.LastName,
                                          Customer.Mobile,Customer.AccountCode,Customer.NationalId,[Transaction].[Type]) AS TBL
                                  GROUP BY TBL.CustomerId,TBL.BusinessUnitId,TBL.BusinessUnitName,TBL.FirstName,TBL.LastName,TBL.Mobile,
                                  TBL.AccountCode,TBL.NationalId";
                #endregion
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCom.Parameters.Add("@NationalId", SqlDbType.NVarChar).Value = NationalId;
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

        public DataSet PrintCustomer(string where, Int32 BusinessUnitId)
        {
            SqlDataReader SqlDataReader;
            try
            {
                #region Query
                var cmdText = @"SELECT TBL.CustomerId
                                        ,ROW_NUMBER() OVER(ORDER BY TBL.CustomerId ASC) [ROW_NUMBER]
                                        ,TBL.BusinessUnitId
                                        ,TBL.BusinessUnitName
                                        ,TBL.FirstName
                                        ,TBL.LastName
                                        ,TBL.Mobile
                                        ,TBL.AccountCode
                                        ,TBL.NationalId
                                        ,SUM(TBL.TotalCredit) TotalCredit
                                        ,SUM(TBL.CreditUsed)*(-1) CreditUsed
                                        ,SUM(TBL.TotalCredit)+SUM(TBL.CreditUsed) CreditRemain
                                        FROM
                                        (SELECT [Customer].[CustomerId]
                                              ,[Customer].[BusinessUnitId]
	                                          ,[BusinessUnit].Name BusinessUnitName
                                              ,[FirstName]
                                              ,[LastName]
                                              ,[Mobile]
                                              ,[AccountCode]
                                              ,[NationalId]
                                              ,CASE [Transaction].[Type] WHEN 'POS' THEN SUM([Transaction].[Amount]) ELSE 0 END TotalCredit
                                              ,CASE [Transaction].[Type] WHEN 'NEG' THEN SUM([Transaction].[Amount]) ELSE 0 END CreditUsed
	                                          ,0 CreditRemain
                                          FROM [dbo].[Customer]
                                          JOIN [dbo].[BusinessUnit] ON [Customer].BusinessUnitId = [BusinessUnit].BusinessUnitId
                                          LEFT JOIN [dbo].[Transaction] ON [Customer].CustomerId = [Transaction].CustomerId
                                          WHERE ISNULL([Transaction].[State],1) = 1 {0}
                                          GROUP BY Customer.CustomerId,Customer.CreateOn,Customer.BusinessUnitId,BusinessUnit.Name,Customer.FirstName,Customer.LastName,
                                          Customer.Mobile,Customer.AccountCode,Customer.NationalId,[Transaction].[Type]) AS TBL
                                  GROUP BY TBL.CustomerId,TBL.BusinessUnitId,TBL.BusinessUnitName,TBL.FirstName,TBL.LastName,TBL.Mobile,
                                  TBL.AccountCode,TBL.NationalId

                            SELECT [BusinessUnitId],[Name]
                            FROM [dbo].[BusinessUnit]
                            WHERE [BusinessUnit].BusinessUnitId = ISNULL(@BusinessUnitId,BusinessUnitId)";
                #endregion
                cmdText = string.Format(cmdText, where);
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCom.Parameters.Add("@BusinessUnitId", SqlDbType.NVarChar).Value = BusinessUnitId == 0 ? DBNull.Value : (object)BusinessUnitId;
                SqlDataReader = SqlCom.ExecuteReader();
                DataSet ds = new DataSet();
                ds.Load(SqlDataReader, LoadOption.PreserveChanges, "Customer", "BusinessUnit");
                SqlDataReader.Close();
                return ds;
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

        public DataTable CheckPassword(string NationalId, string Password)
        {
            SqlDataReader SqlDataReader;
            try
            {
                #region Query
                var cmdText = @"SELECT TBL.CustomerId
                                        ,ROW_NUMBER() OVER(ORDER BY TBL.CustomerId ASC) [ROW_NUMBER]
                                        ,TBL.BusinessUnitId
                                        ,TBL.BusinessUnitName
                                        ,TBL.FirstName
                                        ,TBL.LastName
                                        ,TBL.Mobile
                                        ,TBL.AccountCode
                                        ,TBL.NationalId
                                        ,SUM(TBL.TotalCredit) TotalCredit
                                        ,SUM(TBL.CreditUsed)*(-1) CreditUsed
                                        ,SUM(TBL.TotalCredit)+SUM(TBL.CreditUsed) CreditRemain
                                        FROM
                                        (SELECT [Customer].[CustomerId]
                                              ,[Customer].[BusinessUnitId]
	                                          ,[BusinessUnit].Name BusinessUnitName
                                              ,[FirstName]
                                              ,[LastName]
                                              ,[Mobile]
                                              ,[AccountCode]
                                              ,[NationalId]
                                              ,CASE [Transaction].[Type] WHEN 'POS' THEN SUM([Transaction].[Amount]) ELSE 0 END TotalCredit
                                              ,CASE [Transaction].[Type] WHEN 'NEG' THEN SUM([Transaction].[Amount]) ELSE 0 END CreditUsed
	                                          ,0 CreditRemain
                                          FROM [dbo].[Customer]
                                          JOIN [dbo].[BusinessUnit] ON [Customer].BusinessUnitId = [BusinessUnit].BusinessUnitId
                                          LEFT JOIN [dbo].[Transaction] ON [Customer].CustomerId = [Transaction].CustomerId
                                          WHERE ISNULL([Transaction].[State],1) = 1 AND NationalId = @NationalId AND [Customer].[Password] = @Password
                                          GROUP BY Customer.CustomerId,Customer.CreateOn,Customer.BusinessUnitId,BusinessUnit.Name,Customer.FirstName,Customer.LastName,
                                          Customer.Mobile,Customer.AccountCode,Customer.NationalId,[Transaction].[Type]) AS TBL
                                  GROUP BY TBL.CustomerId,TBL.BusinessUnitId,TBL.BusinessUnitName,TBL.FirstName,TBL.LastName,TBL.Mobile,
                                  TBL.AccountCode,TBL.NationalId";
                #endregion
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCom.Parameters.Add("@NationalId", SqlDbType.NVarChar).Value = NationalId;
                SqlCom.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
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

        public Int32 CheckNationalId(string NationalId)
        {
            try
            {
                #region Query
                var cmdText = @"SELECT [Customer].[CustomerId]
                                FROM [dbo].[Customer]
                                WHERE NationalId = @NationalId";
                #endregion
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlConnection);
                SqlCom.CommandType = CommandType.Text;
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCom.Parameters.Add("@NationalId", SqlDbType.NVarChar).Value = NationalId;
                var obj = SqlCom.ExecuteScalar();
                if (obj != null)
                    return Convert.ToInt32(obj);
                else
                    return -1;
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
