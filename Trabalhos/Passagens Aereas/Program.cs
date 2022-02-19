using System;

namespace Passagens_Aereas
{
    class Program
    {
        static void Main(string[] args)
        {
         
        string[] nome = new string[5];
        string[] origem = new string[5];
        string[] destino = new string[5];
        string[] data = new string[5];
        int menu = 0;
        bool cadastro = false;
        int c = 0;
        string novoC = "";
        bool novoCada = false;
            
        Console.WriteLine("Para acessar o menu, informe a senha: ");
        string Senha = (Console.ReadLine());

        if(Senha == "senha1234"){
        Console.WriteLine("Senha correta!");
        
do
{
Console.Write("\n");
Console.Write($@"
O que você deseja fazer?
1 - Cadastrar Passagem
2 - Listar Passagens 
0 -Sair");
Console.Write("\n");
Console.Write("-> ");
menu = int.Parse(Console.ReadLine()); 
    

            switch (menu)
            {

            case 1:
               do
               { 
                 Console.Write("Insira o nome do passageiro(a): ");
                 nome[c] = Console.ReadLine();
                 Console.Write("Insira a Origem do passageiro(a): ");
                 origem[c] = Console.ReadLine();
                 Console.Write("Insira o Destino do passageiro(a): ");
                 destino[c] = Console.ReadLine();
                 Console.Write("Insira a Data do Voo: ");
                 data[c] = Console.ReadLine();
                 c++;

                 Console.Write("Cadastro realizado com sucesso!" + "\n");
                 Console.Write("Deseja cadastar mais uma passagem? (s/n)" + "\n");
                 novoC = Console.ReadLine().ToLower();

                 if(c == nome.Length)
                 {
                    Console.WriteLine("Você chegou ao limite de 5 cadastros!");
                    novoCada = true;
                    cadastro = true;
                    break;
                 }
                 else
                 {
                     if(novoC == "s"){
                     cadastro = false;
                     }else{
                     cadastro = true;
                     novoCada = true;
                    }
                 }
                
                }while(novoCada == false);
                 
                break;

            case 2:
            {
             for (var i = 0; i < c; i++)
            {
Console.WriteLine($@"
{i+1}º Nome: {nome[i]} 
Destino: {origem[i]}
Origem: {destino[i]}
Data: {data[i]} ");    
            }  
            }

            break;

            case 0:
            Environment.Exit(0);
            cadastro = false;
            break;

            default:
            Console.WriteLine("Essa opção não é válida");
            cadastro = true;
            break;
            }
                      
        } while (cadastro == true);
        
        
        } else {
        Console.Write("Senha incorreta, tente novamente");
        }
    }
  }
}
