using System;

namespace ExemploConversorMoeda
{
    class ConversorEuroReal
    {
        private double euro = 6.20;

        public double converter(double quantidade)
        {
            return quantidade * euro;
        }

        public void MudarValorEuro(double novoValor)
        {
            if(novoValor > 0)
            {
                euro = novoValor;
            }
        }

    }
}