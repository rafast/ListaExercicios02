using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ListaExercicio02.Questao01
{
    public class DadosString
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string RendaMensal { get; set; }
        public string EstadoCivil { get; set; }
        public string Dependentes { get; set; }
       
        Dictionary<string, string> validacaoCampos = new Dictionary<string, string>();

        public DadosString()
        {
        }

        public void Validacao()
        {
            validacaoCampos.Add("Nome", validaNome(Nome));
            validacaoCampos.Add("Cpf", validaCPF(Cpf));
            DateTime dt;
            validacaoCampos.Add("DataNascimento", validaData(out dt ,DataNascimento));
            float renda;
            validacaoCampos.Add("RendaMensal", validaRenda(out renda, RendaMensal));
            validacaoCampos.Add("EstadoCivil", validaEstadoCivil(EstadoCivil));
            validacaoCampos.Add("Dependentes", validaDependentes(Dependentes));
        }

        public void Imprime()
        {
            var possuiErro = validacaoCampos.Where(campo => campo.Value != "Valido").Any();

            if (possuiErro)
            {
                foreach (var campo in validacaoCampos.Where(campo => campo.Value != "Valido"))
                {
                    Console.WriteLine($"{campo.Key} - {campo.Value}");                                
                }
            }            
        }

        private string validaNome(string nome)
        {
            string padrao = "^([a-zA-Z ]*?)\\s*([a-zA-Z]*)$";
            bool ehValido = Regex.IsMatch(nome, padrao) && (nome.Length > 4);
            return ehValido ? "Valido" : "O nome deve ter pelo menos 5 caracteres.";
        }

        private string validaCPF(string cpf)
        {
            string padrao = "[0-9]{3}.?[0-9]{3}.?[0-9]{3}-?[0-9]{2}";
            bool ehValido = Regex.IsMatch(cpf, padrao);
            return ehValido ? "Valido" : "CPF inválido.";
        }

        private string validaData(out DateTime data, string inputData)
        {
            bool ehValido = DateTime.TryParseExact(inputData,
                                         "dd/MM/yyyy",
                                         CultureInfo.InvariantCulture,
                                         DateTimeStyles.None,
                                         out data) && maiorIdade(data);
            return ehValido ? "Valido" : "A data deve estar no formato DD/MM/AAAA. E o cliente deve ter mais de 18 anos.";
        }

        private bool maiorIdade(DateTime data_nascimento)
        {
            var hoje = DateTime.Today;
            return (hoje.Year - data_nascimento.Year >= 18);
        }

        private string validaRenda(out float renda, string inputRendaMensal)
        {
            var culture = CultureInfo.GetCultureInfo("fr-FR");
            bool ehValido = float.TryParse(inputRendaMensal, NumberStyles.Currency, culture, out renda);
            return ehValido ? "Valido" : "A renda mensal deve ser um valor maior ou igual a zero e possuir vírgula decimal e duas casas decimais.";
        }

        private string validaEstadoCivil(string estado_civil)
        {
            bool ehValido = (estado_civil.ToUpper() == "C" ||
                estado_civil.ToUpper() == "S" ||
                estado_civil.ToUpper() == "V" ||
                estado_civil.ToUpper() == "D");
            return ehValido ? "Valido" : "Para o estado civil utilize: C, S, V ou D (maiúsculo ou minúsculo).";
        }

        private string validaDependentes(string dependentes)
        {
            int dependente;
            bool ehValido = (Int32.TryParse(dependentes, out dependente) &&
                                            (dependente >= 0 && dependente <= 10));
            return ehValido ? "Valido" : "O número de dependentes deve estar entre 0 e 10.";
        }
    }
}
