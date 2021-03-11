using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types 
            //Console.WriteLine("Hello Word Again");
            
            double number5 = 10.5;
            decimal number6 = 10.51321321321321m;
            char character = 'A';
            string city = "Ankara";
            bool condition = true;
            byte number4 = 255;
            short number3 = 32767;
            int number = 10;
            long number2 = 2147483648888888888;
            var number7 = 10;
            Console.WriteLine("Numbers is {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",number,number2,number3,number4,character,number5,(int)Days.Friday,number7);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
