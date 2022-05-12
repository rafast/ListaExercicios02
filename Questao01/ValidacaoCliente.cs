using System;
using System.Collections.Generic;

namespace ListaExercicio02.Questao01
{
    public class ValidacaoCliente
    {
        Dictionary<string, string> erros = new Dictionary<string, string>();
        Dictionary<string, string> entradasString = new Dictionary<string, string>();

        public ValidacaoCliente()
        {
        }

        public void LeituraDosDados()
        {
            Console.Write("Nome: ");
            string NomeString = Console.ReadLine();
            entradasString.Add("Nome", NomeString);
            Console.Write("CPF: ");
            string CpfString = Console.ReadLine();
            entradasString.Add("Cpf", CpfString);
            Console.Write("Data de nascimento: ");
            string DataString = Console.ReadLine();
            entradasString.Add("DataNascimento", DataString);
            Console.Write("Renda mensal: R$");
            string RendaMensalString = Console.ReadLine();
            entradasString.Add("RendaMensal", RendaMensalString);
            Console.Write("Estado Civil: ");
            string EstadoCivilString = Console.ReadLine();
            Console.Write("Numero de dependentes: ");
            string DependentesString = Console.ReadLine();
            
        }

    }
}
