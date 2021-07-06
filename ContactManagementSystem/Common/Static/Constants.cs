using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem.Common.Exception
{
   public static class Constants
    {
        public const string SQL_EXCEPTION = "Exception occur at SQL server end";
        public const string GENERIC_EXCEPTION = "Exception Occur at Server Side";

        public const int SUCCESS_STATUS_CODE = 1;
        public const int Fail_STATUS_CODE = 0;
    }
}