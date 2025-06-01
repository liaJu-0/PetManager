namespace PetManager
{
    partial class TelaInicial
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            label1 = new Label();
            btnRegistros = new Button();
            btnNovo = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(820, 193);
            label1.MaximumSize = new Size(263, 36);
            label1.MinimumSize = new Size(263, 36);
            label1.Name = "label1";
            label1.Size = new Size(263, 36);
            label1.TabIndex = 1;
            label1.Text = "Seja Bem Vindo!";
            // btnRegistros
            btnRegistros.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistros.ForeColor = Color.DarkGreen;
            btnRegistros.Location = new Point(885, 297);
            btnRegistros.MaximumSize = new Size(160, 40);
            btnRegistros.MinimumSize = new Size(160, 40);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(160, 40);
            btnRegistros.TabIndex = 2;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = true;
            btnRegistros.Click += btnRegistros_Click;
            // btnNovo
            btnNovo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.ForeColor = Color.DarkGreen;
            btnNovo.Location = new Point(885, 349);
            btnNovo.MaximumSize = new Size(160, 40);
            btnNovo.MinimumSize = new Size(160, 40);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(160, 40);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo Registro";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // pictureBox3
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.botaosair2;
            pictureBox3.Location = new Point(1761, 60);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox1_Click;
            pictureBox3.MouseEnter += pictureBox3_MouseEnter;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            // TelaInicial
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pictureBox3);
            Controls.Add(btnNovo);
            Controls.Add(btnRegistros);
            Controls.Add(label1);
            Name = "TelaInicial";
            Text = "TelaInicial";
            WindowState = FormWindowState.Maximized;
            Load += TelaInicial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistros;
        private Button btnNovo;
        private PictureBox pictureBox3;
    }
}