using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaExercicio02.Questao03
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
        public List<Turma> Turmas { get; set; } = new List<Turma>();


        public Curso(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do curso é obrigatório.");
            }
            Nome = nome;
        }

        public void MatricularAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(Aluno aluno)
        {
            if (aluno.Turma == null)
            {
                Alunos.Remove(aluno);
            }
        }

        public void CriarTurma(Turma turma)
        {
            Turmas.Add(turma);
        }

        public void RemoverTurma(Turma turma)
        {
            if (turma.Alunos.Count == 0)
            {
                Turmas.Remove(turma);
            }
        }

        public void ListarAlunosTurmaPorCodigo(int codigoTurma)
        {
            var turma = Turmas.Where(turma => turma.Codigo == codigoTurma)
                                             .SingleOrDefault();

            if (turma != null)
            {
                turma.ListarAlunosOrdemAlfabetica();                
            }

        }

        public void ListarTurmasComAlunos()
        {
            var turmasComAlunos = Turmas.Where(turma => turma.Alunos.Count > 0)
                                        .OrderBy(turma => turma.Codigo);

            foreach (var turma in turmasComAlunos)
            {
                turma.ListarAlunosOrdemAlfabetica();
            }
        }
    }

}
