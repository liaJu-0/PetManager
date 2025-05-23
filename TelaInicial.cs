using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetManager
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Cadastro telaCadastro = new Cadastro();
            telaCadastro.Show();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            Registros telaRegistros = new Registros();
            telaRegistros.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde a tela atual
            Login Form1 = new Login();
            Form1.Show(); // Abre a tela de Login
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Cursor = Cursors.Hand; // Muda o cursor pra mãozinha
            pictureBox3.BackColor = Color.LightGray; // Opcional: destaca o fundo
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Cursor = Cursors.Default; // Volta pro cursor padrão
            pictureBox3.BackColor = Color.Transparent; // Remove o destaqu
        }
    }
}
