using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PetManager
{
    public partial class Registros : Form
    {
        private DataTable tabela = new DataTable();

        public Registros()
        {
            InitializeComponent();
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            CarregarCsv();
            PopularFiltros();
        }

        private void CarregarCsv()
        {
            string caminho = "registros.csv";

            tabela.Clear();
            tabela.Columns.Clear();

            string[] colunas = {
                "Tipo", "Nome", "Raça", "Nascimento", "Cor", "Pelagem",
                "Castrado", "Peso", "Porte", "Vacinas",
                "Observações", "DataEntrada", "Resumo"
            };

            foreach (string coluna in colunas)
                tabela.Columns.Add(coluna);

            if (!File.Exists(caminho))
            {
                MessageBox.Show("Nenhum registro salvo ainda.");
                return;
            }

            using (var stream = new FileStream(caminho, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine();
                    if (linha != null) // Adiciona verificação para evitar desreferência nula
                    {
                        var dados = linha.Split(';');
                        if (dados.Length >= colunas.Length)
                            tabela.Rows.Add(dados.Take(colunas.Length).ToArray());
                    }
                }
            }
        }

        private void PopularFiltros()
        {
            BoxFiltroTipo.Items.Clear();
            BoxFiltroPorte.Items.Clear();

            BoxFiltroTipo.Items.Add("Todos");
            BoxFiltroPorte.Items.Add("Todos");

            var tipos = tabela.AsEnumerable()
                              .Select(r => r["Tipo"].ToString())
                              .Where(tipo => !string.IsNullOrWhiteSpace(tipo))
                              .Distinct();

            var portes = tabela.AsEnumerable()
                               .Select(r => r["Porte"].ToString())
                               .Where(porte => !string.IsNullOrWhiteSpace(porte))
                               .Distinct();

            BoxFiltroTipo.Items.AddRange(tipos.Cast<object>().ToArray());
            BoxFiltroPorte.Items.AddRange(portes.Cast<object>().ToArray());

            BoxFiltroTipo.SelectedIndex = 0;
            BoxFiltroPorte.SelectedIndex = 0;
        }

        private void AplicarFiltros()
        {
            if (tabela == null || tabela.Rows.Count == 0)
                return;

            string termo = TxtPesquisa.Text.ToLower().Trim();
            string tipoSelecionado = BoxFiltroTipo.Text;
            string porteSelecionado = BoxFiltroPorte.Text;

            var selecionados = CheckListBox1.CheckedItems.Cast<string>().ToList();

            var resultado = tabela.AsEnumerable().Where(row =>
            {
                string nome = row["Nome"]?.ToString()?.ToLower() ?? "";
                string tipo = row["Tipo"]?.ToString() ?? "";
                string porte = row["Porte"]?.ToString() ?? "";

                bool nomeMatch = nome.Contains(termo);
                bool tipoMatch = tipoSelecionado == "Todos" || tipo == tipoSelecionado;
                bool porteMatch = porteSelecionado == "Todos" || porte == porteSelecionado;
                bool statusMatch = selecionados.Contains("Todos") || selecionados.Contains("Ativos");

                return nomeMatch && tipoMatch && porteMatch && statusMatch;
            });

            if (!resultado.Any())
            {
                MessageBox.Show("Nenhum registro encontrado.");
                panel1.Controls.Clear();
                return;
            }

            ExibirResultados(resultado.CopyToDataTable());
        }

        private void ExibirResultados(DataTable dados)
        {
            panel1.Controls.Clear();

            int y = 10;
            foreach (DataRow row in dados.Rows)
            {
                Label lbl = new Label();
                lbl.Text = $"🐾 {row["Nome"]} ({row["Tipo"]}) - Porte: {row["Porte"]} | Raça: {row["Raça"]}";
                lbl.AutoSize = true;
                lbl.Location = new Point(10, y);
                lbl.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                panel1.Controls.Add(lbl);
                y += 25;
            }
        }

        private void TxtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AplicarFiltros();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new TelaInicial().Show();
            this.Close();
        }

        private void BoxFiltroTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
