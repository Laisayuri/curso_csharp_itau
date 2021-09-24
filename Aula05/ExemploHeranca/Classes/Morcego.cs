using System;

namespace ExemploHeranca
{
    class Morcego : Mamiferos,IMamiferosTerrestre
    {
        //Construtor
        public Morcego(string nomeMamifero):base(nomeMamifero)
        {
            //Eu poderia implementar outras coisas para o construtor de morcego
        }

        public void Voar()
        {
            Console.WriteLine("Sou capaz de voar.");
        }

        //Metodo interface
        public int NumeroPatas()
        {
            return 2;
        }
    }
}