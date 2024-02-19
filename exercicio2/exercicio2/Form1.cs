namespace exercicio2
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
            retangulo r = new retangulo();
            r.valor1 = Convert.ToInt32(textBox1.Text);
            r.valor2 = Convert.ToInt32(textBox2.Text);
            Int32 soma = r.valor1 * r.valor2;
            MessageBox.Show("resultado" + soma.ToString());
        }
    }
}
