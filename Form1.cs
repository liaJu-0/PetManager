namespace PetManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "Usuário";
            txtUsuario.ForeColor = Color.Gray;

            txtSenha.Text = "Senha";
            txtSenha.ForeColor = Color.Gray;
            txtSenha.UseSystemPasswordChar = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "admin" && senha == "1234")
            {
                Form telaInicial = new TelaInicial();
                telaInicial.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuário";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuário")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.UseSystemPasswordChar = false;
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Gray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
                txtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
