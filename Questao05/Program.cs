using System;

namespace ListaExercicio02.Questao05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a Questao 05");
            Motor motor = new Motor(2.3M);
            Console.WriteLine("Imprimindo as propriedades do motor criado:");
            //Console.WriteLine(motor.Cilindrada);
            //Console.WriteLine(motor.carro.Equals(null));
            Carro meuCarro = new("IAB-8392", "Frontier", motor);
            Console.WriteLine("Imprimindo as propriedades do motor após utilização no carro:");
            Console.WriteLine(motor.Cilindrada);
            Console.WriteLine(motor.carro.Placa);
            Console.WriteLine(motor.carro.Modelo);
            Console.WriteLine("Imprimindo as propriedades do carro criado:");
            Console.WriteLine(meuCarro.Modelo);
            Console.WriteLine(meuCarro.Placa);
            Console.WriteLine(meuCarro.motor.Cilindrada);
            Motor motorPotente = new Motor(3.0M);
            meuCarro.TrocarMotor(motorPotente);
            Console.WriteLine("Imprimindo as propriedades do carro com o novo motor:");
            Console.WriteLine(meuCarro.Modelo);
            Console.WriteLine(meuCarro.Placa);
            Console.WriteLine(meuCarro.motor.Cilindrada);
            Console.WriteLine("Imprimindo as propriedades do novo motor:");
            Console.WriteLine(motorPotente.Cilindrada);
            Console.WriteLine(motorPotente.carro.Placa);
            Console.WriteLine(motorPotente.carro.Modelo);
            Console.WriteLine("Imprimindo as propriedades do motor antigo:");
            Console.WriteLine(motor.Cilindrada);
            Console.WriteLine(motor.carro.Placa);
            Console.WriteLine(motor.carro.Modelo);
        }
    }
}
