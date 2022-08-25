using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black
{
    static class ClsCommon
    {
        #region Variables
        const long lng = 204800;
        #endregion
        public static void WriteLOG(this Exception ex, string Method = null)
        {
            try
            {
                var text = string.Empty;
                text = " " + Method + " : ";
                //}
                while (ex != null)
                {
                    text += ex.GetType().FullName;
                    text += Environment.NewLine;
                    text += ex.Source;
                    text += Environment.NewLine;
                    text += ex.ToString();
                    ex = ex.InnerException;
                    text += Environment.NewLine +                        "**************************************************************************************************************************************** ";
                }

                if (File.Exists(Application.StartupPath + "\\log.kit"))
                {
                    long length = new System.IO.FileInfo(Application.StartupPath + "\\log.kit").Length;
                    StreamWriter sr;
                    if (length > lng)
                        sr = new StreamWriter(Application.StartupPath + "\\log.kit", false);
                    else
                        sr = new StreamWriter(Application.StartupPath + "\\log.kit", true);
                    sr.WriteLine(Convert2Persian(DateTime.Now) + " | " + DateTime.Now.ToString("HH:mm") + " | " + text);
                    sr.Close();
                }
                else
                {
                    using (TextWriter sr = new StreamWriter(Application.StartupPath + "\\log.kit", true))
                    {
                        sr.WriteLine(Convert2Persian(DateTime.Now) + " | " + DateTime.Now.ToString("HH:mm") + " | " + text);
                        sr.Close();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private static string Convert2Persian(DateTime date)
        {
            PersianCalendar perdate = new PersianCalendar();
            return perdate.GetYear(date).ToString("00") + "/" + perdate.GetMonth(date).ToString("00") + "/" + perdate.GetDayOfMonth(date).ToString("00");
        }

        public static string ReadImage()
        {
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(Application.StartupPath + "\\Barcode.bmp"))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        public static System.Drawing.Image ConvertBase64ToImage(string BaseStr)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(BaseStr);
                System.Drawing.Image image;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    image = System.Drawing.Image.FromStream(ms);
                }

                return image;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string ConvertImageToBase64(string FileName)
        {
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(FileName))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        public static Stream ReadResource(string name)
        {
            // Determine path
            var assembly = Assembly.GetExecutingAssembly();
            string resourcePath = name;
            // Format: "{Namespace}.{Folder}.{filename}.{Extension}"

            //resourcePath = assembly.GetManifestResourceNames().Single(str => str.EndsWith(name));
            Stream stream = assembly.GetManifestResourceStream(name);
            return stream;

            //using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
            //using (StreamReader reader = new StreamReader(stream))
            //{
            //    return reader.ReadToEnd();
            //}
        }

        /// <summary>
        /// چک کردن فایل در پوشه
        /// </summary>
        /// <param name="subPath"></param>
        /// <returns></returns>
        public static bool CheckFileExists(string subPath)
        {
            try
            {
                bool temp = System.IO.File.Exists(subPath);
                return temp;
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                return false;
            }
        }

    }
}
