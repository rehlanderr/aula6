namespace exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criando uma inst�ncia da classe Circulo
            Circulo meuCirculo = new Circulo();
            meuCirculo.Raio = 5.0; // Definindo o raio
                                   // Calculando e exibindo o di�metro
            double diametro = meuCirculo.Diametro;
            MessageBox.Show($"O di�metro do c�rculo �: {diametro}");
            // Aguarde para ver o resultado
            Console.ReadLine();
        }
    }
}
