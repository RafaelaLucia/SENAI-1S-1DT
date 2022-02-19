using System.Collections.Generic;
using System.IO;

namespace mvc.Models
{
    public class Produto
    {
        public int Codigo { get; set; } 
        public string Nome { get; set; }    
        public float Preco { get; set; }    

        private const string PATH = "DataBase/Produto.csv"; // constante guarda nome da pasta e nome do arquivo
        // identificar visualmente uma constante escrever o nome inteiro em caixa alta
        // csv armazena texto mas possui separados e pode ser transformado em planilha no excel
    
        public Produto(){

          string pasta = PATH.Split("/")[0];
          // metodo slip serve para separar uma string, exemplo: linha de texto gigante e vc quer pegar uma linha especifica. nesse caso eu tenho o link do diretorio mas so quero a parte "database" que pode acabar mudando de tamanho (nome) a unica coisa que eu sei é que ele fica antes da barra (Database/Produto.csv) dentro do parenteses do split eu coloco o que eu vou usar de separador, ele vai ler database e parar quando chegar na barra, ele coloca o database na primeira parte do array e o que vem depois da barra na segunda posicao do array

          if (!Directory.Exists(pasta)) //system.io
          // posso simplesmente copiar e colar o nome da pasta "database" mas se eu quiser mudar posteriormente vou ter que mudar singulariamente
          {
              Directory.CreateDirectory(pasta);
          }

          if (!File.Exists(PATH)) // "se NAO existir, crie a pasta"
          {
              File.Create(PATH);
          }
        }

        public List<Produto> Ler(){
           
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";"); //separar por ; no produto dentor da data base            }
                
                Produto prod = new Produto();
                
                prod.Codigo = int.Parse(atributos[0]);
                prod.Nome = atributos[1];
                prod.Preco = float.Parse(atributos[2]);

                produtos.Add(prod);            
            }

            return produtos;
        }

        public string PrepararLinhaCSV(Produto prod){

            return $"{prod.Codigo}; {prod.Nome};{prod.Preco}";
        }

        public void Inserir(Produto produto)
        {
           string[] linhas = {PrepararLinhaCSV(produto)};

           File.AppendAllLines(PATH, linhas);
           
        }
    }
}