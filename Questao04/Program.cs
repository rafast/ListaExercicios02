using System;

namespace ListaExercicio02.Questao04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a questão 04!");
            Pessoa andre = new("Andre Luiz");
            CertidaoNascimento certidaoAndre = new(DateTime.Today, andre);
            Console.WriteLine("Imprimindo Certidao de Nascimento");
            Console.WriteLine(certidaoAndre.dataEmissao);
            Console.WriteLine(certidaoAndre.Pessoa.nome);
            Console.WriteLine("Imprimindo Pessoa");
            Console.WriteLine(andre.nome);
            Console.WriteLine(andre.certidaoNascimento.dataEmissao);
            Pessoa joana = new("Joana de Angelis");
            CertidaoNascimento certidaoJoana = new(DateTime.Today, joana);
            
            //pessoa.certidaoNascimento = certidaoJoana;


        }
    }
}
