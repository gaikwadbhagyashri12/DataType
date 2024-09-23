using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Reverse
    {
        public static void Main()
        {
            string str = "CODEMIND TECHNOLOGY";
            string rev = new string(str.Reverse().ToArray());
            Console.WriteLine("Reverse String is: "+rev);
        }
    }
}
