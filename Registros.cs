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
            // Exibe todos os registros ao abrir, sem pop-up se vazio:
            ExibirTodosSemAlerta();
        }

        private void CarregarCsv()
        {
            string caminho = "registros.csv";

            tabela.Clear();
            tabela.Columns.Clear();

            string[] colunas = {
                "Tipo", "Nome", "Raça", "Nascimento", "Cor", "Pelagem",
                "Castrado", "Peso", "Porte", "Vacinas",
                "Observações", "DataEntrada", "dataSaida", "Resumo"
            };

            foreach (string coluna in colunas)
                tabela.Columns.Add(coluna);

            if (!File.Exists(caminho))
            {
                // Não mostrar pop-up aqui
                return;
            }

            using (var stream = new FileStream(caminho, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var reader = new StreamReader(stream))
            {
                // pula o cabeçalho
                if (!reader.EndOfStream)
                    reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine();
                    if (linha != null)
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

            // Preencha o CheckListBox1 se ainda não estiver preenchido
            if (CheckListBox1.Items.Count == 0)
            {
                CheckListBox1.Items.Add("Todos");
                CheckListBox1.Items.Add("Ativos");
                CheckListBox1.Items.Add("Inativos");
                CheckListBox1.SetItemChecked(0, true); // Seleciona "Todos" por padrão
            }
        }

        private void ExibirTodosSemAlerta()
        {
            if (tabela == null || tabela.Rows.Count == 0)
            {
                panel1.Controls.Clear();
                return;
            }
            ExibirResultados(tabela, mostrarAlerta: false);
        }

        private void AplicarFiltros()
        {
            if (tabela == null || tabela.Rows.Count == 0)
                return;

            string termo = TxtPesquisa.Text.ToLower().Trim();
            string tipoSelecionado = BoxFiltroTipo.Text;
            string porteSelecionado = BoxFiltroPorte.Text;

            var selecionados = CheckListBox1.CheckedItems.Cast<string>().ToList();
            bool filtrarTodos = selecionados.Contains("Todos") || selecionados.Count == 0;
            bool filtrarAtivos = selecionados.Contains("Ativos");
            bool filtrarInativos = selecionados.Contains("Inativos");

            DateTime hoje = DateTime.Today;

            var resultado = tabela.AsEnumerable().Where(row =>
            {
                string nome = row["Nome"]?.ToString()?.ToLower() ?? "";
                string tipo = row["Tipo"]?.ToString() ?? "";
                string porte = row["Porte"]?.ToString() ?? "";
                string? dataSaidaStr = row.Table.Columns.Contains("dataSaida") ? row["dataSaida"]?.ToString() : null;
                DateTime dataSaida;
                bool temDataSaida = DateTime.TryParse(dataSaidaStr, out dataSaida);

                bool nomeMatch = nome.Contains(termo);
                bool tipoMatch = tipoSelecionado == "Todos" || tipo == tipoSelecionado;
                bool porteMatch = porteSelecionado == "Todos" || porte == porteSelecionado;

                bool statusMatch = true;
                if (!filtrarTodos)
                {
                    if (filtrarAtivos && !filtrarInativos)
                    {
                        statusMatch = !temDataSaida || dataSaida > hoje;
                    }
                    else if (!filtrarAtivos && filtrarInativos)
                    {
                        statusMatch = temDataSaida && dataSaida <= hoje;
                    }
                    else if (filtrarAtivos && filtrarInativos)
                    {
                        statusMatch = true;
                    }
                }

                return nomeMatch && tipoMatch && porteMatch && statusMatch;
            });

            if (!resultado.Any())
            {
                // Aqui sim, mostra o pop-up se não encontrar
                MessageBox.Show("Nenhum registro encontrado.");
                panel1.Controls.Clear();
                return;
            }

            ExibirResultados(resultado.CopyToDataTable(), mostrarAlerta: false);
        }

        private void ExibirResultados(DataTable dados, bool mostrarAlerta = true)
        {
            panel1.Controls.Clear();

            if (dados == null || dados.Rows.Count == 0)
            {
                if (mostrarAlerta)
                    MessageBox.Show("Nenhum registro encontrado.");
                return;
            }

            int y = 10;
            foreach (DataRow row in dados.Rows)
            {
                Label lbl = new Label();
                lbl.Text = $"🐾 {row["Nome"]} ({row["Tipo"]}) - Porte: {row["Porte"]} | Raça: {row["Raça"]}";
                lbl.AutoSize = true;
                lbl.Location = new Point(10, y);
                lbl.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                lbl.Cursor = Cursors.Hand;

                // Evento para edição
                lbl.Click += (s, e) => {
                    Cadastro tela = new Cadastro(row, tabela);  // Passe a tabela para poder salvar depois
                    if (tela.ShowDialog() == DialogResult.OK)
                    {
                        SalvarTabelaNoCsv();
                        CarregarCsv();
                        PopularFiltros();
                        ExibirTodosSemAlerta();
                    }
                };

                panel1.Controls.Add(lbl);
                y += 25;
            }
        }

        private void SalvarTabelaNoCsv()
        {
            string caminho = "registros.csv";
            using (var writer = new StreamWriter(caminho, false))
            {
                writer.WriteLine(string.Join(";", tabela.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));
                foreach (DataRow row in tabela.Rows)
                {
                    writer.WriteLine(string.Join(";", row.ItemArray));
                }
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
            AplicarFiltros();
        }

        private void BoxFiltroPorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void CheckListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((Action)(() => AplicarFiltros()));
        }
    }
}