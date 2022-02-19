using System;

namespace NúmerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número romano de 1 a 10 para conversão");
            string número  = Console.ReadLine() .ToUpper();

            switch (número) 
            {
                case "I":
                     Console.WriteLine("Esse número em algarismos Indo-Arábicos é 1");
                    break;

                case "II":
                     Console.WriteLine("Esse número em algarismos Indo-Arábicos é 2");
                    break;

                case "III":
                     Console.WriteLine("Esse número em algarismos Indo-Arábicos é 3");
                    break;

                case "IV":
                     Console.WriteLine("Esse número em algarismos Indo-Arábicos é 4");
                    break;

                case "V":
                     Console.WriteLine("Esse número em algarismos Indo-Arábicos é 5");
                    break;

                case "VI":
                     Console.WriteLine("Esse número em algarismos Indo-Arábicos é 6");
                    break;

                case "VII":
                     Console.WriteLine("Esse número em algarismos Indo-Arábicos é 7");
                    break;

                case "VIII":
                     Console.WriteLine("Esse número em algarismos Indo-Arábicos é 8");
                    break;

                case "IX":
                     Console.WriteLine("Esse número em algarismos Indo-Arábicos é 9");
                    break;

                case "X":
                     Console.WriteLine("Esse número em algarismos Indo-Arábicos é 10");
                    break;

                default:
                    Console.WriteLine("Esse número ou letra não é válido para conversão, selecione um número romano de 1 a 10");
                    break;
                    
            }
        }
    }
}
