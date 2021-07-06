using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace ContactManagementSystem.Common.Exception
{
    public static class Helper
    {
        public static string GetCallerClassName([CallerFilePath] string className = null)
        {
            return className;
        }
        public static string GetCallerMethodName([CallerMemberName] string methodName = null)
        {
            return methodName;
        }
    }

}