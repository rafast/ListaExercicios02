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
                if (carro1 != null)
                {
                    throw new ArgumentException("Este motor já está em uso. Um motor não pode ser usado por mais de um carro");
                }
                    carro1 = value;
            }
         }

        public Motor(decimal cilindrada)
        {
            Cilindrada = cilindrada;
            carro1 = null;
        }       

        public void Instalar(Carro car)
        {
            carro1 = car;
        }

        public void Desinstalar()
        {
            carro1 = null;
        }
    }
}
