using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PetManager
{
    public partial class TelaInicial : Form
    {
        // Tabela central dos registros de pets
        private DataTable tabela = null!;

        public TelaInicial()
        {
            InitializeComponent();
            CarregarTabelaPrincipal();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void CarregarTabelaPrincipal()
        {
            tabela = new DataTable();
            string[] colunas = {
                "Tipo", "Nome", "Raça", "Nascimento", "Cor", "Pelagem",
                "Castrado", "Peso", "Porte", "Vacinas",
                "Observações", "DataEntrada", "dataSaida", "Resumo"
            };
            foreach (string coluna in colunas)
                tabela.Columns.Add(coluna);

            string caminho = "registros.csv";
            if (!File.Exists(caminho))
                return;

            using (var reader = new StreamReader(caminho))
            {
                // Pula o cabeçalho
                if (!reader.EndOfStream)
                    reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine();
                    if (linha != null)
                    {
                        var dados = linha.Split(';');
                        if (dados.Length >= colunas.Length)
                            tabela.Rows.Add(dados);
                    }
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Passa a tabela REAL do sistema para Cadastro
            Cadastro telaCadastro = new Cadastro(tabela);
            if (telaCadastro.ShowDialog() == DialogResult.OK)
            {
                // Ao fechar, salve a tabela no CSV
                SalvarTabelaNoCsv();
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

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            Registros telaRegistros = new Registros();
            telaRegistros.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Form1 = new Login();
            Form1.Show();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Cursor = Cursors.Default;
            pictureBox3.BackColor = Color.Transparent;
        }
    }
}