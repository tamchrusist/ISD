using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Static
{
    static class ExtendedString
    {
       
            public static string ExtSubString(this string str, int a, int b)
            {
                return str.Substring(a, b);
            }

            public static int ExtIndexOf(this string str, char c)
            {
                return str.IndexOf(c);
            }

            public static string ExtReplace(this string str, string oldVal, string newVal)
            {
                return str.Replace(oldVal, newVal);
            }
        }
    }

