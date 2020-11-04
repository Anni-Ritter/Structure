using System;
using System.Linq;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Stack<string>();
            people.Push("Tom");
            people.Push("Bob");
            people.Push("Sam");
            people.Push("Mark");
            people.Push("Felix");
            people.Push("I.N.");
            people.Push("Bang Chan");
            people.Push("Han");
            people.Push("Minho");
            people.Push("Alex");
            people.Push("Ten");


            foreach (var items in people)
            {  
                Console.WriteLine(items);
            }
        }
    }
}
