using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.loader
{
    internal class loader1e0
    {



        public int allpytan = 0;

        public int lprawidadp = 0;

        public string[] zawartos = null;

        public void StartLoader(string[] zawartosc3)
        {
            Console.WriteLine("uruchomiono loader");
            Console.WriteLine("wersja alpha1.0");

            zawartos = zawartosc3;

            detectquestions();

            loadpytanie(3);
            
        }

        public void detectquestions()
        {
            int v = zawartos.Length;
            int j = 0;
            while (j != v)
            {

                if (zawartos[j] == "begin-quiz-question")
                {

                    allpytan = allpytan + 1;


                }

                j = j + 1;


            }

            

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

                string odp = null;

                pytanie = zawartos[position + 1];

                string strliczbodp = zawartos[position + 2];

                int liczbaodp = (Convert.ToInt16(strliczbodp));
                
                string strprawidlodp = zawartos[position + 3];

                int prawidodp = (Convert.ToInt16(strprawidlodp));

                int i = 0;

                Console.WriteLine(pytanie);

                while (i != liczbaodp)
                {

                    
                    string test2 = zawartos[position + 4 + i];

                    Console.WriteLine($"{i + 1} - {test2}");


                    i = i + 1;
                }



                odp = Console.ReadLine();

                int intdop = Convert.ToInt16(odp);

                if (intdop == prawidodp)
                {

                    lprawidadp = liczbaodp + 1;

                    Console.WriteLine("poprawna odpowiedź");

                }
                else
                {

                    Console.WriteLine("niepoprawna odpowiedź");


                }









            }
            else
            { Console.WriteLine("błąd wczytywania pytania"); }
            
        }
    
    








    }
}
