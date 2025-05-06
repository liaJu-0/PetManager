namespace PetManager
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnRegistros = new Button();
            btnNovo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(468, 153);
            label1.Name = "label1";
            label1.Size = new Size(263, 36);
            label1.TabIndex = 1;
            label1.Text = "Seja Bem Vindo!";
            // 
            // btnRegistros
            // 
            btnRegistros.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistros.ForeColor = Color.DarkGreen;
            btnRegistros.Location = new Point(540, 213);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(132, 37);
            btnRegistros.TabIndex = 2;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = true;
            btnRegistros.Click += btnRegistros_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.ForeColor = Color.DarkGreen;
            btnNovo.Location = new Point(540, 265);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(132, 37);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo Registro";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1161, 498);
            Controls.Add(btnNovo);
            Controls.Add(btnRegistros);
            Controls.Add(label1);
            Name = "TelaInicial";
            Text = "TelaInicial";
            WindowState = FormWindowState.Maximized;
            Load += TelaInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistros;
        private Button btnNovo;
    }
}