using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataType
{
    class SwitchStatement
    {
        public static void Main(string[] args)

        {
            Console.WriteLine(" * * * * * MENU * * * * * ");
            Console.WriteLine("1:Pizza \n2:Burger \n3:Salad \n4:Exit");
            Console.Write("Enter Your Choice=");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)

            {
                case 1:
                    Console.WriteLine("Pizza=499");
                    break;

                case 2:
                    Console.WriteLine("Burger=250");
                    break;

                case 3:
                    Console.WriteLine("Salad=175");
                    break;


                default:
                    Console.WriteLine("Menu is not available");
                    break;
            }
            while (n!=4) ;
        }
    }
}