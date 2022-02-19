using System;

namespace maria
{
    class Program
    {
        static void Main(string[] args)
        {
           
           // vai contar em ordem decrescente, do 200 até o 100 e parar quando chegar no 100, como é decrescente utiliza -- ao invés do ++, ou o nome = ao nome - 1
          for (var contador = 200; contador >= 100; contador = contador - 1)
          {
              Console.WriteLine("Contador: " + contador);
          }
          // contador -- 
          // contador = contador - 1

          // vai contar de 0 a 10 e parar quando chegar ao 10, é crescente então ++
          for (var contador2 = 0; contador2 < 10; contador2++)
          {
              Console.WriteLine("Contador: " + contador2);
          }

        }
    }
}
