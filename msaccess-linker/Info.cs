using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTypeExtension;

namespace msaccess_linker
{
    public static class Info
    {
        public static string version = "alpha";
        private static map[] dataType =
        {
           new map() { Text ="文字", Value ="TEXT" },
           new map() {Text="數值", Value="NUMERIC" }
        };

        public static string mapToValue(string check)
        {
            foreach(var type in dataType)
                if (check == type.Text) return type.Value;

            return "TEXT";
        }
    }
}
