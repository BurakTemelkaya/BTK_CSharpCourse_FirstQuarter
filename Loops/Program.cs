using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 2; i <= 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished!");

            //int number = 100;
            //while (number>=0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //Console.WriteLine("Now number is {0}",number);

            //int number = 11;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //} while (number>=0);

            //string[] students = new string[3] { "Engin", "Burak", "Eren" };
            //foreach (var studen in students)
            //{
            //    Console.Write(studen + ",");
            //}
            Console.WriteLine("Sayı gir");
            
            if (IsPrimeNumber(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}
