using System;

namespace ExemploClassesAnonimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classes Anônimas
            var variavelAnonima = new {Nome="José",Idade=19};
            Console.WriteLine(variavelAnonima.Nome);

            var variavelAnonima2 = new {Nome="Maria",Idade=29};
            Console.WriteLine("----------------------------------");
            variavelAnonima = variavelAnonima2;
            Console.WriteLine(variavelAnonima.Nome);
            Console.WriteLine(variavelAnonima2.Nome);
        }
    }
}
