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
<<<<<<< HEAD
            BoxFiltroPorte = new ComboBox();
            BoxFiltroTipo = new ComboBox();
            CheckListBox1 = new CheckedListBox();
            TxtPesquisa = new TextBox();
            ListPesquisa = new TextBox();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
=======
            boxFiltroPorte = new ComboBox();
            boxFiltroTipo = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            splitter1 = new Splitter();
            groupBox1.SuspendLayout();
>>>>>>> 7b27e75a654fe2c23e51b04de728b637d70283b7
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Honeydew;
<<<<<<< HEAD
            groupBox1.Controls.Add(BoxFiltroPorte);
            groupBox1.Controls.Add(BoxFiltroTipo);
            groupBox1.Controls.Add(CheckListBox1);
=======
            groupBox1.Controls.Add(boxFiltroPorte);
            groupBox1.Controls.Add(boxFiltroTipo);
            groupBox1.Controls.Add(checkedListBox1);
>>>>>>> 7b27e75a654fe2c23e51b04de728b637d70283b7
            groupBox1.Location = new Point(35, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(145, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros:";
            groupBox1.Enter += groupBox1_Enter;
            // 
<<<<<<< HEAD
            // BoxFiltroPorte
            // 
            BoxFiltroPorte.AutoCompleteCustomSource.AddRange(new string[] { "Grande", "Médio", "Pequeno" });
            BoxFiltroPorte.FormattingEnabled = true;
            BoxFiltroPorte.Items.AddRange(new object[] { "Pequeno", "Médio", "Grande" });
            BoxFiltroPorte.Location = new Point(6, 140);
            BoxFiltroPorte.Name = "BoxFiltroPorte";
            BoxFiltroPorte.Size = new Size(89, 28);
            BoxFiltroPorte.TabIndex = 2;
            BoxFiltroPorte.Text = "Porte";
            BoxFiltroPorte.SelectedIndexChanged += boxFiltroPorte_SelectedIndexChanged;
            // 
            // BoxFiltroTipo
            // 
            BoxFiltroTipo.FormattingEnabled = true;
            BoxFiltroTipo.Items.AddRange(new object[] { "Cachorro", "Gato", "Outros" });
            BoxFiltroTipo.Location = new Point(6, 106);
            BoxFiltroTipo.Name = "BoxFiltroTipo";
            BoxFiltroTipo.Size = new Size(89, 28);
            BoxFiltroTipo.TabIndex = 1;
            BoxFiltroTipo.Text = "Tipos";
            BoxFiltroTipo.SelectedIndexChanged += boxFiltroTipo_SelectedIndexChanged;
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
            TxtPesquisa.Location = new Point(244, 132);
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
            ListPesquisa.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(ListPesquisa);
            panel1.Location = new Point(244, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 40);
            panel1.TabIndex = 3;
=======
            // boxFiltroPorte
            // 
            boxFiltroPorte.AutoCompleteCustomSource.AddRange(new string[] { "Grande", "Médio", "Pequeno" });
            boxFiltroPorte.FormattingEnabled = true;
            boxFiltroPorte.Items.AddRange(new object[] { "Pequeno", "Médio", "Grande" });
            boxFiltroPorte.Location = new Point(6, 140);
            boxFiltroPorte.Name = "boxFiltroPorte";
            boxFiltroPorte.Size = new Size(89, 28);
            boxFiltroPorte.TabIndex = 2;
            boxFiltroPorte.Text = "Porte";
            boxFiltroPorte.SelectedIndexChanged += boxFiltroPorte_SelectedIndexChanged;
            // 
            // boxFiltroTipo
            // 
            boxFiltroTipo.FormattingEnabled = true;
            boxFiltroTipo.Items.AddRange(new object[] { "Cachorro", "Gato", "Outros" });
            boxFiltroTipo.Location = new Point(6, 106);
            boxFiltroTipo.Name = "boxFiltroTipo";
            boxFiltroTipo.Size = new Size(89, 28);
            boxFiltroTipo.TabIndex = 1;
            boxFiltroTipo.Text = "Tipos";
            boxFiltroTipo.SelectedIndexChanged += boxFiltroTipo_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.Honeydew;
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Todos", "Ativos", "Inativos" });
            checkedListBox1.Location = new Point(6, 26);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(148, 66);
            checkedListBox1.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 543);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
>>>>>>> 7b27e75a654fe2c23e51b04de728b637d70283b7
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1243, 543);
<<<<<<< HEAD
            Controls.Add(panel1);
            Controls.Add(TxtPesquisa);
=======
            Controls.Add(splitter1);
>>>>>>> 7b27e75a654fe2c23e51b04de728b637d70283b7
            Controls.Add(groupBox1);
            Name = "Registros";
            Text = "Registros";
            groupBox1.ResumeLayout(false);
<<<<<<< HEAD
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
=======
>>>>>>> 7b27e75a654fe2c23e51b04de728b637d70283b7
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
<<<<<<< HEAD
        private CheckedListBox CheckListBox1;
        private ComboBox BoxFiltroPorte;
        private ComboBox BoxFiltroTipo;
        private TextBox TxtPesquisa;
        private TextBox ListPesquisa;
        private Panel panel1;
=======
        private CheckedListBox checkedListBox1;
        private Splitter splitter1;
        private ComboBox boxFiltroPorte;
        private ComboBox boxFiltroTipo;
>>>>>>> 7b27e75a654fe2c23e51b04de728b637d70283b7
    }
}