using System;
namespace ListaExercicios02.Questao02
{
    public class Aluno
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public float P1 { get; set; } = -1;
        public float P2 { get; set; } = -1;

        public Aluno(string matricula, string nome)
        {
            if(string.IsNullOrWhiteSpace(matricula) || string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Matricula e Nome são obrigatórios e não podem estar em branco");
            }

            Matricula = matricula;
            Nome = nome;
        }

        public void LancarNota(float nota)
        {
            if(nota < 0 || nota > 10)
            {
                throw new ArgumentException("Nota inválida. Uma nota deve possuir um valor entre 0 e 10");
            }

            if (P1 == -1)
            {
                P1 = nota;
            }
            else
            {
                P2 = nota;
            }
        }

        public float GetNotaFinal()
        {
            if (P1 == -1 && P2 == -1)
            {
                return 0.00f;
            }
            if (P1 != -1 && P2 == -1)
            {
                return P1;
            }
            else
            {
                return (P1 + P2) / 2;
            }
        }
    }
}
