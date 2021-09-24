using System;

namespace ExemploHeranca
{
    class Mamiferos
    {
        //Propriedade Encapsulada
        private string nomeAnimal;

        //Construtor
        public Mamiferos(string nomeAnimal)
        {
            this.nomeAnimal = nomeAnimal;
        }

        //Defino dois métodos comuns a todos os mamíferos
        public void Respirar()
        {
            Console.WriteLine("Sou capaz de respirar.");
        }

        public void CuidarFilhotes()
        {
            Console.WriteLine("Cuido muito bem dos meus filhotes");
        }

        public void getNomeAnimal()
        {
            Console.WriteLine("- O nome do animal é: " + nomeAnimal);
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Pensamento básico instintivo");
        }

    }
}