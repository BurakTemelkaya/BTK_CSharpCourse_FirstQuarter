using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Burak Temelkaya";

            var result = sentence.Length;//karekter sayısını verir
            var result2 = sentence.Clone();
            sentence = "My name is Burak Temelkaya";

            bool result3 = sentence.EndsWith("ğ");//bittiği karekterleri kontrol etme, bool değer döner
            bool result4 = sentence.StartsWith("My Name");//üsttekinin tersi

            var result5 = sentence.IndexOf("name");//içerisine yazdığımız kelimenin ilk karekterinin kaçıncı karekterde bulduğunu gösterir
            var result6 = sentence.IndexOf(" ");

            var result7 = sentence.LastIndexOf(" "); //sondan aramaya başlar
            var result8 = sentence.Insert(0,"Hello , ");//0. karekterinden itibaren kelimenin içerisine yazdırma işlemi
            var result9 = sentence.Substring(3,4);//3. karekterden itibaren yazdırmaya başlayıp sonrasındaki 4 karekteri yazdırır. (virgül koymazsan itibaren hepsini yazar)
            var result10 = sentence.ToLower();//bütün karekterleri küçük harfe çevirir
            var result11 = sentence.ToUpper();//hepsini büyük harfe çevirir
            var result12 = sentence.Replace(" ","-");//belirtilen karekteri belirtilen karektere çevirir
            var result13 = sentence.Remove(2,5);//2. karekterden itibaren cümle 4 karekter daha yazılır (, kullanmazsan hiçbirini yazmaz)

            Console.WriteLine(result13);

            Console.ReadLine();
        }
        static void Intro()
        {
            string city = "İstanbul";
            //Console.Write(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Ankara";

            Console.WriteLine(string.Format("{0},{1}", city, city2));//stringleri birleştirmek için kullandık
        }
    }
}
