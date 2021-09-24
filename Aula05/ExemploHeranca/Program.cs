using System;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Cavalo mangalarga = new Cavalo("Pé de Pano");

            Humano sapiens = new Humano("José");

            Morcego vampiro = new Morcego("Batman");

            Console.WriteLine("******* CAVALO ********");
            mangalarga.getNomeAnimal();
            mangalarga.CuidarFilhotes();
            mangalarga.Respirar();
            mangalarga.Galopar();

            Console.WriteLine("******* HUMANO ********");
            sapiens.getNomeAnimal();
            sapiens.Pensar();
            sapiens.Respirar();

            Console.WriteLine("******* MORCEGO ********");
            vampiro.getNomeAnimal();
            vampiro.Voar();

            
        }
    }
}
