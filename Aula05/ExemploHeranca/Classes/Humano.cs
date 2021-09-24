using System;

namespace ExemploHeranca
{
    class Humano : Mamiferos
    {
        //Construtor
        public Humano(string nomeAnimal):base(nomeAnimal)
        {

        }

        public override void Pensar()
        {
            Console.WriteLine("Sou capaz de pensar.");
        }
    }
}