using System;

namespace ExemploPOO
{
    class Quadrado
    {
        public double calcularArea(double lado)
        {
            return Math.Pow(lado,2);
            //Pow -> Potência, elevar algum número a x (Quadrado, elevado a 2)
            
            //double area; 
            //area = lado * lado;
            //return area;
            
            
            //return lado * lado; --> Também está correto.
        }
    }
}