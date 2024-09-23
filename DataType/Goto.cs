using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Goto
    {
        public static void Main()
        {
validAge:

            Console.WriteLine("enter valid age between 0 & 120");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age <=-1 || age> 120)
            {
                goto validAge;
            }
            Console.WriteLine("Age is="+age);
        }
    }
}
