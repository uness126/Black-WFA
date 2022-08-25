using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Xml;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;
using System.Data.Sql;
using System.Data.Common;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Data.OleDb;
using System.Globalization;

namespace Black
{
    public class ClsDataBase
    {
        #region Variables

        //= new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=true;");
        static ClsEncryptionAndDecryption clsEncryptionAndDecryption = new ClsEncryptionAndDecryption();
        public static string ConnectionString;
        public string SERVER_NAME { get; set; }
        public string DB_NAME { get; set; }

        #region FullScript
        private const string FullScript = @"USE [master]
GO
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'Club')
begin
	CREATE DATABASE [Club]
end      
GO  
USE [Club]
GO
/****** Object:  Table [dbo].[BusinessUnit]    Script Date: 03/12/20 8:29:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BusinessUnit]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BusinessUnit](
	[BusinessUnitId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[UserId] [int] NULL,
	[CreateOn] [datetime] NULL,
 CONSTRAINT [PK_BusinessUnit] PRIMARY KEY CLUSTERED 
(
	[BusinessUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 03/12/20 8:29:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[BusinessUnitId] [int] NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[AccountCode] [nvarchar](15) NULL,
	[NationalId] [nvarchar](10) NULL,
	[Password] [nvarchar](128) NULL,
	[Barcode] [nvarchar](max) NULL,
	[CreateOn] [datetime] NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 03/12/20 8:29:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Roles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](20) NULL,
	[RoleType] [tinyint] NULL,
	[ShowPassword] [bit] NULL,
	[rowguid] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Setting]    Script Date: 03/12/20 8:29:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Setting]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Setting](
	[SettingGuid] [uniqueidentifier] NOT NULL,
	[Key] [nvarchar](50) NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_Setting] PRIMARY KEY CLUSTERED 
(
	[SettingGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[User]    Script Date: 03/12/20 8:29:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[UserName] [nvarchar](15) NULL,
	[Password] [nvarchar](50) NULL,
	[RoleId] [int] NULL,
	[Status] [bit] NULL,
	[rowguid] [uniqueidentifier] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Index [IX_BusinessUnitId_Customer]    Script Date: 03/12/20 8:29:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Customer]') AND name = N'IX_BusinessUnitId_Customer')
CREATE NONCLUSTERED INDEX [IX_BusinessUnitId_Customer] ON [dbo].[Customer]
(
	[BusinessUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_NationalId_Customer]    Script Date: 03/12/20 8:29:44 PM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Customer]') AND name = N'IX_NationalId_Customer')
CREATE NONCLUSTERED INDEX [IX_NationalId_Customer] ON [dbo].[Customer]
(
	[NationalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_BusinessUnit_CreateOn]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BusinessUnit] ADD  CONSTRAINT [DF_BusinessUnit_CreateOn]  DEFAULT (getdate()) FOR [CreateOn]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Customer_CreateOn]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_CreateOn]  DEFAULT (getdate()) FOR [CreateOn]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Roles_ShowPassword]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Roles] ADD  CONSTRAINT [DF_Roles_ShowPassword]  DEFAULT ((1)) FOR [ShowPassword]
END

GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Customer_BusinessUnit]') AND parent_object_id = OBJECT_ID(N'[dbo].[Customer]'))
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_BusinessUnit] FOREIGN KEY([BusinessUnitId])
REFERENCES [dbo].[BusinessUnit] ([BusinessUnitId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Customer_BusinessUnit]') AND parent_object_id = OBJECT_ID(N'[dbo].[Customer]'))
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_BusinessUnit]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_Roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Roles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_Roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Roles]
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Roles', N'COLUMN',N'RoleType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 Admin 2 User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'RoleType'
GO
";

        #endregion

        #endregion

        public ClsDataBase()
        {
            ConnectionString = "Data Source=" + Properties.Settings.Default.server + ";Initial Catalog=Club;Integrated Security=false;User ID=" + Properties.Settings.Default.user + ";Password=" + clsEncryptionAndDecryption.Decrypt(Properties.Settings.Default.password);
        }

        public void SaveServerName(string servername)
        {
            Properties.Settings.Default.server = servername;
            Properties.Settings.Default.Save();
        }
        
        public bool CreateDataBase()
        {
            SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder(ConnectionString);
            cb.InitialCatalog = "master";
            SqlConnection sqlConnection = new SqlConnection(cb.ConnectionString);
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                var commandStrings = Regex.Split(FullScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        using (var command = new SqlCommand(commandString, sqlConnection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void UpdateModifiedDataBase()
        {
            string script;
            script = "USE [Club]" + Environment.NewLine;
            script += File.ReadAllText(Application.StartupPath + "\\modified.dll");
            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                     RegexOptions.Multiline | RegexOptions.IgnoreCase);
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            try
            {
                sqlConnection.Open();
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        using (var command = new SqlCommand(commandString, sqlConnection))
                        {
                            command.CommandTimeout = 100;
                            command.ExecuteNonQuery();
                        }
                    }
                }
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

        public bool CheckDataBase()
        {
            try
            {
                ServerConnection sc = new ServerConnection(Properties.Settings.Default.server, Properties.Settings.Default.user, clsEncryptionAndDecryption.Decrypt(Properties.Settings.Default.password));
                Server svr = new Server(sc);
                Database db = svr.Databases["Club"];
                if (db != null && db.Name.ToLower() == "club")
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                return false;
            }
        }

        public static DataTable ExcelToDataTable(string filePath)
        {
            DataTable dtexcel = new DataTable();
            try
            {
                bool hasHeaders = true;
                string HDR = hasHeaders ? "Yes" : "No";
                string strConn;
                if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
                else
                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                //Looping Total Sheet of Xl File
                /*foreach (DataRow schemaRow in schemaTable.Rows)
                {
                }*/
                //Looping a first Sheet of Xl File
                DataRow schemaRow = schemaTable.Rows[0];
                string sheet = schemaRow["TABLE_NAME"].ToString();
                if (!sheet.EndsWith("_"))
                {
                    string query = "SELECT  * FROM [" + sheet + "]";
                    OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
                    dtexcel.Locale = CultureInfo.CurrentCulture;
                    daexcel.Fill(dtexcel);
                }

                conn.Close();
                return dtexcel;
            }
            catch (Exception exc)
            {
                exc.WriteLOG();
                MessageBox.Show("پیش نیازهای برنامه نصب نشده اند!!!");
                return dtexcel;
            }

        }
    }
}

