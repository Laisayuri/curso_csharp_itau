using System;

namespace ExemploHeranca
{
    class Cavalo : Mamiferos,IMamiferosTerrestre,IAnimaisEsportistas,ISaltoComPatas
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

        public override void Pensar()
        {
            Console.WriteLine("Pensamento algo avançado instintivo");
        }

        //Metodo da interface implementada
        int IMamiferosTerrestre.NumeroPatas()
        {
            return 4;
        }

        int ISaltoComPatas.NumeroPatas()
        {
            return 2;
        }

        public string TipoEsporte()
        {
            return "Hipismo";
        }

        public bool EsporteOlimpico()
        {
            return true;
        }
    }
}