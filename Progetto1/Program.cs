// include libraries (classes/namespaces)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//declaring namespace)
namespace Progetto1
{
       //declaring class
    class Program
    {
        //declaring method
        static void Main(string[] args)
        {
            string name;
            //instructions
            Console.WriteLine("Welcome in C#!, This script takes your name and prints it");
            Console.WriteLine("...");
            Console.Write("What's your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Ciao " + name);
            Console.Read();

        }
    }
}
