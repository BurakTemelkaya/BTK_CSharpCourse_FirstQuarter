using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{ FirstName="Burak"},
                new Student{ FirstName="Engin"},
                new Person{FirstName="Eren"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
    }

    class Person2
    {

    }

    class Customer:Person//child parent gibi
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }

}
