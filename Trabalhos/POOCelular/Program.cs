using System;

namespace POOCelular
{
    class Program
    {
        static void Main(string[] args)
        {

            Celular cel1 = new Celular(); 
            Console.WriteLine("Modelo: " + cel1.modelo);
            Console.WriteLine("Cor: " + cel1.cor);
            Console.WriteLine("Tamanho: " + cel1.tamanho);
            int escolha;
            
            Console.WriteLine("Pressione espaço para ligar: ");
            var ligar = Console.ReadKey();
            Console.WriteLine();

            if (ligar.Key == ConsoleKey.Spacebar){
                cel1.Ligar();
            }

            if(cel1.Ligar()){
                while (cel1.ligado)
                { 
                Console.ForegroundColor = ConsoleColor.Blue; 
                
                Console.WriteLine($@"
 __ ___ ___ ___ ___ ___ ___ ___ __
 |               O               |
 |  ___________________________  |
 | |{DateTime.Now.Hour}:{DateTime.Now.Minute}                  46% | | 
 | |                           | |  
 | |      Bem Vindo(a) :D      | | 
 | |                           | | 
 | |                           | | 
 | | 1 - Ligar para um contato | | 
 | |                           | | 
 | | 2 - Enviar mensagem       | | 
 | |                           | | 
 | | 3 - Mostrar contatos      | | 
 | |                           | | 
 | | 4 - Desligar              | | 
 | |                           | | 
 | |___________________________| | 
 |       <      [ ]       >      |
 |_______________________________|  
   
                    ");
                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                         Console.WriteLine($@"
 __ ___ ___ ___ ___ ___ ___ ___ _
 |               O               |
 |  ___________________________  |
 | |{DateTime.Now.Hour}:{DateTime.Now.Minute}                  46% | |                            
 | |                           | |  
 | |  Ligar para um contato    | |
 | |                           | |
 | |    digite o contato:      | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | | * Thiago                  | | 
 | | * Odirlei                 | | 
 | | * Fulano                  | | 
 | | * Mãe                     | | 
 | |                           | | 
 | |                           | | 
 | |___________________________| | 
 |       <      [ ]       >      |
 |_______________________________|  
   
                    ");  
                    string contato = Console.ReadLine();
                    Console.WriteLine($@"
 __ ___ ___ ___ ___ ___ ___ ___ _
 |               O               |
 |  ___________________________  |
 | |{DateTime.Now.Hour}:{DateTime.Now.Minute}                  46% | | 
 | |                           | |  
 | |  Ligando Para:            | |
 | |  {contato}                  
 | |                           | | 
 | |                           | | 
 | | {cel1.FazerLigacao()}              | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |___________________________| | 
 |       <      [ ]       >      |
 |_______________________________|  
   
                    ");  
                    Console.WriteLine("Chamada não atendida");
                            break;
                        case 2:
                         Console.WriteLine($@"
 __ ___ ___ ___ ___ ___ ___ ___ _
 |               O               |
 |  ___________________________  |
 | |{DateTime.Now.Hour}:{DateTime.Now.Minute}                  46% | | 
 | |                           | |  
 | |     Enviar mensagem       | |
 | |                           | |
 | |    digite o contato:      | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | | * Thiago                  | | 
 | | * Odirlei                 | | 
 | | * Fulano                  | | 
 | | * Mãe                     | | 
 | |                           | | 
 | |                           | | 
 | |___________________________| | 
 |       <      [ ]       >      |
 |_______________________________|  
   
                    ");  
                    string mensagem = Console.ReadLine();
                    Console.WriteLine("Digite sua mensagem:");
                    string msg = Console.ReadLine();
                    
                    Console.WriteLine($@"
 __ ___ ___ ___ ___ ___ ___ ___ _
 |               O               |
 |  ___________________________  |
 | |{DateTime.Now.Hour}:{DateTime.Now.Minute}                  46% | | 
 | |                           | |  
 | | Enviando para: {mensagem} 
 | |                           | |
 | | ________________________  | | 
 | |                           | | 
 | |                           | | 
 | |  {msg}                     
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | | {cel1.EnviarMsg()}         | | 
 | |___________________________| | 
 |       <      [ ]       >      |
 |_______________________________|  
   
                    ");  
                            break;
                        case 4:
                        Console.WriteLine($@"
 __ ___ ___ ___ ___ ___ ___ ___ _
 |               O               |
 |  ___________________________  |
 | |                           | | 
 | |                           | |  
 | |                           | |
 | |                           | |
 | |                           | | 
 | |       Desligando...       | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |                           | | 
 | |___________________________| | 
 |       <      [ ]       >      |
 |_______________________________|  
   
                    ");
                    cel1.Desligar();
                            break;
                            case 3:
                        Console.WriteLine($@"
 __ ___ ___ ___ ___ ___ ___ ___ _
 |               O               |
 |  ___________________________  |
 | |{DateTime.Now.Hour}:{DateTime.Now.Minute}                  46% | | 
 | |                           | |  
 | |                           | |
 | |                           | |
 | |                           | | 
 | |         Contatos:         | | 
 | |___________________________| | 
 | |                           | | 
 | |                           | | 
 | | * Odirlei (11)98945-2664  | | 
 | | * Thiago  (11)92067-5899  | | 
 | | * Fulano  (11)98940-5527  | | 
 | | * Mãe     (11)98754-6620  | | 
 | |                           | | 
 | |___________________________| | 
 |       <      [ ]       >      |
 |_______________________________|  
   
                    "); 
                    break;

                        default:
                        Console.WriteLine("Opção Inválida");
                            break;
                    }
                    
                }
            }
        
        }
    }
}
