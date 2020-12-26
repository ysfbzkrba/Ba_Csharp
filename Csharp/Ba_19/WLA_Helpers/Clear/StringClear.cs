using System;
using System.Collections.Generic;
using System.Text;

namespace WLA_Helpers.Clear
{
    public static class StringClear
    {

        public static string URL(string param)
        {

            param = param.ToLower().Replace("ş", "s").Replace(" ", "-");
            return param;
        }

        public static string Mail(string param)
        {
            param = param.ToLower().Replace("ş", "s").Replace(" ", "");
            return param;
        }

        public static string ClearText(this string param)
        {
            param = param.ToLower().Replace("}", "");
            return param;
        }

        public static int ClearText(this int param)
        {
            return param * 10;
        }
    }
}
