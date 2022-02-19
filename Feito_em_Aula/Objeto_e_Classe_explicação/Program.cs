using System;

namespace Objeto_e_Classe_explicação
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string novos;
            string jogarDnv;
            bool condicao = true;
            bool novo = true;

            while (novo == true)
            {
    
            Console.WriteLine("Qual o nome do primeiro personagem?");
            string nome1 = Console.ReadLine();

            Console.WriteLine("Qual o nome do segundo personagem? ");
            string nome2 = Console.ReadLine();

            Console.WriteLine($"Qual a idade do(a) {nome1}");
            int idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual a idade do(a) {nome2}");
            int idade2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Quanto de vida {nome1} tem?");
            int vida1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual de vida {nome2} tem?");
            int vida2 = int.Parse(Console.ReadLine());
            
            Personagem persona1 = new Personagem(); //nome da instancia = tony
            persona1.nome = nome1;
            persona1.idade = idade1;
            persona1.armadura = "Escudo";
            persona1.pontoVida = vida1;

            Personagem persona2 = new Personagem();
            persona2.nome = nome2;
            persona2.idade = idade2;
            persona2.armadura = "Capa maneira";
            persona2.pontoVida = vida2;

Console.WriteLine($@"
Personagem 1:
Nome: {nome1}
Idade: {idade1}

Personagem 2:
Nome: {nome2}
Idade: {idade2}
");
            
Console.WriteLine("Jogar? (s/n)");
string escolha = Console.ReadLine().ToLower();

if (escolha == "s")
{

while (condicao == true) // erro no if novos
{

    while (persona1.pontoVida > 0 && persona2.pontoVida >0)
    {
            Console.WriteLine(@"
Selecione a opção do personagem 1
    1 - Atacar
    2 - Defender
            ");

            int opcaoP1 = int.Parse(Console.ReadLine());

            Console.WriteLine(@"
Selecione a opção do personagem 2
    1 - Atacar
    2 - Defender
            ");

            int opcaoP2 = int.Parse(Console.ReadLine());
            
            if (opcaoP1 == 1 && opcaoP2 == 1)
            {
                persona1.pontoVida = persona1.pontoVida - persona2.Atacar(); 

                persona2.pontoVida = persona2.pontoVida - persona1.Atacar(); 

            }else if (opcaoP1 == 1 && opcaoP2 == 2)
            {
                persona2.pontoVida = persona2.pontoVida - (persona1.Atacar() - persona2.Defender());

            }else if (opcaoP1 == 2 && opcaoP2 == 1)
            {
                persona1.pontoVida = persona1.pontoVida - (persona2.Atacar() - persona1.Defender());
                
            }else if (opcaoP1 == 2 && opcaoP2 == 2)
            {
               
            }

            Console.WriteLine($"Vida do {nome1} : {persona1.pontoVida}");
            Console.WriteLine($"Vida do {nome2} : {persona2.pontoVida}");
    }

             if(persona1.pontoVida == persona2.pontoVida){
                Console.WriteLine("Empate!");
                }else if (persona2.pontoVida <= 0){
                Console.WriteLine($"O {nome1} Venceu!");
                }else if(persona1.pontoVida <= 0){
                Console.WriteLine($"O {nome2} Venceu!");
                } 

             Console.WriteLine("Deseja jogar novamente? (s/n)");
             jogarDnv = Console.ReadLine().ToLower();

                if(jogarDnv == "s"){
                Console.WriteLine("Deseja jogar com novos personagens? (s/n)");
                novos = Console.ReadLine().ToLower();

                if (novos == "s")
                {
                novo = true;
                condicao = false;    
                }else if (novos == "n"){
                persona1.pontoVida = vida1;
                persona2.pontoVida = vida2;
                condicao = true;
                novo = false;
                }

                }else if(jogarDnv == "n"){
                condicao = false;
                novo = false;
                }
}

}else if(escolha == "n"){
  Console.WriteLine("Quem sabe na próxima :)");
}   


}
       }
    }
}
