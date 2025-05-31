namespace PetManager
{
    partial class Registros
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
            groupBox1 = new GroupBox();
            BoxFiltroTipo = new ComboBox();
            BoxFiltroPorte = new ComboBox();
            CheckListBox1 = new CheckedListBox();
            TxtPesquisa = new TextBox();
            ListPesquisa = new TextBox();
            panel1 = new Panel();
            btnVoltar = new Button();
            btnFiltrar = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Honeydew;
            groupBox1.Controls.Add(BoxFiltroTipo);
            groupBox1.Controls.Add(BoxFiltroPorte);
            groupBox1.Controls.Add(CheckListBox1);
            groupBox1.Location = new Point(31, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(145, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BoxFiltroTipo
            // 
            BoxFiltroTipo.AutoCompleteCustomSource.AddRange(new string[] { "Grande", "Médio", "Pequeno" });
            BoxFiltroTipo.FormattingEnabled = true;
            BoxFiltroTipo.Items.AddRange(new object[] { "Gato", "Cachorro", "Outro" });
            BoxFiltroTipo.Location = new Point(6, 132);
            BoxFiltroTipo.Name = "BoxFiltroTipo";
            BoxFiltroTipo.Size = new Size(89, 28);
            BoxFiltroTipo.TabIndex = 3;
            BoxFiltroTipo.Text = "Tipo";
            BoxFiltroTipo.SelectedIndexChanged += BoxFiltroTipo_SelectedIndexChanged_1;
            // 
            // BoxFiltroPorte
            // 
            BoxFiltroPorte.AutoCompleteCustomSource.AddRange(new string[] { "Grande", "Médio", "Pequeno" });
            BoxFiltroPorte.FormattingEnabled = true;
            BoxFiltroPorte.Items.AddRange(new object[] { "Pequeno", "Médio", "Grande" });
            BoxFiltroPorte.Location = new Point(6, 98);
            BoxFiltroPorte.Name = "BoxFiltroPorte";
            BoxFiltroPorte.Size = new Size(89, 28);
            BoxFiltroPorte.TabIndex = 2;
            BoxFiltroPorte.Text = "Porte";
            BoxFiltroPorte.SelectedIndexChanged += boxFiltroPorte_SelectedIndexChanged;
            // 
            // CheckListBox1
            // 
            CheckListBox1.BackColor = Color.Honeydew;
            CheckListBox1.BorderStyle = BorderStyle.None;
            CheckListBox1.FormattingEnabled = true;
            CheckListBox1.Items.AddRange(new object[] { "Todos", "Ativos", "Inativos" });
            CheckListBox1.Location = new Point(6, 26);
            CheckListBox1.Name = "CheckListBox1";
            CheckListBox1.Size = new Size(118, 66);
            CheckListBox1.TabIndex = 0;
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.BackColor = Color.Honeydew;
            TxtPesquisa.Cursor = Cursors.Hand;
            TxtPesquisa.Location = new Point(250, 170);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.ShortcutsEnabled = false;
            TxtPesquisa.Size = new Size(567, 27);
            TxtPesquisa.TabIndex = 1;
            TxtPesquisa.Text = "Pesquise...";
            TxtPesquisa.KeyDown += TxtPesquisa_KeyDown;
            // 
            // ListPesquisa
            // 
            ListPesquisa.BackColor = Color.DarkSeaGreen;
            ListPesquisa.BorderStyle = BorderStyle.None;
            ListPesquisa.Location = new Point(3, 3);
            ListPesquisa.Name = "ListPesquisa";
            ListPesquisa.Size = new Size(561, 20);
            ListPesquisa.TabIndex = 2;
            ListPesquisa.Visible = false;
            ListPesquisa.TextChanged += ListPesquisa_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(ListPesquisa);
            panel1.Location = new Point(250, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 145);
            panel1.TabIndex = 3;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(721, 433);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(87, 28);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(37, 356);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(129, 30);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = Properties.Resources.Pet_Manager21;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1243, 543);
            Controls.Add(btnFiltrar);
            Controls.Add(btnVoltar);
            Controls.Add(panel1);
            Controls.Add(TxtPesquisa);
            Controls.Add(groupBox1);
            Name = "Registros";
            Text = "Registros";
            WindowState = FormWindowState.Maximized;
            Load += Registros_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckedListBox CheckListBox1;
        private ComboBox BoxFiltroPorte;
        private TextBox TxtPesquisa;
        private TextBox ListPesquisa;
        private Panel panel1;
        private Button btnVoltar;
        private Button btnFiltrar;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void boxFiltroPorte_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void boxFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
        private ComboBox BoxFiltroTipo;
    }
}
