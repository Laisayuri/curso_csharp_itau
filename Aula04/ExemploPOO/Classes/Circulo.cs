using System;

namespace ExemploPOO
{
    class Circulo
    {
        //Fórmula para calcular área de um círculo é PI * raio * raio
        //Math.Pow(raio,2) --> Faz a potencia de raio ao quadrado.
        //Math.PI = 3.1416...

        private double pi = 3.1416; //Campo de classe, variável de classe, Propriedade/Atributo
        
        //Método
        public double calcularArea(int raio)
        {
            return pi * raio * raio;
        }

    }
}