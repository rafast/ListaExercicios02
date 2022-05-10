using System;

namespace ListaExercicio02.Questao06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a classe Progressao Aritmetica");
            Console.WriteLine("Imprimindo os 10 primeiros termos de uma PA com o primeiro termo 3 e razão 4");
            var PA = new ProgressaoAritmetica(3, 4);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(PA.ProximoValor);
            }

            Console.WriteLine("Testando a classe Progressao Geometrica");
            Console.WriteLine("Imprimindo os 10 primeiros termos de uma PG com o primeiro termo 3 e razão 4");
            var PG = new ProgressaoGeometrica(3, 4);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(PG.ProximoValor);
            }

        }
    }
}
