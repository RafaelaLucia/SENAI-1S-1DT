using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
          
          // 1º forma de fazer, i //
            int[] numero = null;
            numero = new int[10];
            int maiorNumero =  0;
            int menorNumero = 0; 

          for (var i = 0; i <= 9; i++)
          {
              Console.WriteLine("Escreva o valor do " + (i + 1) + " º número");
              numero[i]= int.Parse(Console.ReadLine());
 
             if (i == 0){
             maiorNumero = numero[i];
             menorNumero = numero[i]; 
             }

             if(numero[i] > maiorNumero){
              maiorNumero = numero[i];
            }else if(numero[i] < menorNumero){
              menorNumero = numero[i];
            }
          }
            Console.WriteLine("O maior valor lido foi: " + maiorNumero);
            Console.WriteLine("O menor valor lido foi: " + menorNumero); 


            // 2º forma de fazer, array //

            int[] numeros = new int[10];
		
	        	for (int p=0; p<numeros.Length; p++)
	        	{
	      		Console.Write("Digite um número: ");
		      	numeros[p] = Convert.ToInt32(Console.ReadLine());
	        	}
		
	         	Array.Sort(numeros);
	        	Console.Write("\n\n");
	        	foreach (int p in numeros) Console.WriteLine(p);
          	
            Console.WriteLine("O menor número é " + numeros[0]);
	         	Console.WriteLine("O maior número é " + numeros[9]);
     }     
  }
}

