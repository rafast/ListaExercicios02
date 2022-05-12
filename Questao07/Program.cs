using System;

namespace ListaExercicio02.Questao07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a classe Propriedades");
            Propriedades props = new Propriedades("/Users/rafast/Projects/ListaExercicios02/Questao07/propriedades.txt");
            Console.WriteLine(props.GetChave("email"));
            Console.WriteLine(props.GetChave("porta"));
            props.SetChave("porta", "8081");
            Console.WriteLine(props.GetChave("porta"));
            props.IncluirChave("senha", "abc123");
            Console.WriteLine(props.GetChave("senha"));
            props.IncluirChave("usuario", "joao paulo");
            props.SalvarEmArquivo("/Users/rafast/Projects/ListaExercicios02/Questao07/novoArquivo.txt");
        }
    }
}
