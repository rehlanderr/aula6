namespace exercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            livro l = new livro();  
            l.Titulo = textBox1.Text;
            l.Autor = textBox2.Text;
            l.Ano = Convert.ToInt32(textBox3.Text); 
            l.Edicao = Convert.ToInt32(textBox4.Text);
            MessageBox.Show("O livro" + l.Titulo + " escrito por" + l.Autor + " da edicao " + l.Edicao + " foi publicado em " + l.Ano);

        }
    }
}
