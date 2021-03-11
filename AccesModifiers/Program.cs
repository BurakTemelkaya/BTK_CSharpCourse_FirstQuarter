using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //private < protectec < internal < public
    //internal olursa bulunduğu projede kullanılabilir
    //public diğer projelerdede kullanılabilir
    class Customer
    {
        protected int Id { get; set; }//protected aşağıdaki gibi bir yapıda kullanılabilir
        public void Save()
        {
            
        }
        public void Delete()
        {
            
        }
    }
    class Student:Customer
    {
        public void Save2()
        {
            
        }
    }
    public class Course
    {
        public string Name { get; set; }
    }
}
