using System;
using ListaExercicio02.Questao02;

namespace ListaExercicios02.Questao02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a classe Turma");
            Aluno joao = new Aluno("01923", "João de Deus");
            Aluno alvaro = new Aluno("01932", "Alvaro dos Santos");
            Turma oitavoAno = new Turma();
            oitavoAno.Inserir(joao);
            oitavoAno.Inserir(alvaro);
        }
    }
}
