using System;

namespace Média_ex
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Exercício Média");

           Console.WriteLine("qual é a primeira nota?");
        //    int primeiraNota = int.Parse(Console.ReadLine());
           double primeiraNota = double.Parse(Console.ReadLine());

           Console.WriteLine("qual é a segunda nota?");
           double segundaNota = double.Parse(Console.ReadLine());

           Console.WriteLine("qual é a terceira nota?");
           double terceiraNota = double.Parse(Console.ReadLine());

           double media = (primeiraNota + segundaNota + terceiraNota) / 3;

        //    Console.WriteLine("a média das notas foi: " + Math.Round(media, 2));
            //   Console.WriteLine("{0:F1}", media);
            Console.WriteLine("a média das notas foi: " + media.ToString("N1"));
            
            if (media > 5) 
            {
                 // caso a média seja maior que 5, aprovar aluno
                Console.WriteLine("Estudante aprovado(a)!!! :D ");
                Console.WriteLine("Lo studente é passato!!! :D ");
             
            } else {
                // caso contrário, reprovar aluno
                Console.WriteLine("Estudante repovado(a) :( ");
                Console.WriteLine("Lo studente ha fallito :( ");

            }       
        }
    }   
}
