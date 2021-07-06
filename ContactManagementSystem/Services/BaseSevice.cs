using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem.Services
{
    public abstract class BaseService
    {
        public string TrimString(string String)
        {
            if (String != null)
            {
                return String.Trim();
            }
            else
            {
                return String;
            }

        }
        public bool ValidateIsStringEmpty(string String)
        {
            if (String != null)
            {
                String = String.Trim();
                if (String != null && String != "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
        public bool IsIntegerNullOrZero(Int64? integerValue)
        {
            if (integerValue != null)
            {
                if (integerValue == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public static object DbValue(object value)
        {
            if (null != value)
                return value;
            return DBNull.Value;
        }


    }
}