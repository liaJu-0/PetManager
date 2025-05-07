namespace PetManager
{
    partial class Cadastro
    {
        private void label13_Click(object sender, EventArgs e)
        {
            // Implement the desired behavior for the label13 click event here
            MessageBox.Show("Label13 clicked!");
        }
        private void txtResumo_TextChanged(object sender, EventArgs e)
        {

        }
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTipo = new TextBox();
            txtRaca = new TextBox();
            txtNome = new TextBox();
            txtCorPelo = new TextBox();
            txtTamPelo = new TextBox();
            dateNscto = new DateTimePicker();
            comboBoxCastrado = new ComboBox();
            txtTamanho = new TextBox();
            txtPeso = new TextBox();
            txtVacinas = new TextBox();
            txtObs = new TextBox();
            dateEntrada = new DateTimePicker();
            txtResumo = new TextBox();
            btnUpload = new Button();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.transferir1;
            pictureBox1.Location = new Point(587, 327);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(99, 79);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 1;
            label1.Text = "Dados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(99, 262);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 2;
            label2.Text = "Saúde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(587, 70);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 3;
            label3.Text = "Entrada";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(99, 135);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(103, 27);
            txtTipo.TabIndex = 4;
            // 
            // txtRaca
            // 
            txtRaca.Location = new Point(417, 135);
            txtRaca.Name = "txtRaca";
            txtRaca.Size = new Size(85, 27);
            txtRaca.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(223, 135);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(177, 27);
            txtNome.TabIndex = 6;
            // 
            // txtCorPelo
            // 
            txtCorPelo.Location = new Point(280, 199);
            txtCorPelo.Name = "txtCorPelo";
            txtCorPelo.Size = new Size(103, 27);
            txtCorPelo.TabIndex = 8;
            // 
            // txtTamPelo
            // 
            txtTamPelo.Location = new Point(399, 199);
            txtTamPelo.Name = "txtTamPelo";
            txtTamPelo.Size = new Size(103, 27);
            txtTamPelo.TabIndex = 9;
            // 
            // dateNscto
            // 
            dateNscto.Location = new Point(99, 199);
            dateNscto.Name = "dateNscto";
            dateNscto.Size = new Size(163, 27);
            dateNscto.TabIndex = 10;
            // 
            // comboBoxCastrado
            // 
            comboBoxCastrado.FormattingEnabled = true;
            comboBoxCastrado.Items.AddRange(new object[] { "Sim", "Não" });
            comboBoxCastrado.Location = new Point(99, 327);
            comboBoxCastrado.Name = "comboBoxCastrado";
            comboBoxCastrado.Size = new Size(90, 28);
            comboBoxCastrado.TabIndex = 11;
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(99, 465);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(90, 27);
            txtTamanho.TabIndex = 13;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(99, 395);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(90, 27);
            txtPeso.TabIndex = 12;
            // 
            // txtVacinas
            // 
            txtVacinas.Location = new Point(223, 327);
            txtVacinas.Multiline = true;
            txtVacinas.Name = "txtVacinas";
            txtVacinas.Size = new Size(279, 60);
            txtVacinas.TabIndex = 14;
            // 
            // txtObs
            // 
            txtObs.Location = new Point(223, 419);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(279, 73);
            txtObs.TabIndex = 15;
            // 
            // dateEntrada
            // 
            dateEntrada.Location = new Point(587, 133);
            dateEntrada.Name = "dateEntrada";
            dateEntrada.Size = new Size(238, 27);
            dateEntrada.TabIndex = 16;
            // 
            // txtResumo
            // 
            txtResumo.Location = new Point(587, 193);
            txtResumo.Multiline = true;
            txtResumo.Name = "txtResumo";
            txtResumo.Size = new Size(238, 97);
            txtResumo.TabIndex = 17;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(587, 468);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(132, 21);
            btnUpload.TabIndex = 18;
            btnUpload.Text = "button1";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1031, 316);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(132, 34);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "button1";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1242, 544);
            Controls.Add(btnSalvar);
            Controls.Add(btnUpload);
            Controls.Add(txtResumo);
            Controls.Add(dateEntrada);
            Controls.Add(txtObs);
            Controls.Add(txtVacinas);
            Controls.Add(txtTamanho);
            Controls.Add(txtPeso);
            Controls.Add(comboBoxCastrado);
            Controls.Add(dateNscto);
            Controls.Add(txtTamPelo);
            Controls.Add(txtCorPelo);
            Controls.Add(txtRaca);
            Controls.Add(txtNome);
            Controls.Add(txtTipo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Cadastro";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTipo;
        private TextBox txtRaca;
        private TextBox txtNome;
        private TextBox txtCorPelo;
        private TextBox txtTamPelo;
        private DateTimePicker dateNscto;
        private ComboBox comboBoxCastrado;
        private TextBox txtTamanho;
        private TextBox txtPeso;
        private TextBox txtVacinas;
        private TextBox txtObs;
        private DateTimePicker dateEntrada;
        private TextBox txtResumo;
        private Button btnUpload;
        private Button btnSalvar;
    }
}