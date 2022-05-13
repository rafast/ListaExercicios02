using System;

namespace ListaExercicio02.Questao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a Questao01!");
            Cliente cliente = new Cliente();
            DadosString dados = new DadosString();
            dados.LeituraDosDados();
            dados.Validacao();
            while (!dados.TodosValidos())
            {
                dados.ImprimeListaDeErros();
                dados.LeituraDadosInvalidos();
                dados.Validacao();
            }
            dados.PreencheDadosCliente(cliente);
            cliente.ImprimeDados();

        }
    }
}
