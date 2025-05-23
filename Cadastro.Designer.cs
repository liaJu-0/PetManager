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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
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
            txtVacinas = new TextBox();
            txtObs = new TextBox();
            dateEntrada = new DateTimePicker();
            txtResumo = new TextBox();
            btnUpload = new Button();
            btnSalvar = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            txtTamanho = new ComboBox();
            txtPeso = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            label3.Location = new Point(587, 79);
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
            txtNome.Location = new Point(223, 133);
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
            dateEntrada.Size = new Size(296, 27);
            dateEntrada.TabIndex = 16;
            // 
            // txtResumo
            // 
            txtResumo.Location = new Point(587, 193);
            txtResumo.Multiline = true;
            txtResumo.Name = "txtResumo";
            txtResumo.Size = new Size(296, 97);
            txtResumo.TabIndex = 17;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(587, 468);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(132, 24);
            btnUpload.TabIndex = 18;
            btnUpload.Text = "Enviar foto";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(751, 468);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(132, 24);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 112);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 20;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(223, 110);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 21;
            label5.Text = "Nome";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(417, 112);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 22;
            label6.Text = "Raça";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(99, 176);
            label7.Name = "label7";
            label7.Size = new Size(151, 20);
            label7.TabIndex = 23;
            label7.Text = "Data de Nascimento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(280, 176);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 24;
            label8.Text = "Cor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(399, 176);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 25;
            label9.Text = "Pelagem";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(99, 304);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 26;
            label10.Text = "Castrado?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(99, 372);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 27;
            label11.Text = "Peso";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(99, 438);
            label12.Name = "label12";
            label12.Size = new Size(47, 20);
            label12.TabIndex = 28;
            label12.Text = "Porte";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(223, 304);
            label13.Name = "label13";
            label13.Size = new Size(61, 20);
            label13.TabIndex = 29;
            label13.Text = "Vacinas";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(223, 395);
            label14.Name = "label14";
            label14.Size = new Size(98, 20);
            label14.TabIndex = 30;
            label14.Text = "Observações";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(587, 110);
            label15.Name = "label15";
            label15.Size = new Size(121, 20);
            label15.TabIndex = 31;
            label15.Text = "Data de entrada";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(587, 170);
            label16.Name = "label16";
            label16.Size = new Size(66, 20);
            label16.TabIndex = 32;
            label16.Text = "Resumo";
            // 
            // txtTamanho
            // 
            txtTamanho.FormattingEnabled = true;
            txtTamanho.Items.AddRange(new object[] { "Pequeno", "Médio", "Grande" });
            txtTamanho.Location = new Point(99, 464);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(90, 28);
            txtTamanho.TabIndex = 33;
            txtTamanho.SelectedIndexChanged += txtTamanho_SelectedIndexChanged;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(99, 395);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(90, 27);
            txtPeso.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(958, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1242, 544);
            Controls.Add(pictureBox2);
            Controls.Add(txtTamanho);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSalvar);
            Controls.Add(btnUpload);
            Controls.Add(txtResumo);
            Controls.Add(dateEntrada);
            Controls.Add(txtObs);
            Controls.Add(txtVacinas);
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
            ForeColor = Color.Black;
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private TextBox txtVacinas;
        private TextBox txtObs;
        private DateTimePicker dateEntrada;
        private TextBox txtResumo;
        private Button btnUpload;
        private Button btnSalvar;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private ComboBox txtTamanho;
        private TextBox txtPeso;
        private PictureBox pictureBox2;
    }
}