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
            var existeAluno = Alunos.Where(aluno => aluno.Matricula == aluno.Matricula).Any();

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
    }
}
