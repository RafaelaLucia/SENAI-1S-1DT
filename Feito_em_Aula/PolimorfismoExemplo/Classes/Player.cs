namespace PolimorfismoExemplo.Classes
{
    public abstract class Player 
    {
       private float Velocidade;
       private float ForcaPulo;

       public virtual string Correr() { //vou colocar virtual se por ventura quiser sobescrever ele
        return "O player correu!";
       }
       public virtual string Pular() {
        return "O player pulou!";
       }
    }
}