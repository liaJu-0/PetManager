namespace PetManager
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnLogin = new Button();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(489, 153);
            label1.Name = "label1";
            label1.Size = new Size(197, 36);
            label1.TabIndex = 0;
            label1.Text = "PetManager";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(551, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 27);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(514, 206);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(156, 27);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Usuário";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(514, 239);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(156, 27);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "Senha";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1128, 502);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private TextBox txtUsuario;
        private TextBox txtSenha;
    }
}
