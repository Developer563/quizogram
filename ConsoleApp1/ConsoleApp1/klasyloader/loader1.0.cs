using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.loader
{
    internal class loader1e0
    {

        public string[] zawartos = null;

        public void StartLoader(string[] zawartosc3)
        {
            Console.WriteLine("uruchomiono loader");
            Console.WriteLine("wersja alpha1.0");

            zawartos = zawartosc3;

            loadpytanie(3);
            Console.WriteLine("test49");
        }

        public string litery = "abcdefghijklmnoprs";


        public void start()
        {

            

        }

        public void loadpytanie(int position)
        {
            
            string pytanie = null;

            if (zawartos[position] == "begin-quiz-question")
            {

                pytanie = zawartos[position + 1];

                string strliczbodp = zawartos[position + 2];

                int liczbaodp = (Convert.ToInt16(strliczbodp));

                string strprawidlodp = zawartos[position + 3];

                int prawidodp = (Convert.ToInt16(strprawidlodp));

                int i = 0;

                while (i != liczbaodp)
                {


                    string test2 = zawartos[position + 4 + i];

                    Console.WriteLine(test2);


                    i = i + 1;
                }

                

            }
            else
            { Console.WriteLine("błąd wczytywania pytania"); }
            
        }
    
    








    }
}
