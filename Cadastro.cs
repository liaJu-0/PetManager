﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PetManager
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string tipo = txtTipo.Text;
            string nome = txtNome.Text;
            string raca = txtRaca.Text;
            string nascimento = dateNscto.Value.ToShortDateString();
            string corPelagem = txtCorPelo.Text;
            string tamPelagem = txtTamPelo.Text;
            string castrado = comboBoxCastrado.Text;
            string peso = txtPeso.Text;
            string porte = txtTamanho.Text;
            string vacinas = txtVacinas.Text;
            string observacoes = txtObs.Text;
            string dataEntrada = dateEntrada.Value.ToShortDateString();
            string resumo = txtResumo.Text;

            string linha = $"{tipo};{nome};{raca};{nascimento};{corPelagem};{tamPelagem};{castrado};{peso};{porte};{vacinas};{observacoes};{dataEntrada};{resumo}";

            string caminho = "registros.csv";

            try
            {
                if (!File.Exists(caminho))
                {
                    File.AppendAllText(caminho, "Tipo;Nome;Raça;Nascimento;Cor;Pelagem;Castrado;Peso;Porte;Vacinas;Observações;DataEntrada;Resumo\n");
                }

                File.AppendAllText(caminho, linha + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Cadastro salvo com sucesso!\n\nDeseja visualizar os registros?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (resultado == DialogResult.Yes)
            {
                Registros telaRegistros = new Registros();
                telaRegistros.Show();
            }
            else
            {
                TelaInicial telaInicial = new TelaInicial();
                telaInicial.Show();
            }

            this.Close();
        }


        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecione uma imagem";
            ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // ou Zoom, se quiser manter a proporção
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde a tela atual
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show(); // Abre a tela inicial
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Cursor = Cursors.Hand; // Muda o cursor pra mãozinha
            pictureBox2.BackColor = Color.LightGray; // Opcional: destaca o fundo
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Cursor = Cursors.Default; // Volta pro cursor padrão
            pictureBox2.BackColor = Color.Transparent; // Remove o destaque
        }
    }
}
