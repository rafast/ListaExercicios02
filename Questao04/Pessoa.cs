using System;
namespace ListaExercicio02.Questao04
{
    public class Pessoa
    {
        private CertidaoNascimento certidaoNascimento1;

        public string nome { get; set; }
        public CertidaoNascimento certidaoNascimento {

            get
            {
                return certidaoNascimento1;
            }
            set
            {
                if (certidaoNascimento1 != null)
                {

                    throw new InvalidOperationException("A Certidão de Nascimento não pode ser alterada.");
                }               
                certidaoNascimento1 = value;
            }
        }


        public Pessoa(string inputNome)
        {
            nome = inputNome;
        }
    }
}
