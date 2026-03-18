namespace WellingtonHenriqueDaSilva_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura;


            if (!double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Por favor, insira um valor numérico válido para o peso.");
                return;

            }
            if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Por favor, insira um valor numérico válido para a altura.");
                return;
            }
            double imc = peso / (altura * altura);
            lbResultado.Text = imc.ToString("n2");

            if (imc < 18.5)
            {
                MessageBox.Show ( " Classificação: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                lbClassificacao.Text = "Classificação: Peso normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                lbClassificacao.Text = "Classificação: Sobrepeso";
            }
            else if (imc >= 30 && imc < 35)
            {
                lbClassificacao.Text = "Classificação: Obesidade Grau I";
            }
            else if (imc >= 35 && imc < 40)
            {
                lbClassificacao.Text = "Classificação: Obesidade Grau II";
            }
            else
            {
                lbClassificacao.Text = "Classificação: Obesidade Grau III";
            }
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
