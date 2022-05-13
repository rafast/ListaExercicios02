using System;
namespace ListaExercicio02.Questao01
{
    public class Cliente
    {
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public DateTime dt_nascimento { get; set; }
        public float RendaMensal { get; set; }
        public char EstadoCivil { get; set; }
        public int Dependentes { get; set; }

        public Cliente()
        {
        }

        public void ImprimeDados()
        {
            Console.WriteLine();
            Console.WriteLine("Cadastro realizado com sucesso! Favor confira os dados: ");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Data de nascimento: {dt_nascimento}");
            Console.WriteLine($"Renda mensal: R${RendaMensal}");
            Console.WriteLine($"Estado Civil: {EstadoCivil}");
            Console.WriteLine($"Número de dependentes: {Dependentes}");
        }
    }
}
