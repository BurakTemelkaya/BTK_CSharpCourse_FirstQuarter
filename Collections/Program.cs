using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table", "Masa");
            dictionary.Add("Computer", "Bilgisayar");

            //Console.WriteLine(dictionary["Table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("Table"));

            Console.ReadLine();
        }
        public void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('a');
            //Console.WriteLine(cities[2]);
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
        public void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine(cities.Contains("Adana"));//değer arar sonuç olarak true false döndürür

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Engin" });
            //customers.Add(new Customer { Id = 2, FirstName = "Derin" });

            List<Customer> customers = new List<Customer>
            {
            new Customer { Id = 1, FirstName = "Engin" },
            new Customer { Id = 2, FirstName = "Derin" }
            };


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Burak"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2] {
            new Customer{Id=4,FirstName="Ali" },
            new Customer{Id=5,FirstName="Ayşe"}
            });

            Console.WriteLine(customers.Contains(customer2));
            //customers.Clear();

            var index = customers.IndexOf(customer2);
            Console.WriteLine(index);

            customers.Add(customer2);
            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine(index2);

            customers.Insert(0, customer2);

            //customers.Remove(customer2);
            //customers.Remove(customer2);
            //customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Burak");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;
            Console.WriteLine("Coutn : {0}", count);
        }
    }
    
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
