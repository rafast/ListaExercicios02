using System;

namespace ListaExercicio02.Questao05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a Questao 05");
            Motor motor = new Motor(1.0M);
            Console.WriteLine("Imprimindo as propriedades do motor criado:");
            Console.WriteLine($"Cilindrada: {motor.Cilindrada}");
            Console.WriteLine($"A referencia do carro é nula? { motor.carro == null}");
            Console.WriteLine("----------------------------------------------");

            Carro frontier = new("IAB-8392", "Frontier", motor);
            Console.WriteLine("Imprimindo as propriedades do motor após utilização no carro:");
            Console.WriteLine($"Cilindrada: {motor.Cilindrada}");
            Console.WriteLine($"Motor referente ao carro de placa: {motor.carro.Placa}");
            Console.WriteLine($"Motor referente ao carro modelo: {motor.carro.Modelo}");
            Console.WriteLine("----------------------------------------------");


            Console.WriteLine("Imprimindo as propriedades do carro criado:");
            Console.WriteLine($"Modelo: {frontier.Modelo}");
            Console.WriteLine($"Placa: {frontier.Placa}");
            Console.WriteLine($"Cilindrada: {frontier.motor.Cilindrada}");
            Console.WriteLine($"Velocidade máxima: {frontier.VelocidadeMaxima()} km/h");
            Console.WriteLine("----------------------------------------------");

            Motor motorPotente = new Motor(2.3M);
            Console.WriteLine("Imprimindo as propriedades do novo motor criado:");
            Console.WriteLine($"Cilindrada: {motorPotente.Cilindrada}");
            Console.WriteLine($"A referencia do carro é nula? { motorPotente.carro == null}");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Substituindo o motor do carro pelo novo motor mais potente.");
            frontier.TrocarMotor(motorPotente);
            Console.WriteLine($"Modelo: {frontier.Modelo}");
            Console.WriteLine($"Placa: {frontier.Placa}");
            Console.WriteLine($"Cilindrada: {frontier.motor.Cilindrada}");
            Console.WriteLine($"Velocidade máxima: {frontier.VelocidadeMaxima()} km/h");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Imprimindo as propriedades do motor antigo:");
            Console.WriteLine($"Cilindrada: {motor.Cilindrada}");
            Console.WriteLine($"A referencia do carro é nula? { motor.carro == null}");
        }
    }
}
