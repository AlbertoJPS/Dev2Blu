using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18
{
    internal class Circulo : FormaGeometrica
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);

        }
    }
}
