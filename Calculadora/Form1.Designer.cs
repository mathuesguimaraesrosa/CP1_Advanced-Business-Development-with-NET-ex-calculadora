namespace Calculadora
{
    partial class Form1
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
            textBoxVisor = new TextBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonMais = new Button();
            buttonMenos = new Button();
            buttonMultiplicacao = new Button();
            buttonDivisao = new Button();
            buttonRaiz = new Button();
            buttonPotencia = new Button();
            buttonIgual = new Button();
            buttonClear = new Button();
            buttonSobre = new Button();
            SuspendLayout();

            textBoxVisor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxVisor.Location = new Point(20, 20);
            textBoxVisor.Name = "textBoxVisor";
            textBoxVisor.ReadOnly = true;
            textBoxVisor.Size = new Size(300, 39);
            textBoxVisor.TabIndex = 0;
            textBoxVisor.Text = "0";
            textBoxVisor.TextAlign = HorizontalAlignment.Right;

            button7.Location = new Point(20, 80);
            button7.Size = new Size(60, 45);
            button7.Text = "7";
            button7.Click += numero_Click;

            button8.Location = new Point(90, 80);
            button8.Size = new Size(60, 45);
            button8.Text = "8";
            button8.Click += numero_Click;

            button9.Location = new Point(160, 80);
            button9.Size = new Size(60, 45);
            button9.Text = "9";
            button9.Click += numero_Click;

            buttonDivisao.Location = new Point(230, 80);
            buttonDivisao.Size = new Size(90, 45);
            buttonDivisao.Text = "/";
            buttonDivisao.Click += operacao_Click;

            button4.Location = new Point(20, 135);
            button4.Size = new Size(60, 45);
            button4.Text = "4";
            button4.Click += numero_Click;

            button5.Location = new Point(90, 135);
            button5.Size = new Size(60, 45);
            button5.Text = "5";
            button5.Click += numero_Click;

            button6.Location = new Point(160, 135);
            button6.Size = new Size(60, 45);
            button6.Text = "6";
            button6.Click += numero_Click;

            buttonMultiplicacao.Location = new Point(230, 135);
            buttonMultiplicacao.Size = new Size(90, 45);
            buttonMultiplicacao.Text = "x";
            buttonMultiplicacao.Click += operacao_Click;

            button1.Location = new Point(20, 190);
            button1.Size = new Size(60, 45);
            button1.Text = "1";
            button1.Click += numero_Click;

            button2.Location = new Point(90, 190);
            button2.Size = new Size(60, 45);
            button2.Text = "2";
            button2.Click += numero_Click;

            button3.Location = new Point(160, 190);
            button3.Size = new Size(60, 45);
            button3.Text = "3";
            button3.Click += numero_Click;

            buttonMenos.Location = new Point(230, 190);
            buttonMenos.Size = new Size(90, 45);
            buttonMenos.Text = "-";
            buttonMenos.Click += operacao_Click;

            button0.Location = new Point(20, 245);
            button0.Size = new Size(60, 45);
            button0.Text = "0";
            button0.Click += numero_Click;

            buttonRaiz.Location = new Point(90, 245);
            buttonRaiz.Size = new Size(60, 45);
            buttonRaiz.Text = "√y";
            buttonRaiz.Click += botaoRaiz_Click;

            buttonPotencia.Location = new Point(160, 245);
            buttonPotencia.Size = new Size(60, 45);
            buttonPotencia.Text = "x^y";
            buttonPotencia.Click += operacao_Click;

            buttonMais.Location = new Point(230, 245);
            buttonMais.Size = new Size(90, 45);
            buttonMais.Text = "+";
            buttonMais.Click += operacao_Click;

            buttonClear.Location = new Point(20, 300);
            buttonClear.Size = new Size(90, 45);
            buttonClear.Text = "C";
            buttonClear.Click += botaoClear_Click;

            buttonIgual.Location = new Point(120, 300);
            buttonIgual.Size = new Size(100, 45);
            buttonIgual.Text = "=";
            buttonIgual.Click += botaoIgual_Click;

            buttonSobre.Location = new Point(230, 300);
            buttonSobre.Size = new Size(90, 45);
            buttonSobre.Text = "Sobre";
            buttonSobre.Click += botaoSobre_Click;

            ClientSize = new Size(340, 370);
            Controls.Add(textBoxVisor);
            Controls.Add(button0);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(buttonMais);
            Controls.Add(buttonMenos);
            Controls.Add(buttonMultiplicacao);
            Controls.Add(buttonDivisao);
            Controls.Add(buttonRaiz);
            Controls.Add(buttonPotencia);
            Controls.Add(buttonIgual);
            Controls.Add(buttonClear);
            Controls.Add(buttonSobre);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBoxVisor;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonMais;
        private Button buttonMenos;
        private Button buttonMultiplicacao;
        private Button buttonDivisao;
        private Button buttonRaiz;
        private Button buttonPotencia;
        private Button buttonIgual;
        private Button buttonClear;
        private Button buttonSobre;
    }
}
