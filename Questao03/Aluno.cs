using System;
namespace ListaExercicio02.Questao03
{
    public class Aluno
    {
        private static int proximaMatricula = 0;
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public Turma Turma { get; set; }

        public Aluno(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do aluno é obrigatório.");
            }
            Nome = nome;
            Matricula = proximaMatricula;
            proximaMatricula++;

        }
    }
}
