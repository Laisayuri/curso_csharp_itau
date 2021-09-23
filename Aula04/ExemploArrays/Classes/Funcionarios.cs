using System;

namespace ExemploArrays
{
    class Funcionarios
    {
        //Propriedades
        private string nome;
        private string sobrenome;
        private int numeroMatricula;
        private string telefone;

        public Funcionarios(string nome, string sobrenome, int numeroMatricula, string telefone)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.numeroMatricula = numeroMatricula;
            this.telefone = telefone;
        }

        public string getNome()
        {
            return nome;
        }
    }
}