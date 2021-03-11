using System;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[]{ "Ankara", "Adana", "Afyon" };//101
            string[] cities2 = new string[]{ "Bursa", "Bolu", "Balıkesir" };//101
            cities2 = cities1;//cities 2'yi cities 1'in referansına eşitliyoruz
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            Console.ReadLine();
        }
    }
}
