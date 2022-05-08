using System;
namespace ListaExercicio02.Questao04
{
    public class Pessoa
    {
        public string nome { get; set; }
        public CertidaoNascimento certidaoNascimento { get; private set; }

        public Pessoa(string inputNome)
        {
            nome = inputNome;
        }
    }
}
