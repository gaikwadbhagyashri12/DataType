using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class ForEach
    {
        public static void Main()
        {
            string[] brands = { "1.Apple","2.Galaxy","3.Samusung","4.Vivo","5.Realme","6.Mi","7.OnePlus","8.Oppo","9.Sony","10.Poco"};

            Console.WriteLine("*****Brands*****");
            foreach(string brand in brands)
            {
                Console.WriteLine("  "+brand);
            }
        }
    }
}
