using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.klasy;
using System.IO;
namespace ConsoleApp1.klasy
{
    internal class funkcje
    {

    }

    internal class Quizy
    {

        public void load()
        {


            ;

            Console.WriteLine("podaj nazwe pliku quizu w folderze quizy");

            string nazwa = "quizy/" + Console.ReadLine();

            string[] zawartosc = File.ReadAllLines(nazwa);

            int lenght = zawartosc.Length;

            Console.WriteLine(lenght);

            Console.ReadKey();

        }






    }

    
}
