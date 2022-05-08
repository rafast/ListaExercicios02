using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaExercicio02.Questao03
{
    public class Turma
    {
        private static List<int> codigosTurmas = new List<int>();
        public int Codigo { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();

        public Turma(int codigo)
        {
            var existeCodigo = codigosTurmas.Where(p => p == codigo).Any();
            if (existeCodigo)
            {
                throw new ArgumentException("Já existe uma turma cadastrada com esse código. Favor tente outro");
            }
            Codigo = codigo;
            codigosTurmas.Add(codigo);
        }

        public void InserirAluno(Aluno aluno)
        {
            var existeAluno = Alunos.Where(p => p.Matricula == aluno.Matricula).Any();

            if (!existeAluno)
            {
                Alunos.Add(aluno);
            }
        }

        public void RemoverAluno(Aluno aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunosOrdemAlfabetica()
        {
            var alunosOrdenados = Alunos.OrderBy(aluno => aluno.Nome);

            Console.WriteLine($"Listando a Turma {Codigo}");
            foreach (var aluno in alunosOrdenados)
            {
                Console.WriteLine($"Matricula: {aluno.Matricula}");
                Console.WriteLine($"Nome: {aluno.Nome}");
            }
        }
    }
}
