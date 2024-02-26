using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    internal class Circulo
    {
        public double raio;
        // Propriedade Raio
        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }
        // Propriedade Diametro (calculado)
        public double Diametro
        {
            get { return 2 * raio; }
        }
    }
}
