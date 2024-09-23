using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class ControlStatement
    {
        public static void Main()
        {
           

            int number = -25;

            if (number > 0)
            {
                Console.WriteLine("number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("number is negative"); 

            }
                else
            {
                Console.WriteLine("number is zero");
            }

            

        }
    }
}
