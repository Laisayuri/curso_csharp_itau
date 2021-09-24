using System;

namespace ExemploHeranca
{
    class Cavalo : Mamiferos
    {
        //Construtor subclasse
        public Cavalo(string nomeAnimal):base(nomeAnimal)
        {

        }

        //Método próprio da minha classe
        public void Galopar()
        {
            Console.WriteLine("Sou capaz de galopar.");
        }
    }
}