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

                string liczbodp = 

                prawidlodp = 
                
            }
            
        }
    
    








    }
}
