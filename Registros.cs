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
        private bool inicializando = false;

        public Registros()
        {
            InitializeComponent();

            TxtPesquisa.GotFocus += TxtPesquisa_GotFocus;
            TxtPesquisa.LostFocus += TxtPesquisa_LostFocus;
            TxtPesquisa.KeyDown += TxtPesquisa_KeyDown;

            BoxFiltroTipo.SelectedIndexChanged += BoxFiltroTipo_SelectedIndexChanged_1;
            BoxFiltroPorte.SelectedIndexChanged += BoxFiltroPorte_SelectedIndexChanged;
            CheckListBox1.ItemCheck += CheckListBox1_ItemCheck;
            btnFiltrar.Click += btnFiltrar_Click;
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            inicializando = true;
            TxtPesquisa.Text = "Pesquisa...";
            TxtPesquisa.ForeColor = Color.Gray;
            CarregarCsv();
            PopularFiltros();
            AplicarFiltros(mostrarAlerta: false);
            inicializando = false;
        }

        private void TxtPesquisa_GotFocus(object? sender, EventArgs e)
        {
            if (TxtPesquisa.Text == "Pesquisa...")
            {
                TxtPesquisa.Text = "";
                TxtPesquisa.ForeColor = Color.Black;
            }
        }

        private void TxtPesquisa_LostFocus(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPesquisa.Text))
            {
                TxtPesquisa.Text = "Pesquisa...";
                TxtPesquisa.ForeColor = Color.Gray;
            }
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
                return;

            using (var stream = new FileStream(caminho, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var reader = new StreamReader(stream))
            {
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
            BoxFiltroTipo.Items.Add("Todos");
            BoxFiltroTipo.Items.Add("Gato");
            BoxFiltroTipo.Items.Add("Cachorro");
            BoxFiltroTipo.Items.Add("Outro");
            BoxFiltroTipo.SelectedIndex = 0;

            BoxFiltroPorte.Items.Clear();
            BoxFiltroPorte.Items.Add("Todos");
            BoxFiltroPorte.Items.Add("Pequeno");
            BoxFiltroPorte.Items.Add("Médio");
            BoxFiltroPorte.Items.Add("Grande");
            BoxFiltroPorte.SelectedIndex = 0;

            if (CheckListBox1.Items.Count == 0)
            {
                CheckListBox1.Items.Add("Todos");
                CheckListBox1.Items.Add("Ativos");
                CheckListBox1.Items.Add("Inativos");
                CheckListBox1.SetItemChecked(0, true);
            }
        }

        private void AplicarFiltros(bool mostrarAlerta)
        {
            if (tabela == null || tabela.Rows.Count == 0)
            {
                if (mostrarAlerta)
                    MessageBox.Show("Nenhum registro encontrado.");
                panel1.Controls.Clear();
                return;
            }

            string termo = TxtPesquisa.Text.ToLower().Trim();
            if (termo == "pesquisa...") termo = "";

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
                bool campoDataSaidaVazio = string.IsNullOrWhiteSpace(dataSaidaStr);

                bool nomeMatch = filtrarTodos || nome.Contains(termo);
                bool tipoMatch = filtrarTodos || tipoSelecionado == "Todos" || tipo == tipoSelecionado;
                bool porteMatch = filtrarTodos || porteSelecionado == "Todos" || porte == porteSelecionado;

                bool statusMatch = true;
                if (!filtrarTodos)
                {
                    if (filtrarAtivos && !filtrarInativos)
                        statusMatch = campoDataSaidaVazio || (temDataSaida && dataSaida >= hoje);
                    else if (!filtrarAtivos && filtrarInativos)
                        statusMatch = !campoDataSaidaVazio && temDataSaida && dataSaida < hoje;
                    else if (filtrarAtivos && filtrarInativos)
                        statusMatch = true;
                }

                return nomeMatch && tipoMatch && porteMatch && statusMatch;
            });

            if (!resultado.Any())
            {
                if (mostrarAlerta)
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

                lbl.Click += (s, e) => {
                    Cadastro tela = new Cadastro(row, tabela);
                    if (tela.ShowDialog() == DialogResult.OK)
                    {
                        SalvarTabelaNoCsv();
                        CarregarCsv();
                        PopularFiltros();
                        AplicarFiltros(mostrarAlerta: false);
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

        private void TxtPesquisa_KeyDown(object? sender, KeyEventArgs e)
        {
            if (!inicializando && e.KeyCode == Keys.Enter)
                AplicarFiltros(mostrarAlerta: true);
        }

        private void btnFiltrar_Click(object? sender, EventArgs e)
        {
            if (!inicializando)
                AplicarFiltros(mostrarAlerta: true);
        }

        private void btnVoltar_Click(object? sender, EventArgs e)
        {
            new TelaInicial().Show();
            this.Close();
        }

        private void BoxFiltroTipo_SelectedIndexChanged_1(object? sender, EventArgs e)
        {
            if (!inicializando)
                AplicarFiltros(mostrarAlerta: true);
        }

        private void BoxFiltroPorte_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (!inicializando)
                AplicarFiltros(mostrarAlerta: true);
        }

        private void CheckListBox1_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            if (inicializando) return;

            if (e.Index == 0 && e.NewValue == CheckState.Checked)
            {
                for (int i = 1; i < CheckListBox1.Items.Count; i++)
                    CheckListBox1.SetItemChecked(i, false);
            }
            if (e.Index > 0 && e.NewValue == CheckState.Checked)
            {
                CheckListBox1.SetItemChecked(0, false);
            }
            this.BeginInvoke((Action)(() => AplicarFiltros(mostrarAlerta: true)));
        }
    }
}