using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// узнать количество строк в тексте

namespace Lines_in_the_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "He said the government would accelerate the building of structural defences\nfor the lagoon city, referring specifically to the so-called\nMose project - a hydraulic\nbarrier system to shut off the lagoon in the event of rising sea levels and winter storms.";
            bool myline = text.Contains("\n");
            char[] line = text.ToCharArray();
            int j = 0;
            for(int i = 0; i < line.Length; i++)
            {
                if(line[i] == '\\')
                {
                    j++;
                } 
                                                   
            }
            Console.WriteLine(j);

            Console.WriteLine(myline);
            Console.WriteLine(text);
        }
    }
}
