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
            SuspendLayout();
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1242, 544);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
        }

        #endregion
    }
}