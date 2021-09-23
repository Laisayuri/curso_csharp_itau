using System;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro celtaPreto = new Carro();
            Console.WriteLine(celtaPreto.getInfoCarro());

            Carro impala67 = new Carro(190.2,480.4);
            Console.WriteLine(impala67.getInfoCarro());
            
 
        }
    }
}
