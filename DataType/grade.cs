using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Grade
    {
        public static void Main()
        {
            Console.Write("Enter any number=");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n>=90)
            {
                Console.WriteLine(" Grade=A+");
            }
            else if (n>=80)
            {
                Console.WriteLine(" Grade=A");
            }
            else if (n>=70)
            {
                Console.WriteLine(" Grade=B");
            }
            else if (n>=50)
            {
                Console.WriteLine(" Grade=C");
            }
            else
            {
                Console.WriteLine(" Grade=D");
            }
            
        }
    }

}

