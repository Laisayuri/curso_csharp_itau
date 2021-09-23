using System;

namespace ExemploConstrutores
{
    class Carro
    {
        //Propriedades da nossa classe
        private string marca;
        private string modelo;
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
            marca = "ND";
            modelo = "ND";
        }

        public Carro(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.rodas = 4;
        }

        public Carro(double largura, double comprimento,string marca,string modelo)
        {
            rodas = 4;
            this.largura = largura;
            this.comprimento = comprimento;
            this.marca = marca;
            this.modelo = modelo;
        }

        public string getInfoCarro()
        {
            return "*** Informação do carro:\n Rodas: " + rodas + 
                    "\n Largura: " + largura + 
                    "\n Comprimento: " + comprimento +
                    "\n Marca: " + marca +
                    "\n Modelo: " + modelo;
        }
    }
}