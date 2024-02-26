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
            c.marca = Convert.ToInt32(textBox1.Text);
                MessageBox
            c.modelo = Convert.ToInt32(textBox2.Text);
        }
    }
}
