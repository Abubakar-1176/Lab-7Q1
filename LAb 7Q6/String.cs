using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb_7Q6
{
    internal class @string
    {
        public static string rev(string a)
        {
            char[] chars = a.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);

        }

        public static string upper(string a)
        {
            return a.ToUpper();
        }

        public static int count(string a)
        {
            return a.Length;
        }

    }
}
   