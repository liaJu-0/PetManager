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
    }
}
