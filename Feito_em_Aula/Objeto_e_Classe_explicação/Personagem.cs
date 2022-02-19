namespace Objeto_e_Classe_explicação
{
    public class Personagem
    {
       public string nome;
       public int idade;
       public string armadura; //escrever atributo = letra minuscula

       public int pontoVida;

       public int Atacar() // escrever método = letra maiscula
       {
          int dano = 10;

          return dano;
       }

       public int Defender()
       {
           int defesa = 8;

           return defesa;
       }

    }
}