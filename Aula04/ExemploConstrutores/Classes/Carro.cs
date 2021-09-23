using System;

namespace ExemploConstrutores
{
    class Carro
    {
        //Propriedades da nossa classe
        private int rodas;
        private double comprimento;
        private double largura;
        private bool arCondicionado;
        private string kitMultimidia; //Android Car + Carplay + tela 10", Radio CD MP3

        
        //Construtor(es)
        public Carro()
        {
            rodas = 4;
            largura = 173.2;
            comprimento = 409.3;
        }

        public Carro(double paramLargura, double paramComprimento)
        {
            largura = paramLargura;
            comprimento = paramComprimento;
        }

        public string getInfoCarro()
        {
            return "Informação do carro:\n Rodas: " + rodas + 
                    "\n Largura: " + largura + 
                    "\n Comprimento: " + comprimento; 
        }
    }
}