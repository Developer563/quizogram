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

            Program obj = new Program();

            obj.menu(0);

        }


        public void menu(int arg)
        {

            if(arg == 0)
            {

                Quizy fun = new Quizy();

                fun.load();

                Console.ReadKey();




            }
            else
            {




            }
            


        }





    }


     
}
