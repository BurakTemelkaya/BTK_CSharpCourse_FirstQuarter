using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection//reflection çalışma anında değerleri görmek için kullanılır
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);//constructor verileri
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4));//direk parametre değerleri

            var tip = typeof(DortIslem);//reflection kullanımı

            //DortIslem dortIslem= (DortIslem)Activator.CreateInstance(tip,6,7);//activator ile instance oluşturduk
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());

            var insteance = Activator.CreateInstance(tip, 6, 5);

            MethodInfo methodInfo = insteance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(insteance,null));

            Console.WriteLine("-------------------");

            var methodlar = tip.GetMethods();

            foreach (var info in methodlar)
            {
                Console.WriteLine("Metod adı : {0}", info);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }
    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public DortIslem()
        {

        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }
    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {
            
        }
    }
}
