using System;
namespace ListaExercicio02.Questao04
{
    public class CertidaoNascimento
    {
        public DateTime dataEmissao { get; }
        public Pessoa Pessoa { get; }

        public CertidaoNascimento(DateTime dtEmissao, Pessoa pessoa)
        {
            if (pessoa.certidaoNascimento != null)
            {

                throw new ArgumentException("Essa pessoa já possui uma certidão de nascimento.");
            }
                dataEmissao = dtEmissao;
                Pessoa = pessoa;
                pessoa.certidaoNascimento = this;
        }

        public static implicit operator CertidaoNascimento(DateTime v)
        {
            throw new NotImplementedException();
        }
    }
}
