namespace exercicio3
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
            contabancaria cb = new contabancaria();
            cb.valor1 = Convert.ToInt32(textBox1.Text);
            cb.valor2 = Convert.ToInt32(textBox2.Text);
            if (cb.valor1 > cb.valor2)
                MessageBox.Show("Seu saldo esta maior que seu limite");
            if (cb.valor1 < cb.valor2)
                MessageBox.Show("Seu limite esta maior que seu saldo");
            if (cb.valor1 == cb.valor2)
                MessageBox.Show("Seu limite esta igual ao seu saldo");

        }
    }
}
