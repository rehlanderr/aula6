using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
    internal class produto
    {
        public string nome;
        public double Ddp(double preco, double desconto)
        {
            return (preco - (desconto * (preco / 100)));
        }
    }
}
