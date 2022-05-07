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
            Aluno maria = new Aluno("01935", "Maria Joaquina de Amaral");
            Turma oitavoAno = new Turma();
            oitavoAno.Inserir(joao);
            oitavoAno.Inserir(maria);
            oitavoAno.Inserir(alvaro);
            Console.WriteLine();
            joao.LancarNota(3.5f);
            joao.LancarNota(5.5f);
            alvaro.LancarNota(8.5f);
            alvaro.LancarNota(4.5f);
            maria.LancarNota(9.5f);
            maria.LancarNota(8.0f);
            oitavoAno.ImprimirTurmaComNotasFinais();
            oitavoAno.ImprimirEstatistica();
        }
    }
}
