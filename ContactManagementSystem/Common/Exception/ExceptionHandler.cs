using ContactManagementSystem.Common.Exception;
using ContactManagementSystem.Common.ExceptionFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;

namespace ContactManagementSystem.Common
{
    public class ExceptionHandler
    {
      

        public static string GetAllFootprints(string exceptionType,String className, string methodName, System.Exception ex)
        {
            string exceptionMessage = "";

            StringBuilder ExceptionData = new StringBuilder();
            ExceptionData.Append("\n");
            ExceptionData.Append("***************************");
            ExceptionData.Append("\n");
            ExceptionData.Append("File Name : ");
            ExceptionData.Append(className);
            ExceptionData.Append("\n");
            ExceptionData.Append("Method Name : ");
            ExceptionData.Append(methodName);
            ExceptionData.Append("\n");
            ExceptionData.Append("Message : ");
            ExceptionData.Append(ex.Message) ;
            ExceptionData.Append("\n");
            ExceptionData.Append("InnerException :");
            ExceptionData.Append(ex.InnerException != null ? ex.InnerException.ToString() : "");
            ExceptionData.Append("\n");
            ExceptionData.Append("***************************");
            ExceptionData.Append("\n");
            LogFile.Logger(ExceptionData.ToString());
            
            if(exceptionType == Constants.SQL_EXCEPTION)
            {
                exceptionMessage = "exception Occour At Sql Server at File " + className + " Method Name " + methodName; 
            }
            if (exceptionType == Constants.GENERIC_EXCEPTION)
            {
                exceptionMessage = "exception Occour At Sql Server at File " + className + " Method Name " + methodName;
            }
            
            return exceptionMessage;
        }
    }
}