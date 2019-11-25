using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// узнать количество строк в тексте
// узнать количество букв в тексте

namespace Lines_in_the_text
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "He said the government would of structural defences\nfor the lagoon city, referring to the so-called\nMose project - a hydraulic\nbarrier system to shut of rising sea levels and winter storms.";
            bool mylineIsTrue = text.Contains("\n");
            char[] line = text.ToCharArray();
            int numberLines = 1;
            int numberletters1 = 0;
            int numberletters2 = 0;
            int numberletters3 = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '\n')
                {
                    numberLines++;
                }

                if (line[i] != ' ')
                {
                    if (line[i] != '.')
                    {
                        if (line[i] != ',')
                        {
                            if (line[i] != '"')
                            {
                                if (line[i] != '!')
                                {
                                    if (line[i] != '?')
                                    {
                                        if (line[i] != ':')
                                        {
                                            if (line[i] != ';')
                                            {
                                                if (line[i] != '\n')
                                                {
                                                    if (line[i] != '-')
                                                    {
                                                        numberletters1++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (line[i] != ' ' &
                    line[i] != '.' &
                    line[i] != ',' &
                    line[i] != '"' &
                    line[i] != '!' &
                    line[i] != '?' &
                    line[i] != ':' &
                    line[i] != ';' &
                    line[i] != '\n'&
                    line[i] != '-')
                {
                    numberletters2++;
                }


            }
            Console.WriteLine($"Количество строк в тексте = {numberLines}");
            Console.WriteLine($"Количество букв в тексте (метод 1) = {numberletters1}");
            Console.WriteLine($"Количество букв в тексте (метод 2) = {numberletters2}");
            Console.WriteLine(mylineIsTrue);
            Console.WriteLine(text);
        }
    }
}
