using System;
namespace ListaExercicio02.Questao06
{
    public class ProgressaoGeometrica : Progressao
    {
        public ProgressaoGeometrica()
        {
        }

        public ProgressaoGeometrica(int primeiro, int razao)
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
                ValorAtual *= Razao;
                return ValorAtual;
            }
        }

        public override int TermoAt(int posicao)
        {
            return (int)(Primeiro * Math.Pow(Razao, (posicao - 1)));
        }
    }
}
