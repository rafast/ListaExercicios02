using System;
namespace ListaExercicios02.Questao02
{
    public class Aluno
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public float P1 { get; set; }
        public float P2 { get; set; }

        public Aluno(string matricula, string nome)
        {
            if(string.IsNullOrWhiteSpace(matricula) || string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Matricula e Nome são obrigatórios e não podem estar em branco");
            }

            Matricula = matricula;
            Nome = nome;
        }
    }
}
