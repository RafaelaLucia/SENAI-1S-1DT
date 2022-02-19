namespace POOCelular
{
    public class Celular
    {
       public string modelo = "Moto e(6) plus";
       public string cor = "Azul";
       public string tamanho = "1560x720";
       public bool ligado = false;

       public bool Ligar() 
       {
          return ligado = true;
       }

       public bool Desligar() 
       {
          return ligado = false;
       }

       public string FazerLigacao()
       {
          return "Chamando... ";
       }
       public string EnviarMsg() 
       {
          return "Mensagem enviada!";
       }
      
    }
}