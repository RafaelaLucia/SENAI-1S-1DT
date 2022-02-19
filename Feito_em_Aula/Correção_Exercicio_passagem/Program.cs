using System;

namespace Correção_Exercicio_passagem
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;
            string senhaCorreta; //colocadas antes do "do" porque quando criadas depois ele nao "acha" elas
            string resposta = "s";

            int c = 0;      
            int tamanhoArrays = 5; //pra nao ter que repetir o numero e facilitar se esse valor ser, futuramente, mudado
            string[] nomes = new string[tamanhoArrays];
            string[] origens = new string[tamanhoArrays];
            string[] destinos = new string[tamanhoArrays];
            string[] datas = new string[tamanhoArrays];
            
            bool condicao = false;


            do // esse do é so uma abertura, o que se repete, e o que é importante, é o while. é importante saber onde começar a abertura desse loop
            {
                Console.WriteLine("Digite a senha para acessar o sistema");
                senha = Console.ReadLine();

                senhaCorreta = "123456";

                if (senha == senhaCorreta)
                {
                    Console.WriteLine("Senha Correta :D");
                do
                {
                    Console.WriteLine(@"
|=======================================|
|    SELECIONE UMA DAS OPÇÕES ABAIXO:   |
|=======================================|
|       1 - Cadastrar passagens         |
|       2 - Listar passagens            |
|       0 - Sair                        |
|=======================================|                    
                    ");
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1": // se o case fosse um int so seria preciso colocaro numero, mas como é uma string precisamos por aspas 
                            
                        do
                        {  
                         if(c < tamanhoArrays)
                         {
                           Console.WriteLine("Digite o nome do passageiro(a)");
                           nomes[c] = Console.ReadLine();

                           Console.WriteLine("Digite a origem do passageiro(a)");
                           origens[c] = Console.ReadLine();

                           Console.WriteLine("Digite o destino do passageiro(a)");
                           destinos[c] = Console.ReadLine();

                           Console.WriteLine("Digite a data da viagem");
                           datas[c] = Console.ReadLine();

                          Console.WriteLine("Ótimo, Deseja Cadastrar outra passagem? (s/n)");
                          resposta = Console.ReadLine().ToLower();
                          c++;
                         
                         }else{
                            Console.WriteLine("Você já chegou ao seu limite de cadastros!");
                            resposta = "s";
                        }
                        
                        }while (resposta == "s");

                        break;

                        case "2":
                            
                                Console.WriteLine("Nome     Origem      Destino     Data");
                            for (var i = 0; i < tamanhoArrays; i++)
                            {
                                Console.WriteLine($"{nomes[i]}      {origens[i]}      {destinos[i]}     {datas[i]}");
                            }

                            break;

                        case "0":
                            Console.WriteLine("Obrigado por utilizar nosso sistema, volte sempre!");
                            condicao = true;
                            break;

                        default:
                            Console.WriteLine("Opção inválida! digite uma opção válida: ");
                            break;
                    }
                    
                    } while (!condicao); // mesma coisa que escrever == false    
                    
                }
                else
                {
                    Console.WriteLine("Senha Incorreta, tente Novamente: ");
                }

            } while (senha != senhaCorreta); // quando só existe uma condição nao tem necessidade de colocar um bool true ou false, mas dentro do funcionamente do programa provavelmente vai ser preciso, mas aqui é so para identificar a senha certa
        }
    }
}
