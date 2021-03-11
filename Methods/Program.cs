using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(20,50);

            //int n1 = 20,n2=100;
            //var result2 = Add3(ref n1, n2);//ref keywordü ile metodda değişkenin değişmesini sağlama
            //var result3 = Add4(out n1, n2);// outda değer vermeden kullanabiliyoruz
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.WriteLine(n1);//refle dönen n1 değerini yazdırma

            Console.WriteLine(Multiply(2,8));
            Console.WriteLine(Multiply(2,8,6));

            Console.WriteLine(Add4(2,3,4,5,6,7,8,9,10));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2=30)
        {
            return number1 + number2;
        }

        static int Add3(ref int n1,int n2)
        {
            n1 = 30;
            return n1 + n2;
        }
        static int Add4(out int n1, int n2)
        {
            n1 = 10;//out kullanıldığında metod içerisinde en az 1 kere set edilmesi gerekir
            return n1 + n2;
        }
        static int Multiply(int n1,int n2)//metodun imzası
        {
            return n1 * n2;
        }
        static int Multiply(int n1, int n2, int n3)//overload kullanımı, imza metoddan daha fazla değişken içermesi  gerekiyor 
        {
            return n1 * n2 * n3;
        }
        static int Add4(params int[] numbers)//paramsla metodumuza istediğimiz kadar parametre gönderebiliriz
        {
            return numbers.Sum();
        }
    }
}
