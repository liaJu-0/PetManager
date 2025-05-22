using System;
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

        private void btnSalvar_Click_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Cadastro realizado com sucesso!\n\nDeseja visualizar os registros?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (resultado == DialogResult.Yes)
            {
                Registros telaRegistros = new Registros();
                telaRegistros.Show();
                this.Close();
            }
            else
            {
                TelaInicial telaInicial = new TelaInicial();
                telaInicial.Show();
                this.Close();
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
