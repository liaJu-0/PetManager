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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            // Simulação simples de verificação
            if (usuario == "admin" && senha == "1234")
            {
                // Abrir nova janela
                Form telaInicial = new TelaInicial(); // você criará essa tela depois
                telaInicial.Show();
                this.Hide(); // Esconde a tela de login
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
