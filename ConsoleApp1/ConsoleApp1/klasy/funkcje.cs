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

            if (zawartosc[0] == "begin-quiz-file")
            {

                Console.WriteLine("poprawnie wczytano plik");

                loaderchose(zawartosc);



            }
            else
            {
                Console.WriteLine("błąd nie poprawny plik");

            }

        }


        private void loaderchose(string[] zaw)
        {

            if(zaw[2] == "alpha1.0")
            {

                loaderalpha1e0(zaw);




            }


            


        }

        public void loaderalpha1e0(string[] zawartosc)
        {

            int len = zawartosc.Length;
            int i = 2;
            bool Stop = false;
            while(i != len || Stop == true)
            {

                
                    

            }

        }

    }   

    
}
