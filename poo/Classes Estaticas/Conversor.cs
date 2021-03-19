namespace Classes_Estaticas
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.10f;
        public static float valorUsuario;
        public static float ConverterDolarParaReal(){
            return valorUsuario * cotacaoDolar;
        }

        public static float ConverterRealParaDolar(){
            return valorUsuario / cotacaoDolar;
        }
    }
}