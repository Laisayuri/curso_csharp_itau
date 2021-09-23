using System;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro celtaPreto = new Carro("Chevrolet","Celta");
            celtaPreto.setExtras(true,"Radio Android 7");

            Console.WriteLine(celtaPreto.getInfoCarro());
            Console.WriteLine(celtaPreto.getExtras());

            Carro celtaVermelho = new Carro("Chevrolet","Celta");
            celtaVermelho.setExtras(false,"Radio CD MP3");
            Console.WriteLine(celtaVermelho.getInfoCarro());
            Console.WriteLine(celtaVermelho.getExtras());

            /*

            Carro impala67 = new Carro(190.2,480.4,"Chevrolet","Impala");
            Console.WriteLine(impala67.getInfoCarro());

            Carro camaroAmarelo = new Carro("Chevrolet","Camaro");
            Console.WriteLine(camaroAmarelo.getInfoCarro());
            */
            
 
        }
    }
}
