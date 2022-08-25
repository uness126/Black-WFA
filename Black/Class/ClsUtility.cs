using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Black
{
    public class ClsUtility
    {
        public ClsUtility()
        {

        }

        public static Int32 UserID;
        public static Int32 SYS_USR_ROLE_ID;
        public static Int32 SYS_USR_ROLE_TYPE;
        public static Int32 BusinessUnitID;
       
        public static string SYS_USR_USERNAME;
        public static string SYS_USR_PASSWORD;
        public static string SYS_USR_FIRST_NAME;
        public static string SYS_USR_LAST_NAME;
        public static string BUS_UNIT_NAME;
        public static string FIS_PERIOD_NAME;
        public static string BUS_UNIT_BRIEFNAME;
        public static string APP_NAME;
        public static string APP_CRM = String.Empty;
        public static string CUSTOMER_CLUB = "1";
        public static bool UPDATEDATABASE = true;

        PersianCalendar perdate = new PersianCalendar();

        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SetDefaultPrinter(string Name);

        public bool SetPrinter(string PrinterName)
        {
            bool result = false;
            try
            {
                result = SetDefaultPrinter(PrinterName);
            }
            catch (Exception)
            { }
            return result;
        }

        public DateTime Convert2Miladi(string shamsi)
        {
            System.Globalization.PersianCalendar Mdate = new System.Globalization.PersianCalendar();
            DateTime MiladiDate;
            string[] prdate = shamsi.Split('/');
            MiladiDate = Mdate.ToDateTime(Convert.ToInt32((prdate[0])), Convert.ToInt32(prdate[1]), Convert.ToInt32(prdate[2]), DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, System.Globalization.GregorianCalendar.ADEra);
            return Convert.ToDateTime(MiladiDate);
        }

        public string Convert2Persian(DateTime date)
        {
            PersianCalendar perdate = new PersianCalendar();
            return perdate.GetYear(date).ToString("00") + "/" + perdate.GetMonth(date).ToString("00") + "/" + perdate.GetDayOfMonth(date).ToString("00");
        }

        public string GetTime(DateTime date)
        {
            return date.ToString("HH:mm");
        }
    }
}

