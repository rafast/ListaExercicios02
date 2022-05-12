using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaExercicio02.Questao07
{
    public class Propriedades
    {
        private Dictionary<String, String> listaChaveValor;
        private string pathArquivo;

        public Propriedades()
        {
            listaChaveValor = new Dictionary<string, string>();
        }

        public Propriedades(string pathArquivo)
        {
            this.pathArquivo = pathArquivo;
            listaChaveValor = new Dictionary<string, string>();

            if (System.IO.File.Exists(pathArquivo))
            {
                lerPropriedadesDoArquivo(pathArquivo);
            }
            else
            {
                throw new ArgumentException("Caminho para o arquivo inválido ou arquivo não existe.");
            }


        }

        private void lerPropriedadesDoArquivo(string arquivo)
        {
            foreach (var linha in System.IO.File.ReadAllLines(arquivo))
            {
                if (!string.IsNullOrWhiteSpace(linha) && linha.Contains('='))
                {
                    int indice = linha.IndexOf('=');
                    string chave = linha.Substring(0, indice);
                    string valor = linha.Substring(indice + 1);
                    listaChaveValor.Add(chave, valor);
                }
            }
        }

        public string GetChave(string chave)
        {
            if (listaChaveValor.ContainsKey(chave))
            {
                return listaChaveValor[chave];
            }
            else
            {
                throw new ArgumentException("A chave informada não existe.");
            }
        }

        public void SetChave(string chave, string novoValor)
        {
            if (listaChaveValor.ContainsKey(chave))
            {
                listaChaveValor[chave] = novoValor;
            }
            else
            {
                throw new ArgumentException("A chave informada não existe.");
            }
        }

        public bool ExisteChave(string chave)
        {
            return listaChaveValor.ContainsKey(chave);
        }

        public void IncluirChave(string chave, string valor)
        {
            if (listaChaveValor.ContainsKey(chave))
            {
                throw new ArgumentException("A chave informada já existe. Não é permitido chaves duplicadas.");
            }
            else
            {
                listaChaveValor.Add(chave, valor);
            }
        }

        public void SalvarEmArquivo(string arquivo = "arquivo")
        {
            if (arquivo == "arquivo")
            {
                arquivo = pathArquivo;
            }

            if (!System.IO.File.Exists(arquivo))
            {
                throw new ArgumentException("Caminho para o arquivo inválido ou arquivo não existe.");
            }

            System.IO.StreamWriter writer = new System.IO.StreamWriter(arquivo);

            foreach (var prop in listaChaveValor.Keys.ToArray())
            {
                writer.WriteLine(prop + "=" + listaChaveValor[prop]);
            }
            writer.Close();
        }
    }
}
