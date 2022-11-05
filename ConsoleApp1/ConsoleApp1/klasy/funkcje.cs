using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.loader;
using System.IO;

namespace ConsoleApp1.klasy
{
    internal class funkcje
    {

    }

    internal class Quizy
    {

        
        private string[] zawart = null;
        public void startload()
        {

            
            

            Console.WriteLine("podaj nazwe pliku quizu w folderze quizy");

            string nazwa = "quizy/" + Console.ReadLine();

            string[] zawartosc = File.ReadAllLines(nazwa);
            

            int lenght = zawartosc.Length;

            

            Console.ReadKey();

            if (zawartosc[0] == "begin-quiz-file")
            {

                Console.WriteLine("poprawnie wczytano plik");


                loadversion(zawartosc);


            }
            else
            {
                Console.WriteLine("błąd nie poprawny plik");

            }

            
            



        }


        
        public void loadversion(string[] wartosc2)
        {



        }

            


        

     

    }   

    
}
