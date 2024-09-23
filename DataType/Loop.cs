using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Loop
    { 
        public static void Main(string[]args)
        {
            Console.WriteLine("* * * for loop * * *");
            
                for (int n = 1; n<=10; n++) 
                {
                    Console.WriteLine("Student no=" +n);
                }
            Console.WriteLine("* * * While Loop * * *");
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine("Student no="+i);
                i++;
            }
            Console.WriteLine("* * * Do While Loop * * *");
            int j = 1;
            do
            {
                Console.WriteLine("Student no="+j);
                j++;
            }
            while (j<=10);
            }
        }
    
}
