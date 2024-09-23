using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Search
    {
        public static void Main()
        {
            Console.WriteLine("Enter String Name=");
            string search = Console.ReadLine();
            
            string[] arr = { "Alice", "Bob", "Charlie", "David", "Emily" };
            string found = "";
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]==search)
                {
                    found=arr[i];
                }
            }
            if(found==search)
            {
                Console.WriteLine(search+" was Found");
            }
            else
            {
                Console.WriteLine(search+" was not Found");
            }
        }
    }
}
