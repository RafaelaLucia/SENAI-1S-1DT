using System;
using PolimorfismoExemplo.Classes;

namespace PolimorfismoExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Megamen m = new Megamen(); //ctrl e . para colocar o using classes ali em cima de maneira mais facil
            Zero z = new Zero();

           Console.WriteLine("Megaman: ");
           Console.WriteLine(m.Correr());
           Console.WriteLine(m.Pular());
           Console.WriteLine("\n");
           Console.WriteLine("Zero: ");
           Console.WriteLine(z.Pular());
           Console.WriteLine(z.Correr());

        }
    }
}
