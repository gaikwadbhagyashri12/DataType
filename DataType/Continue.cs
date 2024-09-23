using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Continue
    {
        public static void Main()
        {
            int n = 20;
            Console.WriteLine("print only those no.to devided by 3");
            for(int i=1;i<=n;i++)
            {
                if(i%3!=0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
