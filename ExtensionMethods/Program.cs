using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FirstName = "Peter";

            person.LastName = "Aaagaard";
             
            person.printFirstName();
            person.DoSomethingFunky();

            person.PrintFullName();

            Console.ReadLine();
        }
    }


    public static class Extensions
    {
        public static void PrintFullName(this Person person)
        {
            Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
        }
    }


    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string Password { get; set; }

        public void printFirstName()
        {
            Console.WriteLine(this.FirstName);
        }

        public void DoSomethingFunky()
        {
            Console.WriteLine("Hello, this is funky");
        }
    }
}
