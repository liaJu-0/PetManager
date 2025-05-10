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
            boxFiltroPorte = new ComboBox();
            boxFiltroTipo = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            splitter1 = new Splitter();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Honeydew;
            groupBox1.Controls.Add(boxFiltroPorte);
            groupBox1.Controls.Add(boxFiltroTipo);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Location = new Point(35, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(145, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros:";
            groupBox1.Enter += groupBox1_Enter;
            // 
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
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1243, 543);
            Controls.Add(splitter1);
            Controls.Add(groupBox1);
            Name = "Registros";
            Text = "Registros";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckedListBox checkedListBox1;
        private Splitter splitter1;
        private ComboBox boxFiltroPorte;
        private ComboBox boxFiltroTipo;
    }
}