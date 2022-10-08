using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1.klasy
{   
    internal class ExpDataoplib 
    { 
    
    public void odczytlinie (string path,string print)
        {
            
           string[] zaw = File.ReadAllLines(path);

           string testc = zaw[2];
           
           if (print == "1") 
            {
                Console.WriteLine(testc);
            
            
            
            }
            
        }
    
    
    
    
    
    
    
    
    }



    internal class Dataoplib
    {

        public string Odczyt(string path)
        {


            string zaw = File.ReadAllText(path);


            return zaw;
        }

        public string Odczytlinie(string Path, int linia) 
        {
// odczytywanie z pojedynczej lini



            return "nic";
        
        
        }
        

        public bool Zapis(string path)
        {
            

            return false;
        }

        




    }
}
