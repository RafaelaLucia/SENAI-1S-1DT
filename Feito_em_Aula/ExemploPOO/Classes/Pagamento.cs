using System;

namespace ExemploPOO.Classes
{
    public class Pagamento
    {
       private DateTime Data = DateTime.Now.Date; 

       protected float Valor = 2599f; //valor fixo de exemplo

       public string Cancelar(){
           return "Pagamento Cancelado";
       }
    }
}