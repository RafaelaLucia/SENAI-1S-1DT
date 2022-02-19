namespace ExemploObjetoArgumento.Classes
{
    public class Produto // coisa aleatoria: As classes são escritar no singular :o
    {
        public int Codigo { get; set; }             
        public string Nome { get; set; }    
        public float Preco { get; set; }

        public Produto(){}
        public Produto(int _codigo, string _nome, float _preco){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
              
        }
    }
}