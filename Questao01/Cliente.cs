using System;
namespace ListaExercicio02.Questao01
{
    public class Cliente
    {
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public DateTime dt_nascimento { get; set; }
        public float RendaMensal { get; set; }
        public char EstadoCivil { get; set; }
        public int Dependentes { get; set; }

        public Cliente()
        {
        }
    }
}
