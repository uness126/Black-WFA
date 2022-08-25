using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Black
{
    public delegate void SyncAccountEventHandler(SyncAccountEventArgs e);
    public class SyncAccountEventArgs : EventArgs
    {
        public int Count { get; set; }
        public int totalCount { get; set; }
    }



    public class ClsShygun
    {
        SqlConnection sqlcon;
        public event SyncAccountEventHandler SyncAccount;
        private void OnSyncAccount(SyncAccountEventArgs e)
        {
            //SyncProductEventHandler handler = SyncProduct;
            //if (handler != null)
            //{
            //    handler(e);
            //}
            SyncAccount?.Invoke(e);
        }

        public ClsShygun()
        {

        }
        private SqlConnection SetConnection(string serverName, string database, string username, string password)
        {
            SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
            connection.DataSource = serverName;
            connection.IntegratedSecurity = false;
            connection.InitialCatalog = database;
            connection.UserID = username;
            connection.Password = password;
            return new SqlConnection(connection.ConnectionString);
        }

        public void ImportAccount(string serverName, string database, string username, string password, int moinCode, int AccountTypeId, DataTable accountImport, ProgressForm prg, ref int count)
        {
            SqlCommand sqlCommandShygun;
            SqlTransaction sqlTransaction = null;
            int moinId = 0;
            int countSync = 0;
            //lblTotalCustomer.Text = "0";
            //lblSuccess.Text = "0";
            try
            {
                sqlcon = SetConnection(serverName, database, username, password);
                if (sqlcon.State != ConnectionState.Open)
                    sqlcon.Open();
                var cmdText = @"SELECT [MoinId]
                                          FROM [dbo].[AC_2201_N]
                                          WHERE MoinNumber = @MoinNumber";
                sqlCommandShygun = new SqlCommand(cmdText, sqlcon);
                sqlCommandShygun.Transaction = sqlTransaction;
                sqlCommandShygun.CommandType = CommandType.Text;
                sqlCommandShygun.Parameters.Clear();
                sqlCommandShygun.Parameters.AddWithValue("@MoinNumber", moinCode);
                var obj = sqlCommandShygun.ExecuteScalar();
                if (obj != null && obj != DBNull.Value)
                    moinId = Convert.ToInt32(obj);
                if (moinId == 0)
                    throw new Exception("کد معین حساب نا معتبر است.");
                //
                //lblTotalCustomer.Text = dtexcel.Rows.Count.ToString();
                foreach (DataRow dritem in accountImport.Rows)
                {
                    if (prg == null || prg.getStatus() == false)
                    {
                        count = countSync;
                        prg.Stop();
                        return;
                    }
                    sqlTransaction = sqlcon.BeginTransaction();
                    try
                    {

                        string _accountName = Convert.ToString(dritem["accountname"]);
                        string Mobile = Convert.ToString(dritem["mobile"]);
                        string Add1 = Convert.ToString(dritem["add1"]);
                        string mellicode = Convert.ToString(dritem["mellicode"]);
                        //

                        //sqlCommandShygun = new SqlCommand("CAS_AC_0101_N_GetLastAccNumber", sqlcon);
                        //SqlParameter Result = new SqlParameter("@NewAccountNumber", SqlDbType.VarChar) { Direction = ParameterDirection.Output };
                        //sqlCommandShygun.Transaction = sqlTransaction;
                        //sqlCommandShygun.CommandType = CommandType.StoredProcedure;
                        //sqlCommandShygun.Parameters.Clear();
                        //sqlCommandShygun.Parameters.AddWithValue("@MoinId", moinId);
                        //sqlCommandShygun.Parameters.Add(Result);
                        //sqlCommandShygun.ExecuteNonQuery();
                        //var NewAccountNumber = Convert.ToString(Result.Value);
                        //
                        SqlParameter AccountId = new SqlParameter("@AccountId", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        sqlCommandShygun = new SqlCommand("CAS_AC_0101_N_Insert", sqlcon);
                        sqlCommandShygun.Transaction = sqlTransaction;
                        sqlCommandShygun.CommandType = CommandType.StoredProcedure;
                        sqlCommandShygun.Parameters.Clear();
                        sqlCommandShygun.Parameters.Add(AccountId);
                        sqlCommandShygun.Parameters.AddWithValue("@MoinId", moinId);
                        sqlCommandShygun.Parameters.AddWithValue("@AccountTypeId", AccountTypeId);
                        sqlCommandShygun.Parameters.AddWithValue("@JobCosting", 0);
                        sqlCommandShygun.Parameters.AddWithValue("@CurrencyDEFAULT", 1);
                        sqlCommandShygun.Parameters.AddWithValue("@CInactive", 0);
                        sqlCommandShygun.Parameters.AddWithValue("@AccountName", _accountName);
                        sqlCommandShygun.Parameters.AddWithValue("@CreditLimit", 0);
                        sqlCommandShygun.Parameters.AddWithValue("@DebitLimit", 0);
                        sqlCommandShygun.Parameters.AddWithValue("@Comquan", 0);
                        sqlCommandShygun.Parameters.AddWithValue("@Mobile", Mobile);
                        sqlCommandShygun.Parameters.AddWithValue("@Add1", Add1);
                        sqlCommandShygun.Parameters.AddWithValue("@mellicode", mellicode);
                        sqlCommandShygun.ExecuteNonQuery();
                        sqlTransaction.Commit();
                        countSync++;
                        count = countSync;
                    }
                    catch (Exception ex)
                    {
                        ex.WriteLOG();
                        if (sqlTransaction != null)
                            sqlTransaction.Rollback();
                    }
                    OnSyncAccount(new SyncAccountEventArgs() { totalCount = accountImport.Rows.Count, Count = countSync });
                }
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                throw;
            }
            finally
            {
                if (sqlcon != null)
                    sqlcon.Close();
            }
        }

        public DataTable SelectAccountType(string serverName, string database, string username, string password)
        {
            SqlDataReader SqlDataReader;
            try
            {
                sqlcon = SetConnection(serverName, database, username, password);
                var cmdText = @"SELECT [AccountTypeId]
                                  ,[AccountTypeName3]
                              FROM [dbo].[AC_0104_N]";
                SqlCommand SqlCom = new SqlCommand(cmdText, sqlcon);
                SqlCom.CommandType = CommandType.Text;
                if (sqlcon.State != ConnectionState.Open)
                    sqlcon.Open();
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
                sqlcon.Close();
            }
        }
    }
}
