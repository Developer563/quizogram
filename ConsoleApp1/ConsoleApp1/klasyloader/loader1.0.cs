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

            start();

        }

        public string litery = "abcdefghijklmnoprs";


        public void start()
        {

            loadpytanie(4);

        }

        public void loadpytanie(int position)
        {

            string pytanie = null;

            if (zawartos[position] == "begin-quiz-question")
            {

                pytanie = zawartos[position + 1];

                string strliczbodp = zawartos[position + 2];

                int liczbaodp = (Convert.ToInt16(strliczbodp) - 48);

                string strprawidlodp = zawartos[position + 3];

                int prawidodp = (Convert.ToInt16(strprawidlodp) - 48);

                int i = 0;

                while ((i + 1) != liczbaodp) ;
                {

                    Console.WriteLine(zawartos[ position + 4 + i ]);


                    i = i + 1;
                }

            }
            
        }
    
    








    }
}
