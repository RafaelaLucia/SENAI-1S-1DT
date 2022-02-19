using System;

namespace Sistema_de_produtos
{
    class Program
    {
        static string resposta;
        static int tamanhoArraia = 2;
        static int c = 0;
        static bool condicao = false;
        static bool[] desconto = new bool[10];
        static string[] nome = new string[tamanhoArraia];
        static float[] preco = new float[tamanhoArraia];
        static string[] promocao = new string [tamanhoArraia];
        static string[] mostrarDesconto = new string[tamanhoArraia];
        static string aumentar;
        
        static void Main(string[] args)
        {
         
           Console.WriteLine("Bem vindo a lojinha: ");
        do
        {
           Menu();
           string opcao = Console.ReadLine();

           switch (opcao)
           {
               case "1":
               do
               {
                   if(c < tamanhoArraia){

                    cadastro();
                    
                    Console.WriteLine("Deseja Cadastrar outro produto? (s/n)");
                    resposta = Console.ReadLine().ToLower();
                    c++;
                   }else{
                       Console.WriteLine("Você já chegou ao seu limite de cadastros!");
                       condicao = true;
                    //    Console.WriteLine("Deseja aumentar sua lista?(s/n)");
                    //    aumentar = Console.ReadLine();
                   }

                   if(aumentar == "s"){
                      aumentarLista();
                   }
                   

                } while (resposta == "s");

                   break;

               case "2":
                   listar();
                   break;

               case "0":
                Console.WriteLine("Obrigado por utilizar nosso sistema :)");
                condicao = true;
                break;

               default:
               Console.WriteLine("Opção Inválida!");
               
                   break;
           }

           } while (!condicao);
        }


        static void Menu() {
         Console.WriteLine(@"
|=============================|
|    Selecione Uma opção:     |
|=============================|
|    1 - Cadastrar Produto    |  
|    2 - Listar Produtos      |
|    0 - Sair                 |
|=============================|
         ");

        if(c > tamanhoArraia){
        Console.WriteLine(@"
|=============================|
|    Selecione Uma opção:     |
|=============================|
|    1 - Aumentar Lista       |  
|    2 - Listar Produtos      |
|    0 - Sair                 |
|=============================|
         ");
        }
        }

        static void cadastro(){
        Console.WriteLine("Insira o nome do produto: ");
        nome[c] = Console.ReadLine();


        Console.WriteLine("Insira o preço do produto: ");
        preco[c] = float.Parse(Console.ReadLine());

        Console.WriteLine("Este produto está em promoção? (s/n)");
        promocao[c] = Console.ReadLine();
        if(promocao[c] == "s"){
        desconto[c] = true;
        }

        }

        static void listar(){

        Console.WriteLine($@"
|=======================================|
|   Nome       Preço       Promoção     |
|=======================================|");    
        for (var i = 0; i < c; i++)
        {
        if(desconto[i] == true){
           mostrarDesconto[i] = "Em promoção";
        } else if(desconto[i] == false){
           mostrarDesconto[i] = "Preço comum";
        }
Console.WriteLine($@"
 - {nome[i]}       R${preco[i]}       {(mostrarDesconto[i])}");
        }
Console.WriteLine("_______________________________________");
      }
 
      static void aumentarLista(){
        Console.WriteLine("Deseja adicionar mais quantas listas?");
        int tamanhoLista = int.Parse(Console.ReadLine());
        tamanhoArraia = tamanhoLista;
        Array.Resize(ref nome, tamanhoArraia);
        Array.Resize(ref preco, tamanhoArraia);
        Array.Resize(ref promocao, tamanhoArraia);

      }
    }

 
    
}
