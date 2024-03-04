namespace exercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            produto p = new produto();
            double d;
            p.nome = textBox1.Text;
            d = p.Ddp(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            MessageBox.Show("O produto " + p.nome + " ficou no valor de " + d);
        }
    }
}
