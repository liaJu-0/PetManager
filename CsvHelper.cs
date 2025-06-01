using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace PetManager
{
    public static class CsvHelper
    {
        public static List<RegistroPet> LerRegistros(string caminho)
        {
            var lista = new List<RegistroPet>();
            if (!File.Exists(caminho)) return lista;

            var linhas = File.ReadAllLines(caminho);
            for (int i = 1; i < linhas.Length; i++) // pula o cabeçalho
            {
                var col = linhas[i].Split(';');
                if (col.Length < 14) continue; // ignora linhas incompletas

                DateTime nascimento, entrada, saida;
                DateTime? dataSaida = null;

                DateTime.TryParse(col[3], out nascimento);
                DateTime.TryParse(col[11], out entrada);
                if (DateTime.TryParse(col[12], out saida))
                    dataSaida = saida;

                lista.Add(new RegistroPet
                {
                    Tipo = col[0],
                    Nome = col[1],
                    Raca = col[2],
                    Nascimento = nascimento,
                    Cor = col[4],
                    Pelagem = col[5],
                    Castrado = col[6],
                    Peso = col[7],
                    Porte = col[8],
                    Vacinas = col[9],
                    Observacoes = col[10],
                    DataEntrada = entrada,
                    DataSaida = dataSaida,
                    Resumo = col[13]
                });
            }
            return lista;
        }

        public static void SalvarRegistros(string caminho, List<RegistroPet> lista)
        {
            using (var sw = new StreamWriter(caminho, false))
            {
                sw.WriteLine("Tipo;Nome;Raça;Nascimento;Cor;Pelagem;Castrado;Peso;Porte;Vacinas;Observações;DataEntrada;dataSaida;Resumo");
                foreach (var r in lista)
                {
                    sw.WriteLine($"{r.Tipo};{r.Nome};{r.Raca};{r.Nascimento:dd/MM/yyyy};{r.Cor};{r.Pelagem};{r.Castrado};{r.Peso};{r.Porte};{r.Vacinas};{r.Observacoes};{r.DataEntrada:dd/MM/yyyy};{(r.DataSaida.HasValue ? r.DataSaida.Value.ToString("dd/MM/yyyy") : "")};{r.Resumo}");
                }
            }
        }
    }
}