using System.Collections.Generic;
using System.IO;

namespace Eplayers.Models
{
    public class EPlayersBase
    {
        public void CriarPastaEArquivo (string _caminho)
        {
           string pasta = _caminho.Split("/")[0];
           string arquivo = _caminho.Split("/")[1];

           if (!Directory.Exists(pasta))
           {
              Directory.CreateDirectory(pasta); 
           }

           if (!File.Exists(_caminho))
           {
              File.Create(_caminho).Close();
           }
         }

         public List<string> LerTodasLinhascsv(string _caminho)
          {
            List<string> linhas = new List<string>();
            
            using (StreamReader file = new StreamReader(_caminho)) //file = arquivo provisorio, lista ler arquivo, se NAO estiver cheio adicionar linha
            {
                string linha;
                while ((linha = file.ReadLine()) != null)
                {
                   linhas.Add(linha);
                }
            }
            return linhas;
         }

         public void RescreverCSV(string _caminho, List<string> linhas) //alteração apos ler lista
         {
            using (StreamWriter output = new StreamWriter(_caminho))
            {
               foreach (var item in linhas)
               {
                  output.Write(item + "\n"); //\n pq o writeline nao quer funcionar
               } 
            }
         }
   }
}