using System;

namespace ListaExercicio02.Questao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cliente cliente = new Cliente();
            DadosString dados = new DadosString();
            LeituraDosDados(dados);
            dados.Validacao();
            dados.Imprime();

        }

        static void LeituraDosDados(DadosString dados)
        {
            Console.Write("Nome: ");
            dados.Nome = Console.ReadLine();
            Console.Write("CPF: ");
            dados.Cpf = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            dados.DataNascimento = Console.ReadLine();
            Console.Write("Renda mensal: R$");
            dados.RendaMensal = Console.ReadLine();
            Console.Write("Estado Civil: ");
            dados.EstadoCivil = Console.ReadLine();
            Console.Write("Numero de dependentes: ");
            dados.Dependentes = Console.ReadLine();

        }
    }
}
