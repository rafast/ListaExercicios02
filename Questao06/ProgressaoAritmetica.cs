using System;
namespace ListaExercicio02.Questao06
{
    public class ProgressaoAritmetica : Progressao
    {
        public ProgressaoAritmetica()
        {                
        }

        public ProgressaoAritmetica(int primeiro, int razao)
        {
            Primeiro = primeiro;
            Razao = razao;
        }

        public override int ProximoValor
        {
            get
            {
                if(ValorAtual == 0)
                {
                    ValorAtual = Primeiro;
                    return ValorAtual;
                }
                ValorAtual += Razao;
                return ValorAtual;
            }

        }

        public override int TermoAt(int posicao)
        {
            return Primeiro + (posicao - 1) * Razao;
        }
    }
}
