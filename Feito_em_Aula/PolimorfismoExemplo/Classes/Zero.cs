namespace PolimorfismoExemplo.Classes
{
    public class Zero : Player
    {
        private string Sword;

        public override string Pular() // escrevo override quando quero pegar da classe pai e sobescrever a informacao do pai
        {
            return "O Zero pulou de maneira espetacular!";
        }
    }
}