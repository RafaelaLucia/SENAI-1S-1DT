using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nomeValor = false;

            Console.WriteLine("Insira seu nome: ");
            string nome = Console.ReadLine();

            while (nomeValor == false)
            {
                if (nome != "")
                {
                    Console.WriteLine("Nome válido");
                    nomeValor = true;
                }
                else
                {
                    Console.WriteLine("O nome não pode ser vazio");
                    nome = Console.ReadLine();
                }
            }

            bool idadeValor = false;

            Console.WriteLine("Insira sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            while (idadeValor == false)
            {
                if (idade >= 0 && idade <= 150)
                {
                    Console.WriteLine("Idade válida");
                    idadeValor = true;
                }
                else
                {
                    Console.WriteLine("Essa idade não é válida");
                    idade = int.Parse(Console.ReadLine());
                }
            }

            bool valorSalario = false;
            string salarioS = "";

            while (valorSalario == false)
            {
                Console.WriteLine("Insira seu salário: ");
                salarioS = Console.ReadLine();

                if (salarioS == "")
                {
                    salarioS = "0";
                }

                float salario = float.Parse(salarioS);

                if (salario > 0)
                {
                    Console.WriteLine("Salário válido");
                    valorSalario = true;
                }
                if (salario <= 0)
                {
                    Console.WriteLine("Salário inválido, tente novamente");
                }
            }

            bool valEstado = false;
            string estadoC = "";

            while (valEstado == false)
            {
                Console.WriteLine("Insira seu estado civil, utilize 's' para solteiro(a), 'c' para casado(a), 'v' para viuvo(a) e 'd' para divorciado(a)");
                estadoC = Console.ReadLine().ToLower();

                if (estadoC == "s" || estadoC == "c" || estadoC == "v" || estadoC == "d")
                {
                    Console.WriteLine("Estado civil válido");
                    valEstado = true;
                }
                else
                {
                    Console.WriteLine("Estado civil inválido, tente novamente");
                    estadoC = Console.ReadLine().ToLower();
                }
            }

            Console.WriteLine("========================================================");
            Console.WriteLine("O nome inserido foi: " + nome);
            Console.WriteLine("A idade inserida foi: " + idade + " anos");
            Console.WriteLine("O valor do salário inserido foi: " + salarioS + " reais");
            Console.WriteLine("O estado civil inserido foi: " + estadoC);
            Console.WriteLine("========================================================");
        }
    }
}


