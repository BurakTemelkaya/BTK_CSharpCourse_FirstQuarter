using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Demiroğ", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }
    [ToTable("Customers")]//dinamik sorgular için kullanılır
    //[ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")]//eski sürümü belirtmek için [Obsolete] kullanılır
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Added", customer.Id, customer.FirstName,customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = true)]//nerelere eklenebileceğini kısıtlama | kullanarak birden fazla eklenebilir 
    class RequiredPropertyAttribute: Attribute// allowMultiple birden fazla yerden kullanılabilir // false kullanılamaz demek
    {

    }
    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        private string _TableName;

        public ToTableAttribute(string tableName)
        {
            _TableName = tableName;
        }
    }
}
