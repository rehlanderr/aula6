namespace exercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carro c = new carro();  
            c.marca = textBox1.Text;
            c.modelo = textBox2.Text;
            MessageBox.Show("Seu carro � da marca " + c.marca + ", modelo " + c.modelo);
        }
    }
}
