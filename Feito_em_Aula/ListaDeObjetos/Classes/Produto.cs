namespace ListaDeObjetos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto() {}
        public Produto(int _codigo, string _nome, float _preco) {
            // this.codigo = _codigo; usar o this pra caso eu nao quisesse usar o _ para diferenciar e o meu int do método tivesse o mesmo nome do objeto, exemplo: this.codigo = codigo; ele possui o mesmo nome mas o this diferencia eles.
            this.Codigo = _codigo; //o this é usado nesse caso mas não precisaria, pois o nome do metodo e do objeto é diferente, mas ta aí :)
            this.Nome = _nome;
            this.Preco = _preco;
        }
        
        
    }
}