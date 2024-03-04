namespace exercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            triandulo t = new triandulo();
            double p; 
            p = t.Perimetro(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            MessageBox.Show("O perimetro é; " + p);
        }

       

    }
}
