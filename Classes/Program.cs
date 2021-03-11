using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cm = new CustomerManager();
            cm.Add();
            cm.Update();

            ProductManager pm = new ProductManager();
            pm.Add();
            pm.Update();

            Customer customer = new Customer();//ilk kullanım
            customer.City = "İstanbul";
            customer.Id = 1;
            customer.FirstName = "Burak";
            customer.LastName = "Temelkaya";

            Customer customer2 = new Customer()//2. kullanım
            {
                Id=2,City="İstanbul",FirstName="Derin",LastName="Demiroğ"
            };
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }

    
    
}
