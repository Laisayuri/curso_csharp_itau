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

            /**************************************************
                EXEMPLOS PRINCIPIOS DE SUBSTITUICAO
            *************************************************/
            Cavalo pangare = new Cavalo("Pangaré");
            Mamiferos animal = new Mamiferos("Mamifero");

            animal = pangare;
            animal.getNomeAnimal();
            animal = sapiens;
            animal.getNomeAnimal();
            animal = vampiro;
            animal.getNomeAnimal();

            Mamiferos mamifero1 = new Cavalo("Pangaré");

            //Exemplo armazenar em um Array, diferentes tipos de mamífero
            Mamiferos[] arrayAnimais = new Mamiferos[4];
            arrayAnimais[0] = mangalarga;
            arrayAnimais[1] = pangare;
            arrayAnimais[2] = sapiens;
            arrayAnimais[3] = vampiro;

            //Classe Object nesse caso seria a classe Avô, ela pode
            //receber as subclasses, mas só terá acesso aos seus 
            //métodos proprios/excluivos
            Object obj = pangare;
            

            Console.WriteLine("--------------------------");

            

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
