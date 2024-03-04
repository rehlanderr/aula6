namespace exercicio10
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
            funcionario f = new funcionario();
            f.Nome = textBox1.Text;
            f.Salario= Convert.ToDouble(textBox2.Text);
           

               
            MessageBox.Show(f.Nome + " seu salario anual é de: " + f.SalarioAnual(f.Salario).ToString());
        }
    }
}
