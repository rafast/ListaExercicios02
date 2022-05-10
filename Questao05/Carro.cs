using System;
namespace ListaExercicio02.Questao05
{
    public class Carro

    {
        private Motor motor1;

        public string Placa { get; }
        public string Modelo { get; }
        public Motor motor {
            get
            {
                return motor1;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Motor nulo, um carro não pode ficar sem motor.");
                }

                if (value.carro != null)
                {
                    throw new ArgumentException("Este motor já está em uso. Um motor não pode ser usado por mais de um carro");
                }
                motor1 = value;
                value.carro = this;
            }
            }



        public Carro(string placa, string modelo, Motor motor)
        {
            if (string.IsNullOrWhiteSpace(placa) || string.IsNullOrWhiteSpace(modelo) || motor == null)
            {
                throw new ArgumentException("Os campos Placa, Modelo e Motor, são obrigatório e não podem ser vazios ou nulos");
            }
            Placa = placa;
            Modelo = modelo;
            this.motor = motor;
        }

        public int VelocidadeMaxima()
        {
            if (motor.Cilindrada <= 1.0M)
            {
                return 140;
            }
            else if (motor.Cilindrada <= 1.6M)
            {
                return 160;
            }
            else if (motor.Cilindrada <= 2.0M)
            {
                return 180;
            }
            else if (motor.Cilindrada > 2.0M)
            {
                return 220;
            }
            return -1;
        }

        public void TrocarMotor(Motor novoMotor)
        {
            if (novoMotor == null)
            {
                throw new ArgumentException("Motor nulo, um carro não pode ficar sem motor.");
            }
            motor.carro = null;
            motor = novoMotor;
            novoMotor.carro = this;
        }
    }
}
