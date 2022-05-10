using System;
namespace ListaExercicio02.Questao05
{
    public class Motor
    {
        private Carro carro1;

        public decimal Cilindrada { get; }
        public Carro carro
        {
            get
            {
                return carro1;
            }
            set
            {
                if (carro1 == null)
                {
                    carro1 = value;
                }
            }
         }

        public Motor(decimal cilindrada)
        {
            Cilindrada = cilindrada;
        }

        public void RemoverCarro()
        {
            carro1 = null;
        }
    }
}
