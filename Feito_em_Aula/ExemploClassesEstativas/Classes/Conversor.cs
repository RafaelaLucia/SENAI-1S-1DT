namespace ExemploClassesEstativas.Classes
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.23f;

        public static float RealParaDolar(float valorRS){
            return valorRS / cotacaoDolar;
        }

        public static float DolarParaReal(float valorUS) {
            return valorUS * cotacaoDolar; 
        }
    }

}