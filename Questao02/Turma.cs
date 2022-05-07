using System;
using System.Collections.Generic;
using System.Linq;
using ListaExercicios02.Questao02;

namespace ListaExercicio02.Questao02
{
    public class Turma
    {
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();

        public Turma()
        {
        }

        public void Inserir(Aluno aluno)
        {
            var existeAluno = Alunos.Where(p => p.Matricula == aluno.Matricula).Any();

            if (!existeAluno)
            {
                Alunos.Add(aluno);
            }
        }

        public void Remover(Aluno aluno)
        {
            var existeAluno = Alunos.Where(aluno => aluno.Matricula == aluno.Matricula).Any();

            if (existeAluno)
            {
                Alunos.Remove(aluno);
            }
        }

        public void ImprimirTurmaComNotasFinais()
        {
            if (Alunos.Count == 0)
            {
                Console.WriteLine("A turma encontra-se vazia. Favor adicionar alunos antes de imprimir");
                return;
            }

            var turmaOrdenada = Alunos.OrderBy(aluno => aluno.Nome);
            Console.WriteLine("Relatório da Turma com Notas Finais");
            Console.WriteLine("------------------------------");

            foreach (var aluno in turmaOrdenada)
            {
                Console.WriteLine($"Matricula: {aluno.Matricula}");
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Nota Final: {aluno.GetNotaFinal()}");
                Console.WriteLine();
            }
        }

        public void ImprimirEstatistica()
        {
            var mediaP1 = Alunos.Sum(aluno => aluno.P1) / Alunos.Count;
            var mediaP2 = Alunos.Sum(aluno => aluno.P2) / Alunos.Count;
            var mediaNF = Alunos.Sum(aluno => aluno.GetNotaFinal()) / Alunos.Count;
            var maiorNF = Alunos.OrderBy(aluno => aluno.GetNotaFinal()).Last();

            Console.WriteLine("Estatísticas da Turma");
            Console.WriteLine("------------------------");
            Console.WriteLine($"Média da P1: {mediaP1.ToString("0.00")}");
            Console.WriteLine($"Média da P2: {mediaP2.ToString("0.00")}");
            Console.WriteLine($"Média da NF: {mediaNF.ToString("0.00")}");
            Console.WriteLine($"Maior NF da Turma: {maiorNF.GetNotaFinal()}");
            Console.WriteLine($"Matricula: {maiorNF.Matricula}");
            Console.WriteLine($"Nome: {maiorNF.Nome}");
            Console.WriteLine($"P1: {maiorNF.P1}");
            Console.WriteLine($"P2: {maiorNF.P2}");
        }
    }
}
