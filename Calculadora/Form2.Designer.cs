namespace Calculadora
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitulo = new Label();
            labelIntegrantes = new Label();
            labelResumo = new Label();
            labelGithub = new Label();
            SuspendLayout();

            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(20, 20);
            labelTitulo.Text = "Sobre";

            labelIntegrantes.AutoSize = true;
            labelIntegrantes.Location = new Point(20, 65);
            labelIntegrantes.Text = "Integrantes: Nome / RM";

            labelResumo.AutoSize = false;
            labelResumo.Location = new Point(20, 105);
            labelResumo.Size = new Size(390, 80);
            labelResumo.Text = "Resumo: calculadora básica semi-científica em C# e Windows Forms.";

            labelGithub.AutoSize = true;
            labelGithub.Location = new Point(20, 205);
            labelGithub.Text = "GitHub: link do projeto";

            ClientSize = new Size(430, 250);
            Controls.Add(labelTitulo);
            Controls.Add(labelIntegrantes);
            Controls.Add(labelResumo);
            Controls.Add(labelGithub);
            Name = "Form2";
            Text = "Sobre";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelTitulo;
        private Label labelIntegrantes;
        private Label labelResumo;
        private Label labelGithub;
    }
}
