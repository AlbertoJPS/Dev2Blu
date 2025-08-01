using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19.Interfaces
{
    public interface IMotorizado
    {
        double Temperatura { get; set; }

        void Ligar();
        void Desligar();
    }
}
