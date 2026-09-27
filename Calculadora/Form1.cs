namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double valor1 = 0;
        private double memoria = 0;
        private string operacao = "";
        private bool novoNumero = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void numero_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (novoNumero || textBoxVisor.Text == "0")
            {
                textBoxVisor.Text = botao.Text;
                novoNumero = false;
            }
            else
            {
                textBoxVisor.Text = textBoxVisor.Text + botao.Text;
            }
        }

        private void operacao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            valor1 = Convert.ToDouble(textBoxVisor.Text);
            operacao = botao.Text;
            novoNumero = true;
        }

        private void botaoIgual_Click(object sender, EventArgs e)
        {
            double valor2 = Convert.ToDouble(textBoxVisor.Text);
            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;

                case "-":
                    resultado = valor1 - valor2;
                    break;

                case "x":
                    resultado = valor1 * valor2;
                    break;

                case "/":
                    resultado = valor1 / valor2;
                    break;

                case "x^y":
                    resultado = Math.Pow(valor1, valor2);
                    break;
            }

            textBoxVisor.Text = Convert.ToString(resultado);
            novoNumero = true;
            operacao = "";
        }

        private void botaoRaiz_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBoxVisor.Text);
            double resultado = Math.Sqrt(valor);

            textBoxVisor.Text = Convert.ToString(resultado);
            novoNumero = true;
        }

        private void botaoClear_Click(object sender, EventArgs e)
        {
            textBoxVisor.Text = "0";
            valor1 = 0;
            memoria = 0;
            operacao = "";
            novoNumero = true;
        }

        private void botaoSobre_Click(object sender, EventArgs e)
        {
            using (Form2 formSobre = new Form2())
            {
                formSobre.ShowDialog();
            }
        }
    }
}
