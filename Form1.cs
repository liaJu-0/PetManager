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

            // Simula��o simples de verifica��o
            if (usuario == "admin" && senha == "1234")
            {
                // Abrir nova janela
                Form telaInicial = new TelaInicial(); // voc� criar� essa tela depois
                telaInicial.Show();
                this.Hide(); // Esconde a tela de login
            }
            else
            {
                MessageBox.Show("Usu�rio ou senha inv�lidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
