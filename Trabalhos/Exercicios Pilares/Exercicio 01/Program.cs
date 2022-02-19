using System;
using Exercicio_01.Classes;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condicao = false;
            Elevador e = new Elevador();
            ElevadorServiço s = new ElevadorServiço();

            Console.WriteLine(@"
Qual elevador deseja utilizar? 
1 - Social
2 - Serviço");

            int elevadorEscolha = int.Parse(Console.ReadLine());

            if (elevadorEscolha == 1)
            {
                
            e.Inicializa();
            {
                
            }
            
            do
            {
                
            
            Console.WriteLine(@"
Selecione: 
1 - Entrar
2 - Sair 
3 - Descer elevador
4 - Subir elevador
0 - Parar sistema
");
            int escolha  = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                e.Entrar();
                break;                  
                
                case 3:
                e.Descer();
                    break;

                case 2:
                e.Sair();
                    break;

                case 4:
                e.Subir();
                    break;

                case 0:
                condicao = true;
                break;

                default:
                break;
            }
            } while (!condicao);

            } else if (elevadorEscolha == 2){
            
            s.Inicializa();
            
            do
            {
                
            Console.WriteLine(@"
Selecione: 
1 - Colocar caixas
2 - Retirar caixas
3 - Descer elevador
4 - Subir elevador
0 - Parar sistema
");
            int escolha  = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                s.Entrar();
                break;                  
                
                case 3:
                s.Descer();
                    break;

                case 2:
                s.Sair();
                    break;

                case 4:
                s.Subir();
                    break;

                case 0:
                condicao = true;
                break;

                default:
                break;
            }
            } while (!condicao);
            }
            
        }
    }
}
