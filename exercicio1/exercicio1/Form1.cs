namespace exercicio1
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
            pessoa p = new pessoa();
            p.idade = Convert.ToInt32(textBox2.Text);
            p.nome = textBox1.Text;
            MessageBox.Show("Ola, " + p.nome + " , idade " + p.idade);
        }
    }
}
