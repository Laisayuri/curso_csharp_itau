using System;

namespace ExemploHeranca
{
    class Baleia : Mamiferos
    {
        //Construtor com o nome
        public Baleia(string nomeAnimal):base(nomeAnimal)
        {

        }

        //Métodos próprios/exclusivos
        public void Nadar()
        {
            Console.WriteLine("Sou capaz de nadar.");
        }
    }
}