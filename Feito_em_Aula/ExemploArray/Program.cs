using System;

namespace ExemploArray
{
    class Program
    {
        static void Main(string[] args)
        {

            // int idade = 20; forma normal que estamos acostumados
            int[] idades = {20, 25, 30, 35}; //array

            // Console.WriteLine(idades [0]); 0 é a primeira posição, o programa identifica 0 como 1º 
            // Console.WriteLine(idades [1]);
            // Console.WriteLine(idades [2]);
            // Console.WriteLine(idades [3]);

            // "for" facilita a escrita do código
            for (var i = 0; i <= 3; i++)
            {
              Console.WriteLine(idades[i]);
            }

            Console.WriteLine("==================");

            // normalmente o exemplo acima não é muito utilizado, é mais usado o array para guardar uma informação dada pelo usuário:
            int[] anos = null;
            
            Console.WriteLine("Quantas idades você deseja cadastrar?");
            int quantidadeanos = int.Parse(Console.ReadLine());
            
            anos = new int [quantidadeanos]; //quantas novos inteiros vai ter nessa lista? isso quem decide é o usuário, uma forma de explicar o new int

             for (int i = 0; i < quantidadeanos; i++) //se eu quiser 3 valores e colocar <= os valores vão ser cadastrados em 0,1,2,3 então vai cadastrar 4 valores ao inves de 3. se precisar mesmo do <= coloque um -1 depois do lenght

             {
               Console.WriteLine("Digita a " + (i + 1) + "ª idade");
                anos[i] = int.Parse(Console.ReadLine()); 
             }

             Console.WriteLine("========================");
             Console.WriteLine("As idades cadastradas foram: ");

            //  for (var i = 0; i < quantidadeanos; i++)
            //  {
            //     Console.WriteLine( (i + 1) + "ª idade: " + anos[i]);
            //  }
             
             int c = 1; //esse c é de contador (uma letra apenas pra facilitar a escrita), tem a mesma função do i acima
             foreach (var item in anos) // mesma coisa do for acima, mas simplifica quando queremos somente mostrar a lista (array) novamente pro usuário
             {
                Console.WriteLine($"{c} ª idade: {item}"); // { interpolar } uma forma de escrever, diferente da concatenação acima. quando usamos interpolar nao precisamos usar + e podemos usar apenas uma aspas
                c++;
             }

        }
    }
}
