using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    internal class funcionario
    {
        public funcionario() { }
        public string Nome;
        public double Salario;

        public double SalarioAnual( double Salario)
        {
            return Salario * 12;
        }

    }
}
