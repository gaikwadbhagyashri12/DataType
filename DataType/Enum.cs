using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    public enum Year
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        Saptember,
        October,
        November,
        December
    }
    class Enum
    {
        public static void Main()
        {
            Year month = Year.January;
            switch(month)
            {
                case Year.January:
                    Console.WriteLine("The Starting Month is:"+month);
                    break;

                case Year.February:
                    Console.WriteLine("Month Of Year:"+month);
                    break;

                case Year.March:
                    Console.WriteLine("Month Of Year:"+month);
                    break;

                case Year.April:
                    Console.WriteLine("Month Of Year:"+month);
                    break;

                case Year.May:
                    Console.WriteLine("Month of Year:"+month);
                    break;

                case Year.June:
                    Console.WriteLine("Month Of Year:"+month);
                    break;

                case Year.July:
                    Console.WriteLine("Month Of Year:"+month);
                    break;

                case Year.August:
                    Console.WriteLine("Month of Year:"+month);
                    break;

                case Year.Saptember:
                    Console.WriteLine("Month of Year:"+month);
                    break;

                case Year.October:
                    Console.WriteLine("Month of Year:"+month);
                    break;

                case Year.November:
                    Console.WriteLine("Month Of Year:"+month);
                    break;

                case Year.December:
                    Console.WriteLine("Ending Month is:"+month);
                    break;
            }
            Console.BackgroundColor=ConsoleColor.DarkGreen;
           if(month==Year.January||month==Year.December)
            {
                Console.WriteLine("Its starting month:"+month);
            }
            else
            {
                Console.WriteLine("Its Ending Month:"+month);
            }
        }
    }
}
