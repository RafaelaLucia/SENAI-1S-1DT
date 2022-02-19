using System;

namespace Exercício4
{
    class Program
    {
        static void Main(string[] args)
        {
            //teste com loop
            int numerop = 0;
            int numerof = 1;
            int fibo;

            for (int valor = 0; valor < 14; valor++)
            {
                fibo = numerop + numerof;
                numerop = numerof;
                numerof = fibo;
                Console.WriteLine(fibo);

            }
             Console.WriteLine("====================================");
            //teste com while
            int f = 1;
            int p = 1;
            int Fibo = 0;
           
            while(Fibo <500)
            {
                Fibo = p + f;
                Console.WriteLine(Fibo);
                p = f;

                f = Fibo;
            }
        }
    }
}
