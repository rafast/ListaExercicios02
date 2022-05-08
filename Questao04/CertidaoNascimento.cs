using System;
namespace ListaExercicio02.Questao04
{
    public class CertidaoNascimento
    {
        public DateTime dataEmissao { get; }
        public Pessoa Pessoa { get; }

        public CertidaoNascimento(DateTime dtEmissao, Pessoa pessoa)
        {
            dataEmissao = dtEmissao;
            Pessoa = pessoa;
        }
    }
}
