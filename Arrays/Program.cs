using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Engin", "Burak", "Eren" };

            string[] students2 = {"Engin","Burak","Eren"};
            students[0] = "Burak";
            students[1] = "Şule";
            students[2] = "Eren";

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            string[,] bolge = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"}
            };

            for (int i = 0; i <= bolge.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bolge.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolge[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
