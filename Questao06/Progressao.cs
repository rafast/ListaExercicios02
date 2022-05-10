using System;
namespace ListaExercicio02.Questao06
{
    public abstract class Progressao
    {
        public int Primeiro { get; set; }
        public int Razao { get; set; }
        public int ValorAtual { get; set; }
        public abstract int ProximoValor { get; }

        public abstract int TermoAt(int posicao);

        public void Reinicializar()
        {
            ValorAtual = 0;
        }

        public Progressao()
        {
        }
    }
}
