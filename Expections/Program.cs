using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Expections
{
    class Program
    {
        static void Main(string[] args)
        {
            //error();
            //TryCatch();
            //Method
            //ActionDemo();

            Func<int, int, int> add = Topla;

            Console.WriteLine(add(3, 5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber());
            Thread.Sleep(100);
            Console.WriteLine(getRandomNumber2());

            //Console.WriteLine(Topla(2, 3));

            Console.ReadLine();
        }
        static int Topla(int x, int y)
        {
            return x + y;
        }
        static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        static private void ActionDemo()
        {
            HandleException(() =>
            {
                Find();
            });
        }

        private static void HandleException(Action action)//try catchi merkezi bir yere bağladık
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> student = new List<string> { "Burak", "Şule", "Ayşe" };

            if (!student.Contains("Ahmet"))
            {
                throw new RecordNotFoundException ("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }
        public static void error()
            {
            try
            {
                string[] students = new string[3] { "Engin", "Derin", "Salih" };

                students[3] = "Ahmet";
            }
            catch(IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

    }
}
