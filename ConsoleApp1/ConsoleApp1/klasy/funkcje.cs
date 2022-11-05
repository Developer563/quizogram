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
            zawart = zawartosc;

            int lenght = zawartosc.Length;

            

            

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

            if (zawart[1] == "loaderversion")
            {

                if (zawart[2] == "alpha1.0")
                {

                    Console.WriteLine("wersja loadera to alpha1.0");

                    Console.ReadKey();

                    loader1e0 load = new loader1e0();

                    load.StartLoader(zawart);

                }







            }
            else
            {

                Console.WriteLine($"błąd wczytywania wersji {zawart[1]}");

            }
        }

            


        

     

    }   

    
}
