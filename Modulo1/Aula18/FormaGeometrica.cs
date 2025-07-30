using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18
{
    internal abstract class FormaGeometrica
    {
        public abstract double CalcularArea();

        public override string ToString()
        {
            return $"Objeto com area de {CalcularArea()}";
        }
    }
}
