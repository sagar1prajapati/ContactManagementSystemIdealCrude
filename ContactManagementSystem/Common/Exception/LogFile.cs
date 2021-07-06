using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ContactManagementSystem.Common.ExceptionFramework
{
    public class LogFile
    {
        public static void VerifyDir(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                if (!dir.Exists)
                {
                    dir.Create();
                }
            }
            catch { }
        }
        public static void Logger(string lines)
        {
            string path = "C:/Log/";
            VerifyDir(path);
            string fileName = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + "_Logs.txt";
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(path + fileName, true);
                file.WriteLine(DateTime.Now.ToString() + ": " + lines);
                file.Close();
            }
            catch (System.Exception) { }
        }
    }
}