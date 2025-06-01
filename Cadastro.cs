using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PetManager
{
    public partial class Cadastro : Form
    {
        private DataRow? registroEditando = null;
        private DataTable? tabela = null;

        // Construtor padrão (necessário para evitar erro CS1729)
        public Cadastro()
        {
            InitializeComponent();
        }

        // Construtor para NOVO cadastro
        public Cadastro(DataTable tabelaRef)
        {
            InitializeComponent();
            tabela = tabelaRef;
        }

        // Construtor para EDIÇÃO
        public Cadastro(DataRow row, DataTable tabelaRef)
        {
            InitializeComponent();
            registroEditando = row;
            tabela = tabelaRef;
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            if (registroEditando == null) return;
            txtTipo.Text = registroEditando["Tipo"].ToString();
            txtNome.Text = registroEditando["Nome"].ToString();
            txtRaca.Text = registroEditando["Raça"].ToString();

            DateTime dt;
            if (DateTime.TryParse(registroEditando["Nascimento"].ToString(), out dt))
                dateNscto.Value = dt;
            else
                dateNscto.Value = DateTime.Today;

            txtCorPelo.Text = registroEditando["Cor"].ToString();
            txtTamPelo.Text = registroEditando["Pelagem"].ToString();
            comboBoxCastrado.Text = registroEditando["Castrado"].ToString();
            txtPeso.Text = registroEditando["Peso"].ToString();
            txtTamanho.Text = registroEditando["Porte"].ToString();
            txtVacinas.Text = registroEditando["Vacinas"].ToString();
            txtObs.Text = registroEditando["Observações"].ToString();

            if (DateTime.TryParse(registroEditando["DataEntrada"].ToString(), out dt))
                dateEntrada.Value = dt;
            else
                dateEntrada.Value = DateTime.Today;

            if (DateTime.TryParse(registroEditando["dataSaida"].ToString(), out dt))
                dateSaida.Value = dt;
            else
                dateSaida.Value = DateTime.Today;

            txtResumo.Text = registroEditando["Resumo"].ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tabela == null)
            {
                MessageBox.Show("Tabela de dados não está disponível!");
                return;
            }

            if (registroEditando != null)
            {
                // Atualiza os campos do registro EXISTENTE
                registroEditando["Tipo"] = txtTipo.Text;
                registroEditando["Nome"] = txtNome.Text;
                registroEditando["Raça"] = txtRaca.Text;
                registroEditando["Nascimento"] = dateNscto.Value.ToShortDateString();
                registroEditando["Cor"] = txtCorPelo.Text;
                registroEditando["Pelagem"] = txtTamPelo.Text;
                registroEditando["Castrado"] = comboBoxCastrado.Text;
                registroEditando["Peso"] = txtPeso.Text;
                registroEditando["Porte"] = txtTamanho.Text;
                registroEditando["Vacinas"] = txtVacinas.Text;
                registroEditando["Observações"] = txtObs.Text;
                registroEditando["DataEntrada"] = dateEntrada.Value.ToShortDateString();
                registroEditando["dataSaida"] = dateSaida.Value.ToShortDateString();
                registroEditando["Resumo"] = txtResumo.Text;
            }
            else
            {
                // NOVO cadastro: cria nova linha
                var novaLinha = tabela.NewRow();
                novaLinha["Tipo"] = txtTipo.Text;
                novaLinha["Nome"] = txtNome.Text;
                novaLinha["Raça"] = txtRaca.Text;
                novaLinha["Nascimento"] = dateNscto.Value.ToShortDateString();
                novaLinha["Cor"] = txtCorPelo.Text;
                novaLinha["Pelagem"] = txtTamPelo.Text;
                novaLinha["Castrado"] = comboBoxCastrado.Text;
                novaLinha["Peso"] = txtPeso.Text;
                novaLinha["Porte"] = txtTamanho.Text;
                novaLinha["Vacinas"] = txtVacinas.Text;
                novaLinha["Observações"] = txtObs.Text;
                novaLinha["DataEntrada"] = dateEntrada.Value.ToShortDateString();
                novaLinha["dataSaida"] = dateSaida.Value.ToShortDateString();
                novaLinha["Resumo"] = txtResumo.Text;
                tabela.Rows.Add(novaLinha);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecione uma imagem";
            ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                // Se desejar salvar o caminho no DataRow, adicione um campo "Imagem" na tabela
                // if (registroEditando != null)
                //     registroEditando["Imagem"] = ofd.FileName;
            }
        }
    }
}