using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.klasy;
using System.Data;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string version = "indev";

            string phaze = "alpha";

            

            Console.WriteLine("witaj w programie do robienia quizów");

            Console.WriteLine($"version:{phaze}-{version}");

            Console.WriteLine("");

            Quizy fun = new Quizy();

            fun.load();

            Console.ReadKey();

        }
    }
}
