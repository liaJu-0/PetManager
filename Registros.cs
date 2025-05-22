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
    public partial class Registros : Form
    {
        private List<string> _items; // Adicionando a lista de itens para simular os dados

        public Registros()
        {
            InitializeComponent();
            _items = new List<string> { "Cachorro", "Gato", "Pássaro" }; // Exemplo de dados
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void boxFiltroPorte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boxFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ListPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxFiltroRaca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void Registros_Load(object sender, EventArgs e)
        {

        }
    }
}
